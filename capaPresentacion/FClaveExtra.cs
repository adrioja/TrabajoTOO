using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNVehiculo;
using modeloDominio;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para introducir la nombre del extra
    /// </summary>
    public partial class FClaveExtra : Form
    {

        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public FClaveExtra()
        {
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en aceptar si el formato del nombre no es correcto no deja continuar y muestra un mensaje de error, si es correcto deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (this.tbIdentificador.Text.Trim(' ').Length == 0)
            {
                //caso no cumple el formato
                this.DialogResult = DialogResult.None;
                DialogResult dr = MessageBox.Show("El formato del nombre de un extra no puede ser vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*if(opcion.Equals(OpcionesOperacion.Alta))
            {
                if (LogicaNegocioVehiculo.existeYa(new Extra(this.tbIdentificador.Text)))
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un extra con dicho nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if(opcion.Equals(OpcionesOperacion.Baja))
            {
                if (!LogicaNegocioVehiculo.existeYa(new Extra(this.tbIdentificador.Text)))
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un extra con dicho nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if(opcion.Equals(OpcionesOperacion.Busqueda))
            {
                if (!LogicaNegocioVehiculo.existeYa(new Extra(this.tbIdentificador.Text)))
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un extra con dicho nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            }*/
            
            
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
        /// Solo se puede llamar si la clase esta incializada y si el nombre del extra cumple el formato
        /// Devuelve un objeto extra con el campo clave iniciado
        /// </summary>
        /// <returns></returns>
        internal Extra devolverExtra()
        {
            return new Extra(this.tbIdentificador.Text);
        }

    }
}
