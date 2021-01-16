using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modeloDominio;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para recoger/introducir el resto de datos de un extra
    /// </summary>
    public partial class RestoDatosExtra : Form
    {
        private Extra extra;

        /// <summary>
        /// Inicializa la clase, se debe utlizar cuando se quiera hacer una operacion de alta o actualizacion
        /// </summary>
        /// <param name="s"></param>
        public RestoDatosExtra(String s)
        {
            //para el caso de dar alta y actualizar
            InitializeComponent();
            this.extra = new Extra(s);
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNombre.Text = extra.Nombre;
            this.extra = LNVehiculo.LogicaNegocioVehiculo.buscar(this.extra);
            if (extra!=null) //caso actualizar
            {
                this.tbPrecio.Text = this.extra.PrecioFijo + "";
            }
            else
            {
                this.extra = new Extra(s);
            }
        }

        /// <summary>
        /// Inicializa la clase, se debe utlizar cuando se quiera hacer una operacion de baja o de busqueda
        /// </summary>
        /// <param name="e"></param>
        public RestoDatosExtra(Extra e)
        {
            // para eliminar y buscar
            InitializeComponent();
            this.extra = e;
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNombre.Text = extra.Nombre;
            this.tbNombre.Enabled = false;
            this.tbPrecio.Enabled = false;
            this.tbPrecio.Text = this.extra.PrecioFijo + "";
        }


        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en aceptar si los formatos no son correcto no deja continuar, si es correcto  asigna el precio al extra y deja continuar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            double precio;
            if (!Double.TryParse(this.tbPrecio.Text, out precio))
            {
                MessageBox.Show("Debes introducir una cantidad numerica para el precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.extra.PrecioFijo = precio;
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
        /// PRE: la clase debe de estar incializada
        /// POST: solo se le puede llamar cuando la clase este incializada,sin comprobar que los datos cumplen el formarmato
        /// </summary>
        /// <returns></returns>
        internal Extra devExtra()
        {
            this.reyenarDatos(); 
            return this.extra;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: construye el objeto a partir de los datos de los textbox
        /// </summary>
        private void reyenarDatos()
        { 
            double.TryParse(this.tbPrecio.Text, out double precio);
            this.extra.PrecioFijo = precio;           
        }
    }
}
