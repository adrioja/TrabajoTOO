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
    public partial class RestoDatosVehiculo : Form
    {
        private Vehiculo vehiculo;
        private OpcionesOperacion opcion;

        public RestoDatosVehiculo(Vehiculo e, OpcionesOperacion o)
        {
            
            this.vehiculo = e;
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNumeroBastidor.Text = vehiculo.NumBastidor;
            this.rbtNuevo.Checked = true;
            this.opcion = o;

            if(this.opcion.Equals(OpcionesOperacion.Baja) || this.opcion.Equals(OpcionesOperacion.Busqueda))
            {
                this.asignarDatos();
                VehiculoSegundaMano ve = this.vehiculo as VehiculoSegundaMano;
                if (ve==null)
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
                if(this.opcion.Equals(OpcionesOperacion.Busqueda))
                {
                    this.btCancelar.Visible = false;
                }
            }

            if (opcion.Equals(OpcionesOperacion.Actualizar))
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

        }

        public void deshabilitar()
        {
            this.tbNumeroBastidor.Enabled = false;
            this.tbMarca.Enabled = false;
            this.tbModelo.Enabled = false;
            this.tbPotencia.Enabled = false;
            this.tbPrecioRecomendado.Enabled = false;
            this.tbMatricula.Enabled = false;
            this.tbFechaMatriculacion.Enabled = false;
            this.rbtNuevo.Enabled = false;
            this.rbtSegundaMano.Enabled = false;
        }

        public void asignarDatos()
        {
            this.tbNumeroBastidor.Text = this.vehiculo.NumBastidor;
            this.tbMarca.Text = this.vehiculo.Marca;
            this.tbModelo.Text = this.vehiculo.Modelo;
            this.tbPotencia.Text = this.vehiculo.Potencia + "";
            this.tbPrecioRecomendado.Text = this.vehiculo.PvRecomendado + "";
        }

        /// <summary>
        /// solo se le puede llamar cuando la clase este incializada y los datos del formulario cumplen el formato
        /// </summary>
        /// <returns></returns>
        public Vehiculo devVehiculo()
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
                DateTime fecha = new DateTime(Int16.Parse(s[2]), Int16.Parse(s[1]), Int16.Parse(s[0]));
                return new VehiculoSegundaMano(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio, this.tbMatricula.Text,fecha);
            }
        }

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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(formatosCorrectos())
            {
                if (opcion.Equals(OpcionesOperacion.Alta))
                {
                    string num = this.tbNumeroBastidor.Text;
                    int potencia = (int) Double.Parse(this.tbPotencia.Text);
                    double precio = Double.Parse(this.tbPrecioRecomendado.Text);

                    if(this.rbtNuevo.Checked)
                    {
                        this.vehiculo = new VehiculoNuevo(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio);
                    }
                    else
                    {
                        String[] s = this.tbFechaMatriculacion.Text.Split('/');
                        DateTime fecha = new DateTime(Int16.Parse(s[2]), Int16.Parse(s[1]), Int16.Parse(s[0]));
                        this.vehiculo = new VehiculoSegundaMano(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio,this.tbMatricula.Text,fecha);
                    }

                }

                if (opcion.Equals(OpcionesOperacion.Baja))
                {
                    DialogResult dr = MessageBox.Show("¿Seguro que quieres eliminar este vehiculo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr.Equals(DialogResult.No))
                    {
                        this.DialogResult = DialogResult.None;
                        this.Dispose();
                    }
                }


                if (opcion.Equals(OpcionesOperacion.Actualizar))
                {
                    string num = this.tbNumeroBastidor.Text;
                    int potencia = (int)Double.Parse(this.tbPotencia.Text);
                    double precio = Double.Parse(this.tbPrecioRecomendado.Text);

                    if (this.rbtNuevo.Checked)
                    {
                        this.vehiculo = new VehiculoNuevo(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio);
                    }
                    else
                    {
                        String[] s = this.tbFechaMatriculacion.Text.Split('/');
                        DateTime fecha = new DateTime(Int16.Parse(s[2]), Int16.Parse(s[1]), Int16.Parse(s[0]));
                        this.vehiculo = new VehiculoSegundaMano(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio, this.tbMatricula.Text, fecha);
                    }
                }
                
            }
            else
            {
                this.DialogResult = DialogResult.None;
                //PONER MENSAJES DE FORMATOS QUE HAY INCORRECTOS
            }
        }

        private bool formatosCorrectos()
        { 
            bool v = true;
            String mensaje = "";
            
            String potencia = this.tbPotencia.Text;
            if(!int.TryParse(potencia, out int potenciaNumero))
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
                    mensaje = "Formato de matrícula incorrecto";
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

            return v; //si todo está bien
        }
    }
}
