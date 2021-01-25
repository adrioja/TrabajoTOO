using modeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para introducir el restode datos de un presupuesto
    /// </summary>
    public partial class RestoDatosPresupuesto : Form
    {
        private Presupuesto presupuesto;

        /// <summary>
        /// Inicializa la clase, se debe utlizar cuando se quiera hacer una operacion de alta o actualizacion
        /// </summary>
        public RestoDatosPresupuesto(String id)
        {
            InitializeComponent();
            this.presupuesto = new Presupuesto(id);
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbIdentificador.Text = this.presupuesto.Id;
            this.tbIdentificador.ReadOnly = true;
            
            this.presupuesto = LNPresupuesto.LogicaNegocioPresupuesto.buscarPresupuesto(this.presupuesto);

            if (this.presupuesto != null) //caso actualizar
            {
                this.asignarDatos();
                this.cCliente.Enabled = false;
                this.tbFecha.ReadOnly = true;
                this.clbVehiculos.Enabled = false;
            }
            else
            {
                this.presupuesto = new Presupuesto(id);
                //para poder asignar el presupuesto a un cliente
                List<Cliente> lista = LNCliente.LogicaNegocioCliente.ListaClientes();
                foreach (Cliente c in lista)
                {
                    this.cCliente.Items.Add(c.DNI);
                }

                List<Vehiculo> listaV = LNVehiculo.LogicaNegocioVehiculo.listaDeTodosLosVehiculos();
                foreach (Vehiculo v in listaV)
                {
                    String s =v.NumBastidor + "- " +v.Modelo + "  -  " + v.Marca + "  -  " + v.PvRecomendado.ToString();
                    this.clbVehiculos.Items.Add(s);
                }

            }
        }

        /// <summary>
        /// Inicializa la clase, se debe utlizar cuando se quiera hacer una operacion de baja o de busqueda
        /// </summary>
        /// <param name="c"></param>
        public RestoDatosPresupuesto(Presupuesto p)
        {
            InitializeComponent();
            this.presupuesto = p;
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbIdentificador.Text = this.presupuesto.Id;
            this.tbIdentificador.ReadOnly = true;
            this.asignarDatos();
            this.deshabilitar();
        }
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: pone todos los textbox como deshabilitados
        /// </summary>
        private void deshabilitar()
        {
            this.cCliente.Enabled = false;
            this.tbFecha.ReadOnly = true;
            this.clbVehiculos.Enabled = false;
            this.tbFecha.ReadOnly = true;
            this.tbEstado.ReadOnly = true;
            this.cVehiculoComprado.Enabled = false;
        }
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Dado el presupuesto que tenemos, se rellenan todos los textBox del formulario con sus datos
        /// </summary>
        private void asignarDatos()
        {
            this.cCliente.Items.Add(this.presupuesto.ClienteAsociado.DNI);
            this.cCliente.SelectedIndex = 0;
            this.tbFecha.Text = this.presupuesto.FechaRealizacion.ToShortDateString();
            this.tbEstado.Text = this.presupuesto.Estado;

            int cont = 0;
            foreach(Vehiculo v in this.presupuesto.Vehiculos)
            {
                String s = v.NumBastidor + "- " + v.Modelo + "  -  " + v.Marca + "  -  " + v.PvRecomendado.ToString();
                this.clbVehiculos.Items.Add(s);
                this.clbVehiculos.SetItemChecked(cont, true);
                cont++;
            }
            
            if(this.presupuesto.VehiculoComprado!=null) //caso comprado uno
            {
                String s = this.presupuesto.VehiculoComprado.NumBastidor + "- " + this.presupuesto.VehiculoComprado.Modelo + "  -  " + this.presupuesto.VehiculoComprado.Marca + "  -  " + this.presupuesto.VehiculoComprado.PvRecomendado.ToString();
                this.cVehiculoComprado.Items.Add(s);
                this.cVehiculoComprado.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// Evento generado cuando se hace clic en un checkbox de la lista de los vehiculos. Se queda marcado el checkbox y se añade el vehiculo a el combobox de vehiculo comprado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clbVehiculos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // para cuando se selecciona un elemento hay que hacer que este se añada al posible vehiculo comprado

            //limpiamos la lista
            this.cVehiculoComprado.Items.Clear();
            List<String> l = new List<string>();

            foreach(var v in this.clbVehiculos.CheckedItems)
            {
                l.Add(v.ToString());
            }

            if (e.NewValue== CheckState.Checked)
            {
                l.Add(this.clbVehiculos.Items[e.Index].ToString());
            }
            else
            {
                l.Remove(this.clbVehiculos.Items[e.Index].ToString());
            }

            //cogemos los seleccionados y los añadimos al posible vehiculo comprado
            
            foreach(String i in l)
            {
                this.cVehiculoComprado.Items.Add(i);
            }

        }
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en aceptar si los formatos no son correcto no deja continuar, si es correcto deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (!this.formatosCorrectos())
            {
                this.DialogResult = DialogResult.None;
            }
        }
        /// <summary>
        /// PRE: la clase debe estar inicializada
        /// POST: devuelve true si todos los campos cumplen el formato y falso en caso contrario y muestra un mensaje de error del primer formato que se ha encontrado erroneo
        /// </summary>
        /// <returns></returns>
        private bool formatosCorrectos()
        {
            bool correcto = true;
            String mensaje = "";

            Object c =  this.cCliente.SelectedItem;
            if(correcto && c==null) //no hay ningun cliente seleccionado
            {
                mensaje = "Selecciona un cliente";
                correcto = false;
            }


            String fecha = this.tbFecha.Text;
            DateTime resultado;
            if (correcto && !DateTime.TryParse(fecha, out resultado))
            {
                mensaje = "El formato de la fecha es incorrecto";
                correcto = false;
            }

            if (correcto && this.tbEstado.Text.TrimStart().Length==0)
            {
                mensaje = "Introduce el estado";
                correcto = false;
            }

            if(correcto && this.clbVehiculos.CheckedItems.Count==0)
            {
                mensaje = "Debes añadir algun vehiculo al presupuesto";
                correcto = false;
            }


            if (!correcto)
            {
                DialogResult dr = MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr.Equals(DialogResult.OK))
                {
                    this.DialogResult = DialogResult.None;

                }
            }


            return correcto;
        }
        /// <summary>
        /// PRE: la clase debe estar inicializada
        /// POST:Devuelve un presupuesto reyenandolo con los datos que hay en los textBox, sin comprobar que estos sean datos correctos.
        /// </summary>
        /// <returns></returns>
        internal Presupuesto devolverPresupuesto()
            //se usa cunado los formatos ya se saben que son correctos
        {
            Cliente c = LNCliente.LogicaNegocioCliente.Buscar(new Cliente(this.cCliente.SelectedItem.ToString()));

            DateTime fecha;
            DateTime.TryParse(this.tbFecha.Text,out fecha);

            CheckedItemCollection l = this.clbVehiculos.CheckedItems;
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            foreach (String i in l)
            {
                string []t = i.ToString().Split('-');
                
                Vehiculo v2 = new VehiculoNuevo(t[0]);
                v2 = LNVehiculo.LogicaNegocioVehiculo.buscar(v2);
                vehiculos.Add(v2);
            }

            Object p = this.cVehiculoComprado.SelectedItem;
            Vehiculo v=null;
            if(p!=null)
            {
                string[] r = this.cVehiculoComprado.SelectedItem.ToString().Split('-');
                v = new VehiculoNuevo(r[0]);
                v = LNVehiculo.LogicaNegocioVehiculo.buscar(v);
            }
            return new Presupuesto(this.tbIdentificador.Text, c, fecha, this.tbEstado.Text,vehiculos,v);
        }
    }
}