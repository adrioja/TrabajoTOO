using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using modeloDominio;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para recoger/introducir el resto de datos de un extra
    /// </summary>
    public partial class RestoDatosVehiculo : Form
    {
        private Vehiculo vehiculo;

        /// <summary>
        /// Constructor de la clase, se debe utlizar cuando se quiera hacer una operacion de alta o actualizacion
        /// </summary>
        /// <param name="b"></param>
        public RestoDatosVehiculo(String b)
        {
            InitializeComponent();
            this.vehiculo = new VehiculoNuevo(b);
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNumeroBastidor.Text = vehiculo.NumBastidor;
            this.rbtNuevo.Checked = true;

            this.vehiculo = LNVehiculo.LogicaNegocioVehiculo.buscar(this.vehiculo);
            if (vehiculo != null) //caso actualizar
            {
                this.rbtNuevo.Enabled = false;
                this.rbtSegundaMano.Enabled = false;
                this.asignarDatos();
                VehiculoSegundaMano ve = this.vehiculo as VehiculoSegundaMano;
                if (ve == null)
                {
                    this.rbtNuevo.Checked = true;
                }
                else
                {
                    this.rbtSegundaMano.Checked = true;
                    this.tbMatricula.Text = ve.Matricula;
                    this.tbFechaMatriculacion.Text = ve.FechaMatriculacion.Date.ToShortDateString();
                }
            }
            else
            {
                this.vehiculo = new VehiculoNuevo(b);
            }

        }

        /// <summary>
        /// Constructor de la clase, se debe utlizar cuando se quiera hacer una operacion de baja o de busqueda
        /// </summary>
        /// <param name="e"></param>
        public RestoDatosVehiculo(Vehiculo e)
        {
            
            InitializeComponent();
            this.vehiculo = e;
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNumeroBastidor.Text = vehiculo.NumBastidor;
            this.rbtNuevo.Checked = true;

            this.asignarDatos();
            VehiculoSegundaMano ve = this.vehiculo as VehiculoSegundaMano;
            if (ve == null)
            {
                this.rbtNuevo.Checked = true;

            }
            else
            {
                this.rbtSegundaMano.Checked = true;
                this.tbMatricula.Text = ve.Matricula;
                this.tbFechaMatriculacion.Text = ve.FechaMatriculacion.Date.ToShortDateString();
            }
            this.deshabilitar();
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: pone todos los textbox y botones circulares como deshabilitados
        /// </summary>
        private void deshabilitar()
        {
            this.tbNumeroBastidor.ReadOnly = true;
            this.tbMarca.ReadOnly = true;
            this.tbModelo.ReadOnly = true;
            this.tbPotencia.ReadOnly = true;
            this.tbPrecioRecomendado.ReadOnly = true;
            this.tbMatricula.ReadOnly = true;
            this.tbFechaMatriculacion.ReadOnly = true;
            this.rbtNuevo.Enabled = false;
            this.rbtSegundaMano.Enabled = false;
        }
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Dado el vehiculo que tenemos, se reyenan todos los textBox del formulario con sus datos
        /// </summary>
        private void asignarDatos()
        {
            this.tbNumeroBastidor.Text = this.vehiculo.NumBastidor;
            this.tbMarca.Text = this.vehiculo.Marca;
            this.tbModelo.Text = this.vehiculo.Modelo;
            this.tbPotencia.Text = this.vehiculo.Potencia + "";
            this.tbPrecioRecomendado.Text = this.vehiculo.PvRecomendado + "";
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Devuelve un vehiculo reyenandolo con los datos que hay en los textBox, sin comprobar que estos sean datos correctos.
        /// </summary>
        /// <returns></returns>
        internal Vehiculo devVehiculo()
        {
            int potencia = Int32.Parse(this.tbPotencia.Text) ;
            double precio = Double.Parse(this.tbPrecioRecomendado.Text);
            if(this.rbtNuevo.Checked)
            {
                return new VehiculoNuevo(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio);
            }
            else
            {
                String []s = this.tbFechaMatriculacion.Text.Split('/');
                DateTime fecha;
                DateTime.TryParse(this.tbFechaMatriculacion.Text, out fecha);
                return new VehiculoSegundaMano(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio, this.tbMatricula.Text,fecha);
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Metodo de respuesta que se da lugar al hacer click en en el boton circular segunda mano, hace que si se hace click en este boton el de nuevo no se seleccione y hace visible las caracteristicas de matricula y fecha matriculacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtSegundaMano_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtSegundaMano.Checked)
            {
                this.rbtNuevo.Checked = false;
            }
            
            this.lMatricula.Visible = true;
            this.lFechaMatriculacion.Visible = true;
            this.tbMatricula.Visible = true;
            this.tbFechaMatriculacion.Visible = true;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Metodo de respuesta que se da lugar al hacer click en en el boton circular nuevo, hace que si se hace click en este boton el de segunda mano no se seleccione y no hace visible las caracteristicas de matricula y fecha matriculacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtNuevo.Checked)
            {
                this.rbtSegundaMano.Checked = false;
            }
            this.lMatricula.Visible = false;
            this.lFechaMatriculacion.Visible = false;
            this.tbMatricula.Visible = false;
            this.tbFechaMatriculacion.Visible = false;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Metodo de respuesta que se da lugar al hacer click en cancelar, libera los recursos que utliza el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Metodo de respuesta que se da lugar al hacer click en aceptar si los formatos no son correcto no deja continuar, si es correcto deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(!formatosCorrectos())
            {
                this.DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve true si todos los campos cumplen el formato y falso en caso contrario y muestra un mensaje de error del primer formato que se ha encontrado erroneo
        /// </summary>
        /// <returns></returns>
        private bool formatosCorrectos()
        { 
            bool v = true;
            String mensaje = "";

            String marca = this.tbMarca.Text;
            if(v && marca.TrimStart(' ').Length==0)
            {
                mensaje = "La marca no puede estar vacia";
                v = false;
            }

            String modelo = this.tbModelo.Text;
            if (v && modelo.TrimStart(' ').Length == 0)
            {
                mensaje = "El modelo no puede estar vacia";
                v = false;
            }

            String potencia = this.tbPotencia.Text;
            if(v && !int.TryParse(potencia, out int potenciaNumero))
            { //Comprobamos que la potencia es un numero entero
                mensaje = "La potencia no es un número";
                v= false;
            }

            String precioRecomendado = this.tbPrecioRecomendado.Text;
            if(v && !double.TryParse(precioRecomendado, out double precioRecomendadoNumero))
            { //Comprobamos que es un numero coon decimales
                mensaje = "El precio no es un número";
                v= false;
            }

            if(v && this.rbtSegundaMano.Checked)
            {// Esta seleccionado que es un v de segunda mano

                String matricula = this.tbMatricula.Text;       //Comprobar el formato de matricula y la fecha de matriculación:
                Regex rg = new Regex("[0-9][0-9][0-9][0-9][A-Z][A-Z][A-Z]");
                if(v && !rg.IsMatch(matricula))
                {
                    mensaje = "Formato de matrícula incorrecto deben de ser 4 numeros segidos de 3 letras mayusculas";
                    v = false;
                }

                String fecha = this.tbFechaMatriculacion.Text;
                
                
                if(v && !DateTime.TryParse(fecha, out DateTime resultado) ){
                    mensaje = "El formato de la fecha es incorrecto";
                    v = false;
                }
                
            }


            if (!v)
            {
                DialogResult dr = MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr.Equals(DialogResult.OK))
                {
                    this.DialogResult = DialogResult.None;

                }
            }

            return v; 
        }
    }
}
