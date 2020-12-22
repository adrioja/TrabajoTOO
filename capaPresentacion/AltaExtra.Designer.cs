
namespace capaPresentacion
{
    partial class AltaExtra
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 52);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(223, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(134, 105);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(223, 20);
            this.tbPrecio.TabIndex = 1;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(58, 55);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(58, 108);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 3;
            this.lPrecio.Text = "Precio";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(134, 166);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(282, 166);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // AltaExtra
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(464, 291);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbNombre);
            this.Name = "AltaExtra";
            this.Text = "AltaExtra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
    }
}