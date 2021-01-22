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

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para recoger/introducir el resto de datos de un cliente
    /// </summary>
    public partial class RestoDatosCliente : Form
    {
        private Cliente cliente;

        /// <summary>
        /// Inicializa la clase, se debe utlizar cuando se quiera hacer una operacion de alta o actualizacion
        /// </summary>
        /// <param name="c"></param>
        public RestoDatosCliente(String c)
        {
            InitializeComponent();
            this.cliente = new Cliente(c);
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbDNI.Text = this.cliente.DNI;
            this.tbDNI.ReadOnly = true;

            this.cliente = LNCliente.LogicaNegocioCliente.Buscar(this.cliente);
            if(this.cliente != null)
            {
                this.asignarDatos();
            }
            else
            {
                this.cliente = new Cliente(c);
            }

        }

        /// <summary>
        /// Inicializa la clase, se debe utlizar cuando se quiera hacer una operacion de baja o de busqueda
        /// </summary>
        /// <param name="c"></param>
        public RestoDatosCliente(Cliente c)
        {
            InitializeComponent();
            this.cliente = c;
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbDNI.Text = this.cliente.DNI;
            this.tbDNI.ReadOnly = true;
            this.asignarDatos();
            this.deshabilitar();
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: pone todos los textbox y botones circulares como deshabilitados
        /// </summary>
        private void deshabilitar()
        {
            this.tbDNI.ReadOnly = true;
            this.tbNombre.ReadOnly = true;
            this.tbTelefono.ReadOnly = true;
            
            this.rbA.Enabled = false;
            this.rbB.Enabled = false;
            this.rbC.Enabled = false;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Dado el cliente que tenemos, se reyenar todos los textBox del formulario con sus datos
        /// </summary>
        /// <returns></returns>
        private void asignarDatos()
        {
            this.tbDNI.Text = this.cliente.DNI;
            this.tbNombre.Text = this.cliente.Nombre;
            this.tbTelefono.Text = this.cliente.Telefono;

            if(this.cliente.Categoria==CategoriaCliente.A)
            {
                this.rbA.Checked = true;
                this.rbB.Checked = false;
                this.rbC.Checked = false;
            }
            else if(this.cliente.Categoria == CategoriaCliente.B)
            {
                this.rbA.Checked = false;
                this.rbB.Checked = true;
                this.rbC.Checked = false;
            }
            else
            {
                this.rbA.Checked = false;
                this.rbB.Checked = false;
                this.rbC.Checked = true;
            }
        }


        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Devuelve un cliente reyenandolo con los datos que hay en los textBox, sin comprobar que estos sean datos correctos.
        /// </summary>
        /// <returns></returns>
        internal Cliente devCliente()
        {           
            CategoriaCliente categoria;

            if (this.rbA.Checked)
            {
                categoria = CategoriaCliente.A;
            }
            else if(this.rbB.Checked)
            {
                categoria = CategoriaCliente.B;
            }
            else
            {
                categoria = CategoriaCliente.C;
            }

            return new Cliente(this.tbDNI.Text, this.tbNombre.Text, this.tbTelefono.Text, categoria);
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en cancelar, libera los recursos que utliza el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en aceptar si los formatos no son correcto no deja continuar, si es correcto deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(!this.formatosCorrectos())
            {
                this.DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve true si todos los campos cumplen el formato y falso en caso contrario y muestra un mensaje de error del primer formato que se ha encontrado erroneo
        /// </summary>
        /// <returns></returns>
        private bool formatosCorrectos()
        {
            String mensaje ="";
            bool v = true;

            
            if(v && String.IsNullOrEmpty(this.tbNombre.Text.TrimStart(' ') ))
            {
                mensaje = "El nombre está vacio";
                v = false;
            }

            String telefono = this.tbTelefono.Text;
            if(v && telefono.Length!=9)
            { //Comprobamos si el tamaño es correcto
                mensaje = "El formato del telefono es incorrecto";
                v = false;
            }
            if(v && !long.TryParse(telefono, out long telefonoNumero))
            { //Comprobamos si son todo numeros
                mensaje = "El formato del telefono es incorrecto";
                v = false;
            }


            if (!v) {
                DialogResult dr = MessageBox.Show( mensaje , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr.Equals(DialogResult.OK))
                {
                    this.DialogResult = DialogResult.None;
                    
                }
            }
            return v; 
        }
    }
}
