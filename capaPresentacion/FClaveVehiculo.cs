﻿using System;
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
    public partial class FClaveVehiculo : Form
    {
       
        public FClaveVehiculo()
        {         
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if ( (this.tbIdentificador.Text.Trim(' ').Length == 0) || (this.tbIdentificador.Text.Length != 17))
            {
                //caso no cumple el formato
                this.DialogResult = DialogResult.None;
                DialogResult dr = MessageBox.Show("El formato del bastidor es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            if (opcion.Equals(OpcionesOperacion.Alta))
            {
                if (comprobarFormato())
                {
                    if (LogicaNegocioVehiculo.existeYa(new VehiculoNuevo(this.tbIdentificador.Text)))
                    {
                        DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un vehiculo con dicho numero de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                else
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "Error en el formato", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
                if (!LogicaNegocioVehiculo.existeYa(new VehiculoNuevo(this.tbIdentificador.Text)))
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un vehiculo con dicho nnumero de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (!LogicaNegocioVehiculo.existeYa(new VehiculoNuevo(this.tbIdentificador.Text)))
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un vehiculo con dicho numero de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Solo se puede llamar si la clase esta incializada y si el nombre introducido no existe ya en el sistema
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
