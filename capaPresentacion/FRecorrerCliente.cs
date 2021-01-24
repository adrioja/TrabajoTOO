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
    /// Formulario para visualizar todos los clientes y recorrerlos de uno en uno
    /// </summary>
    public partial class FRecorrerCliente : Form
    {
        
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="listaClientes"></param>
        public FRecorrerCliente(List<Cliente> listaClientes)
        {
            
            InitializeComponent();

            
            this.bindingSource.CurrentItemChanged += cambio;
            
            this.bindingNavigator1.BindingSource = this.bindingSource;
            this.bindingSource.DataSource = listaClientes;


            

        }

        /// <summary>
        /// Metodo de respuesta al evento CurrentChanged de BindingSource, actualiza los textBox para mostrar el cliente correspondiente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambio(Object sender, EventArgs e)
        {
            this.tbDNI.Text = ((Cliente)this.bindingSource.Current).DNI;
            this.tbNombre.Text = ((Cliente)this.bindingSource.Current).Nombre;
            this.tbTelefono.Text = ((Cliente)this.bindingSource.Current).Telefono;

            if( ((Cliente)this.bindingSource.Current).Categoria == CategoriaCliente.A   )
            {
                this.rbA.Checked = true;
            }
            else if (((Cliente)this.bindingSource.Current).Categoria == CategoriaCliente.B)
            {
                this.rbB.Checked = true;
            }
            else if (((Cliente)this.bindingSource.Current).Categoria == CategoriaCliente.C)
            {
                this.rbC.Checked = true;
            }
        }
    }
}
