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
    public partial class ListadoClientes : Form
    {
        private List<Cliente> listaClientes;
        
        public ListadoClientes(List<Cliente> lista)
        {
            this.listaClientes = lista;
            

            InitializeComponent();
            
            this.bs.DataSource = this.listaClientes;

            this.asignarDatos();
        }

        private void asignarDatos()
        {
            lbDNI.DataSource = bs;
            lbDNI.DisplayMember = "DNI";
            lbTelefono.DataSource = bs;
            lbTelefono.DisplayMember = "Telefono";
            lbNombre.DataSource = bs;
            lbNombre.DisplayMember = "Nombre";
        }

        private void btDNI_Click(object sender, EventArgs e)
        {

        
            this.listaClientes= this.listaClientes.OrderBy((Cliente a) => a.DNI).ToList();
            this.bs.DataSource = this.listaClientes;

        }

        private void btNombre_Click(object sender, EventArgs e)
        {
            this.listaClientes = this.listaClientes.OrderBy((Cliente a) => a.Nombre).ToList();
            this.bs.DataSource = this.listaClientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listaClientes = this.listaClientes.OrderBy((Cliente a) => a.Telefono).ToList();
            this.bs.DataSource = this.listaClientes;
        }
        
    }


}
