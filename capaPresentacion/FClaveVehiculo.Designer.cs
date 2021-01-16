
namespace capaPresentacion
{
    partial class FClaveVehiculo
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lNumeroBastidor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(72, 189);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(183, 189);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(135, 133);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(123, 20);
            this.tbIdentificador.TabIndex = 0;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(36, 61);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(234, 20);
            this.lDescripcion.TabIndex = 4;
            this.lDescripcion.Text = "Introduce el numero de bastidor";
            // 
            // lNumeroBastidor
            // 
            this.lNumeroBastidor.AutoSize = true;
            this.lNumeroBastidor.Location = new System.Drawing.Point(28, 136);
            this.lNumeroBastidor.Name = "lNumeroBastidor";
            this.lNumeroBastidor.Size = new System.Drawing.Size(99, 13);
            this.lNumeroBastidor.TabIndex = 4;
            this.lNumeroBastidor.Text = "Numero de bastidor";
            // 
            // FClaveVehiculo
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(338, 286);
            this.Controls.Add(this.lNumeroBastidor);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.tbIdentificador);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Name = "FClaveVehiculo";
            this.Text = "Vehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lNumeroBastidor;
    }
}