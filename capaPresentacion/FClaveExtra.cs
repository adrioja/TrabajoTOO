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
    public partial class FClaveExtra : Form
    {

        private OpcionesOperacion opcion;

        public FClaveExtra(OpcionesOperacion o)
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
            if(opcion.Equals(OpcionesOperacion.Alta))
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
            }
            
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// Solo se puede llamar si la clase esta incializada y si el nombre introducido no existe ya en el sistema
        /// </summary>
        /// <returns></returns>
        internal Extra devolverExtra()
        {
            return new Extra(this.tbIdentificador.Text);
        }

    }
}
