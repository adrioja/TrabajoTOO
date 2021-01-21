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
    /// <summary>
    /// Formulario para introducir la clave del cliente(DNI)
    /// </summary>
    public partial class FClaveCliente : Form
    {
        /// <summary>
        /// Incializa la clase
        /// </summary>
        public FClaveCliente()
        {
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en aceptar si el formato del DNI  no es correcto no deja continuar y muestra un mensaje de error, si es correcto deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (!this.comprobarFormato())
            {
                //caso no cumple el formato
                this.DialogResult = DialogResult.None;
                DialogResult dr = MessageBox.Show("El formato del dni es incorrecto deben ser 8 numeros y al final una letra mayuscula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
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
        /// Solo se puede llamar si la clase esta incializada y si el DNI cumple el formato
        /// Devuelve un objeto cliente con el campo clave iniciado
        /// </summary>
        /// <returns></returns>
        internal Cliente devolverCliente()
        {
            return new Cliente(this.tbIdentificador.Text);
        }



        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve true si el DNI introducido cumple el formato y falso en caso contrario
        /// </summary>
        /// <returns></returns>
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
