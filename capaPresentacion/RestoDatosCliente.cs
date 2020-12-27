using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNCliente;
using modeloDominio;

namespace capaPresentacion
{
    public partial class RestoDatosCliente : Form
    {
        /*private Cliente cliente;
        private OpcionesOperacion opcion;

        public RestoDatosCliente(Cliente c, OpcionesOperacion o)
        {
            this.cliente = c;
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.lb.Text = vehiculo.NumBastidor;
            
            this.opcion = o;

            InitializeComponent();


            if (this.opcion.Equals(OpcionesOperacion.Baja) || this.opcion.Equals(OpcionesOperacion.Busqueda))
            {
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
                if (this.opcion.Equals(OpcionesOperacion.Busqueda))
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
            this.tbDNI.Enabled = false;
            this.tbNombre.Enabled = false;
            this.tbTelefono.Enabled = false;
            
            this.rbA.Enabled = false;
            this.rbB.Enabled = false;
            this.rbC.Enabled = false;
        }

        public void asignarDatos()
        {
            this.tbDNI.Text = this.cliente.DNI;
            this.tbNombre.Text = this.cliente.Nombre;
            this.tbTelefono.Text = this.cliente.Telefono;

            if(this.cliente.Categoria==CategoriaCliente.A)
            {
                this.rbA.Checked = true;
                this.rbB.Checked = false;
                this.rbC.Checked = false;
            }
            else if(this.cliente.Categoria == CategoriaCliente.B)
            {
                this.rbA.Checked = false;
                this.rbB.Checked = true;
                this.rbC.Checked = false;
            }
            else
            {
                this.rbA.Checked = false;
                this.rbB.Checked = false;
                this.rbC.Checked = true;
            }
        }


        /// <summary>
        /// solo se le puede llamar cuando la clase este incializada y los datos del formulario cumplen el formato
        /// </summary>
        /// <returns></returns>
        public Cliente devCliente()
        {


            ///Esto cambiar v
            int potencia = Int32.Parse(this.tbPotencia.Text);
            double precio = Double.Parse(this.tbPrecioRecomendado.Text);
            if (this.rbtNuevo.Checked)
            {
                return new VehiculoNuevo(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio);
            }
            else
            {
                String[] s = this.tbFechaMatriculacion.Text.Split('/');
                DateTime fecha = new DateTime(Int16.Parse(s[2]), Int16.Parse(s[1]), Int16.Parse(s[0]));
                return new VehiculoSegundaMano(this.tbNumeroBastidor.Text, potencia, this.tbModelo.Text, this.tbMarca.Text, precio, this.tbMatricula.Text, fecha);
            }
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {
            //Esto cambiar v
            if (formatosCorrectos())
            {
                if (opcion.Equals(OpcionesOperacion.Alta))
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
            return 0 == 0; //-----------------------------------------------HACER QUE COMPRUEBE TODOS LOS FORMATOS
        }*/
    }
}
