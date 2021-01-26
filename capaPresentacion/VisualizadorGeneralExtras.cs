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
    /// <summary>
    /// Formulario para visualizar los extras que estan agregados en el sistema y permite filtar por el nombre
    /// </summary>
    public partial class VisualizadorGeneralExtras : Form
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public VisualizadorGeneralExtras()
        {
            InitializeComponent();
            this.lbListaElementos.Enabled = false;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.mostrarTodos();
            
        }

        /// <summary>
        ///  PRE: la clase debe de estar incializada
        /// POST:  Metodo de respuesta que se da lugar al hacer click en el boton limpiar, hace que si se hace click en este boton limpia el filtro del nombre del nombre y muestra todos los extras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            this.tbBuscar.Text = "";
            this.mostrarTodos();
        }


        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: muestra todos los extras disponibles
        /// </summary>
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

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST:  Metodo de respuesta que se da lugar al hacer click en el boton buscar, mustra en la lista los extras que contienen en su nombre lo que contiene el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e2"></param>
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
