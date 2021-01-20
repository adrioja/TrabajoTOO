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

            lbDNI.DataSource = bs;
            lbDNI.DisplayMember = "DNI";
            lbTelefono.DataSource = bs;
            lbTelefono.DisplayMember = "Telefono";
            lbNombre.DataSource = bs;
            lbNombre.DisplayMember = "Nombre";
        }

        private void btDNI_Click(object sender, EventArgs e)
        {
            this.listaClientes.Sort(new Comparison<Cliente>((Cliente a, Cliente b) => { return (b.DNI.CompareTo(a.DNI)); }));

            
            lbDNI.Refresh();
            lbNombre.Refresh();
            lbTelefono.Refresh();
        }

        private void btNombre_Click(object sender, EventArgs e)
        {
            this.listaClientes.Sort(new Comparison<Cliente>((Cliente a, Cliente b) => { return (a.Nombre.CompareTo(b.Nombre)); }));

            
            lbDNI.Refresh();
            lbNombre.Refresh();
            lbTelefono.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listaClientes.Sort(new Comparison<Cliente>((Cliente a, Cliente b) => { return (a.Telefono.CompareTo(b.Telefono)); }));

          
            lbDNI.Refresh();
            lbNombre.Refresh();
            lbTelefono.Refresh();
        }
        
    }


}
