using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            this.opcion = o;
            this.vehiculo = e;
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNumeroBastidor.Text = vehiculo.NumBastidor;
            this.rbtNuevo.Checked = true;
            InitializeComponent();
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
            this.rbtSegundaMano.Checked = false;
            this.lMatricula.Visible = true;
            this.lFechaMatriculacion.Visible = true;
            this.tbMatricula.Visible = true;
            this.tbFechaMatriculacion.Visible = true;
        }

        private void rbtNuevo_CheckedChanged(object sender, EventArgs e)
        {
            this.rbtNuevo.Checked = false;
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

                //-----
            }
            else
            {
                this.DialogResult = DialogResult.None;
                //PONER MENSAJES DE FORMATOS QUE HAY INCORRECTOS
            }
        }

        private bool formatosCorrectos()
        {
            return true; //-----------------------------------------------HACER QUE COMPRUEBE TODOS LOS FORMATOS
        }
    }
}
