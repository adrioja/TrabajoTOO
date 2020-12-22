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
    public partial class FClave : Form
    {

        public FClave(String nombreClave)
        {
            InitializeComponent();
            this.lbDescripcion.Text += nombreClave;
            this.lIdentificador.Text = nombreClave;
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(LogicaNegocioVehiculo.existeYa(new Extra(this.tbIdentificador.Text)))
            {
                DialogResult dr=  MessageBox.Show("¿Quieres introducir otro?", "Ya existe uno con dicha clave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr.Equals(DialogResult.No))
                {
                    this.Dispose();
                }
                else
                {

                }
            }
            else
            {
                AltaExtra alta = new AltaExtra();
                DialogResult dr = alta.ShowDialog();
                
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
