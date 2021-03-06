﻿
namespace capaPresentacion
{
    partial class FPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirUnVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUnVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaDatosVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarLosVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLosVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorrerVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirNuevoExtraDisponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUnExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActualizarExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirNuevoClienteDisponibleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUnClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorrerClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDatosClientePorDNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesOrdenadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUnPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorrerPresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBarraEstado = new System.Windows.Forms.StatusStrip();
            this.tsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuarioSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.listarPresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.ssBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVehiculo,
            this.tsmiExtra,
            this.tsmiCliente,
            this.tsmiPresupuesto});
            this.msPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(800, 23);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmiVehiculo
            // 
            this.tsmiVehiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirUnVehiculoToolStripMenuItem,
            this.eliminarUnVehiculoToolStripMenuItem,
            this.buscarVehiculosToolStripMenuItem,
            this.actualizaDatosVehiculoToolStripMenuItem,
            this.visualizarLosVehiculosToolStripMenuItem,
            this.listadoDeLosVehiculosToolStripMenuItem,
            this.recorrerVehiculosToolStripMenuItem});
            this.tsmiVehiculo.Name = "tsmiVehiculo";
            this.tsmiVehiculo.Size = new System.Drawing.Size(64, 19);
            this.tsmiVehiculo.Text = "Vehiculo";
            // 
            // añadirUnVehiculoToolStripMenuItem
            // 
            this.añadirUnVehiculoToolStripMenuItem.Name = "añadirUnVehiculoToolStripMenuItem";
            this.añadirUnVehiculoToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.añadirUnVehiculoToolStripMenuItem.Text = "Añadir un vehiculo";
            this.añadirUnVehiculoToolStripMenuItem.Click += new System.EventHandler(this.añadirUnVehiculoToolStripMenuItem_Click);
            // 
            // eliminarUnVehiculoToolStripMenuItem
            // 
            this.eliminarUnVehiculoToolStripMenuItem.Name = "eliminarUnVehiculoToolStripMenuItem";
            this.eliminarUnVehiculoToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.eliminarUnVehiculoToolStripMenuItem.Text = "Eliminar un vehiculo";
            this.eliminarUnVehiculoToolStripMenuItem.Click += new System.EventHandler(this.eliminarUnVehiculoToolStripMenuItem_Click);
            // 
            // buscarVehiculosToolStripMenuItem
            // 
            this.buscarVehiculosToolStripMenuItem.Name = "buscarVehiculosToolStripMenuItem";
            this.buscarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.buscarVehiculosToolStripMenuItem.Text = "Buscar vehiculos";
            this.buscarVehiculosToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // actualizaDatosVehiculoToolStripMenuItem
            // 
            this.actualizaDatosVehiculoToolStripMenuItem.Name = "actualizaDatosVehiculoToolStripMenuItem";
            this.actualizaDatosVehiculoToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.actualizaDatosVehiculoToolStripMenuItem.Text = "Actualizar datos vehiculo";
            this.actualizaDatosVehiculoToolStripMenuItem.Click += new System.EventHandler(this.actualizaDatosVehiculoToolStripMenuItem_Click);
            // 
            // visualizarLosVehiculosToolStripMenuItem
            // 
            this.visualizarLosVehiculosToolStripMenuItem.Name = "visualizarLosVehiculosToolStripMenuItem";
            this.visualizarLosVehiculosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.visualizarLosVehiculosToolStripMenuItem.Text = "Visualizar los vehiculos por filtros";
            this.visualizarLosVehiculosToolStripMenuItem.Click += new System.EventHandler(this.visualizarLosVehiculosToolStripMenuItem_Click);
            // 
            // listadoDeLosVehiculosToolStripMenuItem
            // 
            this.listadoDeLosVehiculosToolStripMenuItem.Name = "listadoDeLosVehiculosToolStripMenuItem";
            this.listadoDeLosVehiculosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.listadoDeLosVehiculosToolStripMenuItem.Text = "Listado de los vehiculos";
            this.listadoDeLosVehiculosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeLosVehiculosToolStripMenuItem_Click);
            // 
            // recorrerVehiculosToolStripMenuItem
            // 
            this.recorrerVehiculosToolStripMenuItem.Name = "recorrerVehiculosToolStripMenuItem";
            this.recorrerVehiculosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.recorrerVehiculosToolStripMenuItem.Text = "Recorrer vehiculos";
            this.recorrerVehiculosToolStripMenuItem.Click += new System.EventHandler(this.recorrerVehiculosToolStripMenuItem_Click);
            // 
            // tsmiExtra
            // 
            this.tsmiExtra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirNuevoExtraDisponibleToolStripMenuItem,
            this.eliminarExtraToolStripMenuItem,
            this.buscarUnExtraToolStripMenuItem,
            this.tsmiActualizarExtra,
            this.visualizarToolStripMenuItem});
            this.tsmiExtra.Name = "tsmiExtra";
            this.tsmiExtra.Size = new System.Drawing.Size(50, 19);
            this.tsmiExtra.Text = "Extras";
            // 
            // añadirNuevoExtraDisponibleToolStripMenuItem
            // 
            this.añadirNuevoExtraDisponibleToolStripMenuItem.Name = "añadirNuevoExtraDisponibleToolStripMenuItem";
            this.añadirNuevoExtraDisponibleToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.añadirNuevoExtraDisponibleToolStripMenuItem.Text = "Añadir nuevo extra disponible";
            this.añadirNuevoExtraDisponibleToolStripMenuItem.Click += new System.EventHandler(this.añadirNuevoExtraDisponibleToolStripMenuItem_Click);
            // 
            // eliminarExtraToolStripMenuItem
            // 
            this.eliminarExtraToolStripMenuItem.Name = "eliminarExtraToolStripMenuItem";
            this.eliminarExtraToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.eliminarExtraToolStripMenuItem.Text = "Eliminar extra";
            this.eliminarExtraToolStripMenuItem.Click += new System.EventHandler(this.eliminarExtraToolStripMenuItem_Click);
            // 
            // buscarUnExtraToolStripMenuItem
            // 
            this.buscarUnExtraToolStripMenuItem.Name = "buscarUnExtraToolStripMenuItem";
            this.buscarUnExtraToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.buscarUnExtraToolStripMenuItem.Text = "Buscar un extra";
            this.buscarUnExtraToolStripMenuItem.Click += new System.EventHandler(this.buscarUnExtraToolStripMenuItem_Click);
            // 
            // tsmiActualizarExtra
            // 
            this.tsmiActualizarExtra.Name = "tsmiActualizarExtra";
            this.tsmiActualizarExtra.Size = new System.Drawing.Size(232, 22);
            this.tsmiActualizarExtra.Text = "Actualizar un extra";
            this.tsmiActualizarExtra.Click += new System.EventHandler(this.tsmiActualizarExtra_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // tsmiCliente
            // 
            this.tsmiCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirNuevoClienteDisponibleToolStripMenuItem1,
            this.eliminarClienteToolStripMenuItem1,
            this.buscarUnClienteToolStripMenuItem1,
            this.actualizarUnClienteToolStripMenuItem,
            this.recorrerClientesToolStripMenuItem,
            this.busquedaDatosClientePorDNIToolStripMenuItem,
            this.listadoClientesToolStripMenuItem,
            this.listarClientesOrdenadosToolStripMenuItem});
            this.tsmiCliente.Name = "tsmiCliente";
            this.tsmiCliente.Size = new System.Drawing.Size(56, 19);
            this.tsmiCliente.Text = "Cliente";
            // 
            // añadirNuevoClienteDisponibleToolStripMenuItem1
            // 
            this.añadirNuevoClienteDisponibleToolStripMenuItem1.Name = "añadirNuevoClienteDisponibleToolStripMenuItem1";
            this.añadirNuevoClienteDisponibleToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
            this.añadirNuevoClienteDisponibleToolStripMenuItem1.Text = "Añadir nuevo cliente disponible";
            this.añadirNuevoClienteDisponibleToolStripMenuItem1.Click += new System.EventHandler(this.añadirNuevoClienteDisponibleToolStripMenuItem1_Click);
            // 
            // eliminarClienteToolStripMenuItem1
            // 
            this.eliminarClienteToolStripMenuItem1.Name = "eliminarClienteToolStripMenuItem1";
            this.eliminarClienteToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
            this.eliminarClienteToolStripMenuItem1.Text = "Eliminar cliente";
            this.eliminarClienteToolStripMenuItem1.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem1_Click);
            // 
            // buscarUnClienteToolStripMenuItem1
            // 
            this.buscarUnClienteToolStripMenuItem1.Name = "buscarUnClienteToolStripMenuItem1";
            this.buscarUnClienteToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
            this.buscarUnClienteToolStripMenuItem1.Text = "Buscar un cliente";
            this.buscarUnClienteToolStripMenuItem1.Click += new System.EventHandler(this.buscarUnClienteToolStripMenuItem1_Click);
            // 
            // actualizarUnClienteToolStripMenuItem
            // 
            this.actualizarUnClienteToolStripMenuItem.Name = "actualizarUnClienteToolStripMenuItem";
            this.actualizarUnClienteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.actualizarUnClienteToolStripMenuItem.Text = "Actualizar un cliente";
            this.actualizarUnClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarUnClienteToolStripMenuItem_Click);
            // 
            // recorrerClientesToolStripMenuItem
            // 
            this.recorrerClientesToolStripMenuItem.Name = "recorrerClientesToolStripMenuItem";
            this.recorrerClientesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.recorrerClientesToolStripMenuItem.Text = "Recorrer clientes";
            this.recorrerClientesToolStripMenuItem.Click += new System.EventHandler(this.recorrerClientesToolStripMenuItem_Click);
            // 
            // busquedaDatosClientePorDNIToolStripMenuItem
            // 
            this.busquedaDatosClientePorDNIToolStripMenuItem.Name = "busquedaDatosClientePorDNIToolStripMenuItem";
            this.busquedaDatosClientePorDNIToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.busquedaDatosClientePorDNIToolStripMenuItem.Text = "Busqueda datos cliente por DNI";
            this.busquedaDatosClientePorDNIToolStripMenuItem.Click += new System.EventHandler(this.busquedaDatosClientePorDNIToolStripMenuItem_Click);
            // 
            // listadoClientesToolStripMenuItem
            // 
            this.listadoClientesToolStripMenuItem.Name = "listadoClientesToolStripMenuItem";
            this.listadoClientesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.listadoClientesToolStripMenuItem.Text = "Listar clientes";
            this.listadoClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoClientesToolStripMenuItem_Click);
            // 
            // listarClientesOrdenadosToolStripMenuItem
            // 
            this.listarClientesOrdenadosToolStripMenuItem.Name = "listarClientesOrdenadosToolStripMenuItem";
            this.listarClientesOrdenadosToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.listarClientesOrdenadosToolStripMenuItem.Text = "Listar clientes ordenados";
            this.listarClientesOrdenadosToolStripMenuItem.Click += new System.EventHandler(this.listarClientesOrdenadosToolStripMenuItem_Click);
            // 
            // tsmiPresupuesto
            // 
            this.tsmiPresupuesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPresupuestoToolStripMenuItem,
            this.eliminarPresupuestoToolStripMenuItem,
            this.buscarUnPresupuestoToolStripMenuItem,
            this.recorrerPresupuestosToolStripMenuItem,
            this.listarPresupuestosToolStripMenuItem});
            this.tsmiPresupuesto.Name = "tsmiPresupuesto";
            this.tsmiPresupuesto.Size = new System.Drawing.Size(84, 19);
            this.tsmiPresupuesto.Text = "Presupuesto";
            // 
            // añadirPresupuestoToolStripMenuItem
            // 
            this.añadirPresupuestoToolStripMenuItem.Name = "añadirPresupuestoToolStripMenuItem";
            this.añadirPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.añadirPresupuestoToolStripMenuItem.Text = "Añadir presupuesto";
            this.añadirPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.añadirPresupuestoToolStripMenuItem_Click);
            // 
            // eliminarPresupuestoToolStripMenuItem
            // 
            this.eliminarPresupuestoToolStripMenuItem.Name = "eliminarPresupuestoToolStripMenuItem";
            this.eliminarPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eliminarPresupuestoToolStripMenuItem.Text = "Eliminar presupuesto";
            this.eliminarPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.eliminarPresupuestoToolStripMenuItem_Click);
            // 
            // buscarUnPresupuestoToolStripMenuItem
            // 
            this.buscarUnPresupuestoToolStripMenuItem.Name = "buscarUnPresupuestoToolStripMenuItem";
            this.buscarUnPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.buscarUnPresupuestoToolStripMenuItem.Text = "Buscar un presupuesto";
            this.buscarUnPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.buscarUnPresupuestoToolStripMenuItem_Click);
            // 
            // recorrerPresupuestosToolStripMenuItem
            // 
            this.recorrerPresupuestosToolStripMenuItem.Name = "recorrerPresupuestosToolStripMenuItem";
            this.recorrerPresupuestosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recorrerPresupuestosToolStripMenuItem.Text = "Recorrer presupuestos";
            this.recorrerPresupuestosToolStripMenuItem.Click += new System.EventHandler(this.recorrerPresupuestosToolStripMenuItem_Click);
            // 
            // ssBarraEstado
            // 
            this.ssBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFecha,
            this.tsslFechaActual,
            this.tsslUsuario,
            this.tsslUsuarioSesion});
            this.ssBarraEstado.Location = new System.Drawing.Point(0, 373);
            this.ssBarraEstado.Name = "ssBarraEstado";
            this.ssBarraEstado.Size = new System.Drawing.Size(800, 22);
            this.ssBarraEstado.TabIndex = 4;
            this.ssBarraEstado.Text = "statusStrip1";
            // 
            // tsslFecha
            // 
            this.tsslFecha.Name = "tsslFecha";
            this.tsslFecha.Size = new System.Drawing.Size(196, 17);
            this.tsslFecha.Spring = true;
            this.tsslFecha.Text = "Fecha:";
            this.tsslFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslFechaActual
            // 
            this.tsslFechaActual.Name = "tsslFechaActual";
            this.tsslFechaActual.Size = new System.Drawing.Size(196, 17);
            this.tsslFechaActual.Spring = true;
            this.tsslFechaActual.Text = "FechaActual";
            this.tsslFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(196, 17);
            this.tsslUsuario.Spring = true;
            this.tsslUsuario.Text = "Usuario:";
            this.tsslUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslUsuarioSesion
            // 
            this.tsslUsuarioSesion.Name = "tsslUsuarioSesion";
            this.tsslUsuarioSesion.Size = new System.Drawing.Size(196, 17);
            this.tsslUsuarioSesion.Spring = true;
            this.tsslUsuarioSesion.Text = "UsuarioSesion";
            this.tsslUsuarioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listarPresupuestosToolStripMenuItem
            // 
            this.listarPresupuestosToolStripMenuItem.Name = "listarPresupuestosToolStripMenuItem";
            this.listarPresupuestosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listarPresupuestosToolStripMenuItem.Text = "Listar presupuestos";
            this.listarPresupuestosToolStripMenuItem.Click += new System.EventHandler(this.listarPresupuestosToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.ssBarraEstado);
            this.Controls.Add(this.msPrincipal);
            this.Name = "FPrincipal";
            this.Text = "Concesionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ssBarraEstado.ResumeLayout(false);
            this.ssBarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculo;
        private System.Windows.Forms.ToolStripMenuItem añadirUnVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUnVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarLosVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem actualizaDatosVehiculoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssBarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel tsslFecha;
        private System.Windows.Forms.ToolStripStatusLabel tsslFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuarioSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiExtra;
        private System.Windows.Forms.ToolStripMenuItem añadirNuevoExtraDisponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUnExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiActualizarExtra;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirNuevoClienteDisponibleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarUnClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorrerClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLosVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDatosClientePorDNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorrerVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesOrdenadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUnPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorrerPresupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPresupuestosToolStripMenuItem;
    }
}