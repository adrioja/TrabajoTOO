
namespace capaPresentacion
{
    partial class VisualizadorGeneralVehiculo
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.tbNumeroBastidor = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbPotencia = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lNumeroBastidor = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lModelo = new System.Windows.Forms.Label();
            this.lPotencia = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.listado = new System.Windows.Forms.DataGridView();
            this.Bastidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pvp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(1072, 335);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(1195, 335);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 6;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNumeroBastidor
            // 
            this.tbNumeroBastidor.Location = new System.Drawing.Point(1153, 59);
            this.tbNumeroBastidor.Name = "tbNumeroBastidor";
            this.tbNumeroBastidor.Size = new System.Drawing.Size(140, 20);
            this.tbNumeroBastidor.TabIndex = 0;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(1153, 103);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(140, 20);
            this.tbMarca.TabIndex = 1;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(1153, 148);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(140, 20);
            this.tbModelo.TabIndex = 2;
            // 
            // tbPotencia
            // 
            this.tbPotencia.Location = new System.Drawing.Point(1153, 190);
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(140, 20);
            this.tbPotencia.TabIndex = 3;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(1153, 239);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(140, 20);
            this.tbPrecio.TabIndex = 4;
            // 
            // lNumeroBastidor
            // 
            this.lNumeroBastidor.AutoSize = true;
            this.lNumeroBastidor.Location = new System.Drawing.Point(1037, 62);
            this.lNumeroBastidor.Name = "lNumeroBastidor";
            this.lNumeroBastidor.Size = new System.Drawing.Size(99, 13);
            this.lNumeroBastidor.TabIndex = 8;
            this.lNumeroBastidor.Text = "Numero de bastidor";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(1094, 106);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 9;
            this.lMarca.Text = "Marca";
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(1094, 151);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(42, 13);
            this.lModelo.TabIndex = 10;
            this.lModelo.Text = "Modelo";
            // 
            // lPotencia
            // 
            this.lPotencia.AutoSize = true;
            this.lPotencia.Location = new System.Drawing.Point(1009, 193);
            this.lPotencia.Name = "lPotencia";
            this.lPotencia.Size = new System.Drawing.Size(135, 13);
            this.lPotencia.TabIndex = 11;
            this.lPotencia.Text = "Potencia mayor o igual que";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(1020, 242);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(127, 13);
            this.lPrecio.TabIndex = 12;
            this.lPrecio.Text = "Precio menor o igual que ";
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAceptar.Location = new System.Drawing.Point(1138, 402);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 7;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // listado
            // 
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bastidor,
            this.Marca,
            this.Modelo,
            this.Potencia,
            this.Precio,
            this.Pvp,
            this.Matricula,
            this.FechaMatricula});
            this.listado.Location = new System.Drawing.Point(35, 50);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(934, 375);
            this.listado.TabIndex = 13;
            // 
            // Bastidor
            // 
            this.Bastidor.HeaderText = "Numero de bastidor";
            this.Bastidor.Name = "Bastidor";
            this.Bastidor.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.HeaderText = "Potencia";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio recomendado";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Pvp
            // 
            this.Pvp.HeaderText = "PVP";
            this.Pvp.Name = "Pvp";
            this.Pvp.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // FechaMatricula
            // 
            this.FechaMatricula.HeaderText = "Fecha de matriculacion";
            this.FechaMatricula.Name = "FechaMatricula";
            this.FechaMatricula.ReadOnly = true;
            // 
            // VisualizadorGeneralVehiculo
            // 
            this.AcceptButton = this.btBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAceptar;
            this.ClientSize = new System.Drawing.Size(1317, 450);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lPotencia);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lNumeroBastidor);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbPotencia);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbNumeroBastidor);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btBuscar);
            this.MaximizeBox = false;
            this.Name = "VisualizadorGeneralVehiculo";
            this.Text = "Visualizador vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.TextBox tbNumeroBastidor;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbPotencia;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lNumeroBastidor;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.Label lPotencia;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bastidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pvp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMatricula;
    }
}