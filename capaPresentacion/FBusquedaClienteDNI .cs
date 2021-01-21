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
    /// Formulario para buscar clientes seleccionando un DNI de los existentes
    /// </summary>
    public partial class FBusquedaClienteDNI : Form
    {
        /// <summary>
        /// Inicializa la clase (añade al textBox los DNIs seleccionables)
        /// </summary>
        public FBusquedaClienteDNI()
        {
            InitializeComponent();
            List<Cliente> lista = LNCliente.LogicaNegocioCliente.ListaClientes();
            foreach (Cliente c in lista)
            {
                this.cbDNIs.Items.Add(c.DNI);
            }
        }

        /// <summary>
        /// Cada vez que cambia el cliente seleccionado.
        /// Este metodo se encarga de visualizar el nuevo cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDNIs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = LNCliente.LogicaNegocioCliente.Buscar(new Cliente(this.cbDNIs.SelectedItem.ToString()));
            this.tbNombre.Text = c.Nombre;
            this.tbTelefono.Text = c.Telefono;
            if (c.Categoria == CategoriaCliente.A)
            {
                this.rbtA.Checked = true;
            }
            else if (c.Categoria == CategoriaCliente.B)
            {
                this.rbtB.Checked = true;
            }
            else
            {
                this.rbtC.Checked = true;
            }
        }

        /// <summary>
        ///Click en cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
