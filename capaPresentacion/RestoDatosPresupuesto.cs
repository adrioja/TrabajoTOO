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
    /// Formulario para introducir el restode datos de un presupuesto
    /// </summary>
    public partial class RestoDatosPresupuesto : Form
    {
        private Presupuesto presupuesto;

        /// <summary>
        /// 
        /// </summary>
        public RestoDatosPresupuesto(String id)
        {
            InitializeComponent();
            this.presupuesto = new Presupuesto(id);
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbIdentificador.Text = this.presupuesto.Id;
            this.tbIdentificador.ReadOnly = true;
            this.presupuesto = LNPresupuesto.LogicaNegocioPresupuesto.buscarPresupuesto(this.presupuesto);
            if (this.presupuesto != null)
            {
                this.asignarDatos();
            }
            else
            {
                this.presupuesto = new Presupuesto(id);
            }
        }

        /// <summary>
        /// Inicializa la clase, se debe utlizar cuando se quiera hacer una operacion de baja o de busqueda
        /// </summary>
        /// <param name="c"></param>
        public RestoDatosCliente(Presupuesto p)
        {
            InitializeComponent();
            this.presupuesto = p;
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbIdentificador.Text = this.presupuesto.Id;
            this.tbIdentificador.ReadOnly = true;
            this.asignarDatos();
            this.deshabilitar();
        }
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: pone todos los textbox como deshabilitados
        /// </summary>
        private void deshabilitar()
        {

        }
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: Dado el presupuesto que tenemos, se rellenan todos los textBox del formulario con sus datos
        /// </summary>
        private void asignarDatos()
        {

        }


    }
}