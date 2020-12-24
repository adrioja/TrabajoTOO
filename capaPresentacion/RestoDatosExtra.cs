﻿using System;
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
    public partial class RestoDatosExtra : Form
    {
        private Extra extra;
        private OpcionesOperacion opcion;

        public RestoDatosExtra(Extra e,OpcionesOperacion o)
        {
            this.opcion = o;
            this.extra = e;
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbNombre.Text = extra.Nombre;
            if (opcion.Equals(OpcionesOperacion.Baja) ||opcion.Equals(OpcionesOperacion.Busqueda))
            {
                this.tbNombre.Enabled = false;
                this.tbPrecio.Enabled = false;
                this.tbPrecio.Text = this.extra.PrecioFijo+"";
                if(opcion.Equals(OpcionesOperacion.Busqueda))
                {
                    this.btCancelar.Visible = false;
                }
            }
            if(opcion.Equals(OpcionesOperacion.Actualizar))
            {
                this.tbPrecio.Text = this.extra.PrecioFijo + "";
            }
            
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(opcion.Equals(OpcionesOperacion.Alta))
            {
                double precio;
                if (!Double.TryParse(this.tbPrecio.Text, out precio))
                {
                    MessageBox.Show("Debes introducir una cantidad numerica para el precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    this.extra.PrecioFijo = precio;
                }
            }
            if (opcion.Equals(OpcionesOperacion.Baja))
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quieres eliminar este extra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr.Equals(DialogResult.No))
                {
                    this.DialogResult = DialogResult.None;
                    this.Dispose();
                }
            }
            if(opcion.Equals(OpcionesOperacion.Actualizar))
            {
                double precio;
                if (!Double.TryParse(this.tbPrecio.Text, out precio))
                {
                    MessageBox.Show("Debes introducir una cantidad numerica para el precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    this.extra.PrecioFijo = precio;
                }
            }


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// solo se le puede llamar cuando la clase este incializada y los datos del formulario cumplen el formato
        /// </summary>
        /// <returns></returns>
        public Extra devExtra()
        {
            return this.extra;
        }
    }
}
