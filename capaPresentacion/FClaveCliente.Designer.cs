namespace capaPresentacion
{
    partial class FClaveCliente
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
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.lIdentificador = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(130, 22);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(113, 18);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "Introduce el DNI";
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(105, 86);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(173, 20);
            this.tbIdentificador.TabIndex = 7;
            // 
            // lIdentificador
            // 
            this.lIdentificador.AutoSize = true;
            this.lIdentificador.Location = new System.Drawing.Point(58, 90);
            this.lIdentificador.Name = "lIdentificador";
            this.lIdentificador.Size = new System.Drawing.Size(29, 13);
            this.lIdentificador.TabIndex = 6;
            this.lIdentificador.Text = "DNI:";
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(105, 122);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(203, 122);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // FClaveCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 175);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbIdentificador);
            this.Controls.Add(this.lIdentificador);
            this.Controls.Add(this.lbDescripcion);
            this.Name = "FClaveCliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Label lIdentificador;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}