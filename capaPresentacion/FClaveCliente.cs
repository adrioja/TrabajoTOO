using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNCliente;
using modeloDominio;
using System.Text.RegularExpressions;

namespace capaPresentacion
{
    public partial class FClaveCliente : Form
    {
        private OpcionesOperacion opcion;

        public FClaveCliente(OpcionesOperacion o)
        {
            this.opcion = o;
            this.inicializarComponentes();
        }

        private void inicializarComponentes()
        {
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {
          
                if (opcion.Equals(OpcionesOperacion.Alta))
                {
                if (comprobarFormato())
                {
                    if (LogicaNegocioCliente.Existe(new Cliente(this.tbIdentificador.Text)))
                    {
                        DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un cliente con dicho DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr.Equals(DialogResult.No))
                        {
                            this.Dispose();
                        }
                        else
                        {
                            this.tbIdentificador.Text = "";
                        }
                        this.DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "Error en el formato", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr.Equals(DialogResult.No))
                    {
                        this.Dispose();
                    }
                    else
                    {
                        this.tbIdentificador.Text = "";
                    }
                    this.DialogResult = DialogResult.None;
                }
                }
                if (opcion.Equals(OpcionesOperacion.Baja))
                {
                    if (!LogicaNegocioCliente.Existe(new Cliente(this.tbIdentificador.Text)))
                    {
                        DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con dicho DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr.Equals(DialogResult.No))
                        {
                            this.Dispose();
                        }
                        else
                        {
                            this.tbIdentificador.Text = "";
                        }
                        this.DialogResult = DialogResult.None;
                    }
                }
                if (opcion.Equals(OpcionesOperacion.Busqueda))
                {
                    if (!LogicaNegocioCliente.Existe(new Cliente(this.tbIdentificador.Text)))
                    {
                        DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con dicho DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr.Equals(DialogResult.No))
                        {
                            this.Dispose();
                        }
                        else
                        {
                            this.tbIdentificador.Text = "";
                        }
                        this.DialogResult = DialogResult.None;
                    }
                }
         


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// Solo se puede llamar si la clase esta incializada y si el dni introducido no existe ya en el sistema
        /// </summary>
        /// <returns></returns>
        internal Cliente devolverCliente()
        {
            Cliente c = new Cliente(this.tbIdentificador.Text);
            Cliente nuevo = LNCliente.LogicaNegocioCliente.Buscar(c);
            if (nuevo != null)
            {
                return nuevo;
            }
            else
            {
                return c;
            }
        }

        


        private bool comprobarFormato()
        {
            Regex regex = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]");
            
            String dni = this.tbIdentificador.Text;
            if (!regex.IsMatch(dni))
            { //Comprobamos si el tamaño es correcto
                return false;
            }
           
            return true;
        }

    }

}
