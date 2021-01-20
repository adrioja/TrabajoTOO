using modeloDominio;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para introducir el id del presupuesto
    /// </summary>
    public partial class FClavePresupuesto : Form
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public FClavePresupuesto()
        {
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en aceptar si el formato del id  no es correcto no deja continuar y muestra un mensaje de error, si es correcto deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (!this.comprobarFormato())
            {
                //caso no cumple el formato
                this.DialogResult = DialogResult.None;
                DialogResult dr = MessageBox.Show("El formato del id es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Solo se puede llamar si la clase esta incializada y si el id cumple el formato
        /// Devuelve un objeto presupuesto con el campo clave iniciado
        /// </summary>
        /// <returns></returns>
        internal Presupuesto devolverPresupuesto()
        {
            return new Presupuesto(this.tbIdentificador.Text);
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve true si el id introducido cumple el formato y falso en caso contrario
        /// </summary>
        /// <returns></returns>
        private bool comprobarFormato()
        {
            Regex regex = new Regex("[0-9][0-9][0-9][A-Z][A-Z][A-Z]");

            String id = this.tbIdentificador.Text;
            if (!regex.IsMatch(id))
            { //Comprobamos si el formato es correcto
                return false;
            }

            return true;
        }
    }
}
