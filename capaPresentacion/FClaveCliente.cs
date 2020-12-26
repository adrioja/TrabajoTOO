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
    public partial class FClaveCliente : Form
    {
        private OpcionesOperacion opcion;

        public FClaveCliente(OpcionesOperacion o)
        {
            this.opcion = o;
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
            return new Cliente(this.tbIdentificador.Text);
        }


    }

}
