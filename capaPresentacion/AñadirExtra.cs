using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNVehiculo;
using modeloDominio;

namespace capaPresentacion
{
    public partial class AñadirExtra : Form
    {
        public AñadirExtra()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pone todos los cuadros de texto vacios del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            this.tbNombre.Text = "";
            this.tbPrecio.Text = "";
            this.tbExtraAñadira.Text = "";
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            this.tbExtraAñadira.Text = this.tbNombre.Text + "      -        " + this.tbPrecio.Text + " €";
        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {
            this.tbExtraAñadira.Text = this.tbNombre.Text + "      -        " + this.tbPrecio.Text + " €";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            String nombre = this.tbNombre.Text;
            String precioString = this.tbPrecio.Text;
            double precio;
            if(Double.TryParse(precioString, out precio))
            {
                Extra extra = new Extra(nombre, precio);
                if(LNVehiculo.LogicaNegocioVehiculo.añadir(extra))
                {
                    MessageBox.Show("Extra añadido exitosamente");
                }
                else
                {
                    MessageBox.Show("Un extra ya posee dicho nombre pongale otro");
                }
            }
            else
            {
                MessageBox.Show("Introduce en precio una cantidad numerica");
            }

        }
    }
}
