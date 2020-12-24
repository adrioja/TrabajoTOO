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
    public partial class AltaExtra : Form
    {
        private Extra extra;

        public AltaExtra(Extra e)
        {
            this.extra = e;
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNombre.Text = extra.Nombre;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            double precio;
            if(!Double.TryParse(this.tbPrecio.Text,out precio))
            {
                MessageBox.Show("Debes introducir una cantidad numerica para el precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.extra.PrecioFijo = precio;
            }
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
