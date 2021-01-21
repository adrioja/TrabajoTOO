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
        /// 
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
            if (this.presupuesto != null)
            {
                this.asignarDatos();
                
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
                    String s =v.NumBastidor + "-" +v.Modelo + "-" + v.Marca + "-" + v.PvRecomendado.ToString();
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

        }
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Dado el presupuesto que tenemos, se rellenan todos los textBox del formulario con sus datos
        /// </summary>
        private void asignarDatos()
        {

        }

        private void clbVehiculos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // para cuando se selecciona un elemento hay que hacer que este se añada al posible vehiculo comprado

            //limpiamos la lista
            this.cVehiculoComprado.Items.Clear();

            //cogemos los seleccionados y los añadimos
            CheckedItemCollection l = this.clbVehiculos.CheckedItems;
            foreach(Item i in l)
            {
                this.cVehiculoComprado.Items.Add(i.ToString());
            }

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

        }

        private bool formatosCorrectos()
        {
            return true;
        }

        internal Presupuesto devolverPresupuesto()

            //REPASAR falta caso que no halla ninguno comprado ---------------------------------------------------------    ISRA ESTA MAL REPASALO CORRIGELO 
        {
            Cliente c = LNCliente.LogicaNegocioCliente.Buscar(new Cliente(this.cCliente.SelectedItem.ToString()));
            String[] s = this.tbFecha.Text.Split('/');
            DateTime fecha = new DateTime(Int16.Parse(s[2]), Int16.Parse(s[1]), Int16.Parse(s[0]));

            CheckedItemCollection l = this.clbVehiculos.CheckedItems;
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            foreach(Item i in l)
            {
                string []t = i.ToString().Split('-');
                Vehiculo v2 = LNVehiculo.LogicaNegocioVehiculo.buscar(new VehiculoNuevo(t[0]));
                vehiculos.Add(v2);
            }

            string[] p = this.cVehiculoComprado.SelectedItem.ToString().Split('-');
            Vehiculo v=null;
            if(p!=null)//caso hay uno seleccionado
            {
                v = LNVehiculo.LogicaNegocioVehiculo.buscar(new VehiculoNuevo(p[0]));
            }
            

            return new Presupuesto(this.tbIdentificador.Text, c, fecha, this.tbEstado.Text,vehiculos,v);
        }
    }
}