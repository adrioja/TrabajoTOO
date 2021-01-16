
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
            this.lbListaVehiculos = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // lbListaVehiculos
            // 
            this.lbListaVehiculos.FormattingEnabled = true;
            this.lbListaVehiculos.Location = new System.Drawing.Point(22, 35);
            this.lbListaVehiculos.Name = "lbListaVehiculos";
            this.lbListaVehiculos.Size = new System.Drawing.Size(739, 394);
            this.lbListaVehiculos.TabIndex = 0;
            this.lbListaVehiculos.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(830, 338);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(953, 338);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 6;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNumeroBastidor
            // 
            this.tbNumeroBastidor.Location = new System.Drawing.Point(911, 62);
            this.tbNumeroBastidor.Name = "tbNumeroBastidor";
            this.tbNumeroBastidor.Size = new System.Drawing.Size(140, 20);
            this.tbNumeroBastidor.TabIndex = 0;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(911, 106);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(140, 20);
            this.tbMarca.TabIndex = 1;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(911, 151);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(140, 20);
            this.tbModelo.TabIndex = 2;
            // 
            // tbPotencia
            // 
            this.tbPotencia.Location = new System.Drawing.Point(911, 193);
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(140, 20);
            this.tbPotencia.TabIndex = 3;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(911, 242);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(140, 20);
            this.tbPrecio.TabIndex = 4;
            // 
            // lNumeroBastidor
            // 
            this.lNumeroBastidor.AutoSize = true;
            this.lNumeroBastidor.Location = new System.Drawing.Point(795, 65);
            this.lNumeroBastidor.Name = "lNumeroBastidor";
            this.lNumeroBastidor.Size = new System.Drawing.Size(99, 13);
            this.lNumeroBastidor.TabIndex = 8;
            this.lNumeroBastidor.Text = "Numero de bastidor";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(852, 109);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 9;
            this.lMarca.Text = "Marca";
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(852, 154);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(42, 13);
            this.lModelo.TabIndex = 10;
            this.lModelo.Text = "Modelo";
            // 
            // lPotencia
            // 
            this.lPotencia.AutoSize = true;
            this.lPotencia.Location = new System.Drawing.Point(767, 196);
            this.lPotencia.Name = "lPotencia";
            this.lPotencia.Size = new System.Drawing.Size(135, 13);
            this.lPotencia.TabIndex = 11;
            this.lPotencia.Text = "Potencia mayor o igual que";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(778, 245);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(127, 13);
            this.lPrecio.TabIndex = 12;
            this.lPrecio.Text = "Precio menor o igual que ";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(896, 405);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 7;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // VisualizadorGeneralVehiculo
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
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
            this.Controls.Add(this.lbListaVehiculos);
            this.MaximizeBox = false;
            this.Name = "VisualizadorGeneralVehiculo";
            this.Text = "Visualizador vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaVehiculos;
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
    }
}