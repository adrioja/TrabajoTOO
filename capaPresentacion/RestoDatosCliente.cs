﻿using System;
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
    public partial class RestoDatosCliente : Form
    {
        private Cliente cliente;
        private OpcionesOperacion opcion;

        public RestoDatosCliente(Cliente c, OpcionesOperacion o)
        {
            this.cliente = c;
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.tbDNI.Text = this.cliente.DNI;
            
            this.opcion = o;

            InitializeComponent();


            if (this.opcion.Equals(OpcionesOperacion.Baja) || this.opcion.Equals(OpcionesOperacion.Busqueda))
            {
                this.asignarDatos();
                this.deshabilitar();
                if (this.opcion.Equals(OpcionesOperacion.Busqueda))
                {
                    this.btCancelar.Visible = false;
                }
            }

            if (opcion.Equals(OpcionesOperacion.Actualizar))
            {
                this.asignarDatos();
                this.tbDNI.Enabled = false;
            }

            if(opcion.Equals(OpcionesOperacion.Alta))
            {
                this.tbDNI.Text = this.cliente.DNI;
                this.tbDNI.Enabled = false;
            }
        }


        public void deshabilitar()
        {
            this.tbDNI.Enabled = false;
            this.tbNombre.Enabled = false;
            this.tbTelefono.Enabled = false;
            
            this.rbA.Enabled = false;
            this.rbB.Enabled = false;
            this.rbC.Enabled = false;
        }

        /// <summary>
        /// Dado el cliente que tenemos, se reyenan todos los textBox del formulario con sus datos
        /// </summary>
        /// <returns></returns>
        public void asignarDatos()
        {
            this.tbDNI.Text = this.cliente.DNI;
            this.tbNombre.Text = this.cliente.Nombre;
            this.tbTelefono.Text = this.cliente.Telefono;

            if(this.cliente.Categoria==CategoriaCliente.A)
            {
                this.rbA.Checked = true;
                this.rbB.Checked = false;
                this.rbC.Checked = false;
            }
            else if(this.cliente.Categoria == CategoriaCliente.B)
            {
                this.rbA.Checked = false;
                this.rbB.Checked = true;
                this.rbC.Checked = false;
            }
            else
            {
                this.rbA.Checked = false;
                this.rbB.Checked = false;
                this.rbC.Checked = true;
            }
        }


        /// <summary>
        /// Devuelve un cliente reyenandolo con los datos que hay en los textBox, sin comprobar que estos sean datos correctos.
        /// </summary>
        /// <returns></returns>
        public Cliente devCliente()
        {           
            CategoriaCliente categoria;

            if (this.rbA.Checked)
            {
                categoria = CategoriaCliente.A;
            }
            else if(this.rbB.Checked)
            {
                categoria = CategoriaCliente.B;
            }
            else
            {
                categoria = CategoriaCliente.C;
            }

            return new Cliente(this.tbDNI.Text, this.tbNombre.Text, this.tbTelefono.Text, categoria);
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {
            //Esto cambiar v
            if (formatosCorrectos())
            {
                if (opcion.Equals(OpcionesOperacion.Alta))
                {
                    this.cliente = this.devCliente();
                }

                if (opcion.Equals(OpcionesOperacion.Baja))
                {
                    DialogResult dr = MessageBox.Show("¿Seguro que quieres eliminar este cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr.Equals(DialogResult.No))
                    {
                        this.DialogResult = DialogResult.None;
                        this.Dispose();
                    }
                }


                if (opcion.Equals(OpcionesOperacion.Actualizar))
                {
                    this.cliente = this.devCliente();
                }

            }
            else
            {
                this.DialogResult = DialogResult.None;
                //PONER MENSAJES DE FORMATOS QUE HAY INCORRECTOS
            }
        }


        private bool formatosCorrectos()
        {
            String dni = this.tbDNI.Text;
            if(dni.Length != 9)
            { //Comprobamos si el tamaño es correcto
                return false;
            }
            if(!long.TryParse(dni, out long dniNumero)) 
            { //Comprobamos si son todo numeros
                return false;
            }


            String telefono = this.tbTelefono.Text;
            if(telefono.Length!=9)
            { //Comprobamos si el tamaño es correcto
                return false;
            }
            if(!long.TryParse(dni, out long telefonoNumero))
            { //Comprobamos si son todo numeros
                return false;
            }

            return true; //Si se cumple todo
        }
    }
}