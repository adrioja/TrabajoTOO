using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNVehiculo;
using modeloDominio;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para introducir la numero de bastidor del vehiculo
    /// </summary>
    public partial class FClaveVehiculo : Form
    {
       /// <summary>
       /// Inicializa la clase
       /// </summary>
        public FClaveVehiculo()
        {         
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en aceptar si el formato del numero de bastidor no es correcto no deja continuar y muestra un mensaje de error, si es correcto deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if ( (this.tbIdentificador.Text.Trim(' ').Length == 0) || (this.tbIdentificador.Text.Length != 17))
            {
                //caso no cumple el formato
                this.DialogResult = DialogResult.None;
                DialogResult dr = MessageBox.Show("El formato del bastidor es incorrecto deben de ser 17 caracteres numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Solo se puede llamar si la clase esta incializada y si el numero de bastidor cumple el formato
        /// Devuelve un objeto vehiculo con la clave iniciada
        /// </summary>
        /// <returns></returns>
        internal Vehiculo devolverVehiculo()
        { //No creo que esté bien del todo:
            Vehiculo ve = new VehiculoNuevo(this.tbIdentificador.Text);
            Vehiculo nuevo = LNVehiculo.LogicaNegocioVehiculo.buscar(ve);
            if (nuevo!=null)
            {
                return ve;
            }
            else
            {
                return new VehiculoSegundaMano(this.tbIdentificador.Text);
            }

        }

    }
}
