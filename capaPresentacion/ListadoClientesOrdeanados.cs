using modeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para visualizar todos los clientes en un orden
    /// </summary>
    public partial class ListadoClientesOrdeanados : Form
    {
        private List<Cliente> listaClientes;


        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="lista"></param>
        public ListadoClientesOrdeanados(List<Cliente> lista)
        {
            this.listaClientes = lista;
            

            InitializeComponent();
            
            this.bs.DataSource = this.listaClientes;

            lbDNI.DataSource = bs;
            lbDNI.DisplayMember = "DNI";
            lbTelefono.DataSource = bs;
            lbTelefono.DisplayMember = "Telefono";
            lbNombre.DataSource = bs;
            lbNombre.DisplayMember = "Nombre";
        }

        /// <summary>
        /// Click en DNI, se ordenan teniendo el cuenta el DNI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDNI_Click(object sender, EventArgs e)
        {
            this.listaClientes= this.listaClientes.OrderBy((Cliente a) => a.DNI).ToList();
            this.bs.DataSource = this.listaClientes;
        }

        /// <summary>
        /// Click en Nombre, se ordenan teniendo el cuenta el Nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNombre_Click(object sender, EventArgs e)
        {
            this.listaClientes = this.listaClientes.OrderBy((Cliente a) => a.Nombre).ToList();
            this.bs.DataSource = this.listaClientes;
        }

        /// <summary>
        /// Click en Telefono, se ordenan teniendo el cuenta el Telefono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.listaClientes = this.listaClientes.OrderBy((Cliente a) => a.Telefono).ToList();
            this.bs.DataSource = this.listaClientes;
        }

        /// <summary>
        /// Click en Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }


}
