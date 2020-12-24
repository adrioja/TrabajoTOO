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

            FClaveExtra f = new FClaveExtra(Opciones.Alta);
            DialogResult dr = f.ShowDialog();
            if(dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
            {
                RestoDatosExtra alta = new RestoDatosExtra(f.devolverExtra(),Opciones.Alta);
                DialogResult drAlta = alta.ShowDialog();
                if(drAlta.Equals(DialogResult.OK))
                {
                    Extra extra = alta.devExtra();
                    LNVehiculo.LogicaNegocioVehiculo.añadir(extra);
                    MessageBox.Show("El extra se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            FClaveExtra f = new FClaveExtra(Opciones.Baja);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosExtra baja = new RestoDatosExtra(LNVehiculo.LogicaNegocioVehiculo.buscar(f.devolverExtra()), Opciones.Baja);
                DialogResult drBaja = baja.ShowDialog();
                if (drBaja.Equals(DialogResult.OK))
                {
                    LNVehiculo.LogicaNegocioVehiculo.eliminar(baja.devExtra());
                    MessageBox.Show("El extra se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    baja.Dispose();
                }
            }
        }

        private void buscarUnExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClaveExtra f = new FClaveExtra(Opciones.Busqueda);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosExtra busqueda = new RestoDatosExtra(LNVehiculo.LogicaNegocioVehiculo.buscar(f.devolverExtra()), Opciones.Busqueda);
                DialogResult drBusqueda = busqueda.ShowDialog();
                busqueda.Dispose();
            }
        }
    }
}
