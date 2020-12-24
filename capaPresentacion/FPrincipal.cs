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
using capaPresentacion;

namespace capaPresentacion
{
    public partial class FPrincipal : Form
    {
        public FPrincipal(FLogearse log,String usuario)
        {
            log.Hide();
            InitializeComponent();
            this.IsMdiContainer = true;
            this.tsslUsuarioSesion.Text = usuario;
            this.tsslFechaActual.Text = DateTime.Now.ToLongDateString();
            
        }

        private void añadirNuevoExtraDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FClaveExtra f = new FClaveExtra();
            DialogResult dr = f.ShowDialog();
            if(dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
            {
                AltaExtra alta = new AltaExtra(f.devolverExtra());
                DialogResult drAlta = alta.ShowDialog();
                if(drAlta.Equals(DialogResult.OK))
                {
                    Extra extra = alta.devExtra();
                    LNVehiculo.LogicaNegocioVehiculo.añadir(extra);
                }
                else
                {
                    alta.Dispose();
                }
            }
            else
            {
                f.Dispose();
            }
        }

        private void eliminarExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClaveExtra f = new FClaveExtra();
            DialogResult dr = f.ShowDialog();
        }
    }
}
