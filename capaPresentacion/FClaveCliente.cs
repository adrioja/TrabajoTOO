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
        public FClaveCliente()
        {    
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
            if (this.tbIdentificador.Text.Trim(' ').Length == 0  || !this.comprobarFormato())
            {
                //caso no cumple el formato
                this.DialogResult = DialogResult.None;
                DialogResult dr = MessageBox.Show("El formato del dni es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// Solo se puede llamar si la clase esta incializada y si el dni introducido no existe ya en el sistema.
        /// Devuelve un objeto cliente con el campo clave iniciado
        /// </summary>
        /// <returns></returns>
        internal Cliente devolverCliente()
        {
            return new Cliente(this.tbIdentificador.Text);
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
