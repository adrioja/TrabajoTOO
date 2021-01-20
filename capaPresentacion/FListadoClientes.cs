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
    /// Formulario para visualizar en forma de tabla los clientes existentes
    /// </summary>
    public partial class FListadoClientes : Form
    {
        /// <summary>
        /// Inicializa la clase e introduce en el listado los clientes existentes
        /// </summary>
        public FListadoClientes()
        {
            InitializeComponent();
            this.Text = "Listado de clientes";
            List<Cliente> lista = LNCliente.LogicaNegocioCliente.ListaClientes();

            foreach (Cliente c in lista)
            {
                string[] vehiculo = {c.DNI,c.Nombre,c.Telefono,c.Categoria.ToString(), c.Descuento.ToString() };
                this.listado.Rows.Add(vehiculo);
            }
        }
    }
}
