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
    public partial class RestoDatosExtra : Form
    {
        private Extra extra;

        public RestoDatosExtra(String s)
        {
            //para el caso de dar alta y actualizar
            InitializeComponent();
            this.extra = new Extra(s);
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNombre.Text = extra.Nombre;
            this.extra = LNVehiculo.LogicaNegocioVehiculo.buscar(this.extra);
            if (extra!=null) //caso actualizar
            {
                this.tbPrecio.Text = this.extra.PrecioFijo + "";
            }
            else
            {
                this.extra = new Extra(s);
            }
        }

        public RestoDatosExtra(Extra e)
        {
            // para eliminar y buscar
            InitializeComponent();
            this.extra = e;
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNombre.Text = extra.Nombre;
            this.tbNombre.Enabled = false;
            this.tbPrecio.Enabled = false;
            this.tbPrecio.Text = this.extra.PrecioFijo + "";

            //en la busqueda hay que deshabilitar el boton cancelar                 //-------------------------FALTA
        }



        private void btAceptar_Click(object sender, EventArgs e)
        {
            double precio;
            if (!Double.TryParse(this.tbPrecio.Text, out precio))
            {
                MessageBox.Show("Debes introducir una cantidad numerica para el precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.extra.PrecioFijo = precio;
            }


            /*if(opcion.Equals(OpcionesOperacion.Alta))
            {
                double precio;
                if (!Double.TryParse(this.tbPrecio.Text, out precio))
                {
                    MessageBox.Show("Debes introducir una cantidad numerica para el precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    this.extra.PrecioFijo = precio;
                }
            }
            if (opcion.Equals(OpcionesOperacion.Baja))
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quieres eliminar este extra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr.Equals(DialogResult.No))
                {
                    this.DialogResult = DialogResult.None;
                    this.Dispose();
                }
            }
            if(opcion.Equals(OpcionesOperacion.Actualizar))
            {
                double precio;
                if (!Double.TryParse(this.tbPrecio.Text, out precio))
                {
                    MessageBox.Show("Debes introducir una cantidad numerica para el precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    this.extra.PrecioFijo = precio;
                }
            }*/


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// solo se le puede llamar cuando la clase este incializada y los datos del formulario cumplen el formato
        /// </summary>
        /// <returns></returns>
        public Extra devExtra()
        {
            return this.extra;
        }
    }
}
