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
    public partial class VisualizadorGeneralExtras : Form
    {
        public VisualizadorGeneralExtras()
        {
            InitializeComponent();
            this.lbListaElementos.Enabled = false;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.mostrarTodos();
            
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            this.tbBuscar.Text = "";
            this.mostrarTodos();
        }

        private void mostrarTodos()
        {
            this.lbListaElementos.Items.Clear();
                List<Extra> lista = LNVehiculo.LogicaNegocioVehiculo.listaTodosLosExtras();
                foreach (Extra e in lista)
                {
                    String extra = e.ToString();
                    extra = extra.Replace('[', ' ');
                    extra = extra.Replace(']', ' ');
                    this.lbListaElementos.Items.Add(extra);
                }
        }

        private void btBuscar_Click(object sender, EventArgs e2)
        {
            this.lbListaElementos.Items.Clear();
                List<Extra> lista = LNVehiculo.LogicaNegocioVehiculo.buscarExtras(this.tbBuscar.Text);
                foreach (Extra e in lista)
                {
                    String extra = e.ToString();
                    extra = extra.Replace('[', ' ');
                    extra = extra.Replace(']', ' ');
                    this.lbListaElementos.Items.Add(extra);
                }
            
        }
    }
}
