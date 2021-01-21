namespace capaPresentacion
{
    partial class ListadoClientesOrdeanados
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
            this.components = new System.ComponentModel.Container();
            this.btDNI = new System.Windows.Forms.Button();
            this.btNombre = new System.Windows.Forms.Button();
            this.btTelefono = new System.Windows.Forms.Button();
            this.lbDNI = new System.Windows.Forms.ListBox();
            this.lbNombre = new System.Windows.Forms.ListBox();
            this.lbTelefono = new System.Windows.Forms.ListBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btDNI
            // 
            this.btDNI.Location = new System.Drawing.Point(55, 26);
            this.btDNI.Name = "btDNI";
            this.btDNI.Size = new System.Drawing.Size(115, 23);
            this.btDNI.TabIndex = 0;
            this.btDNI.Text = "DNI";
            this.btDNI.UseVisualStyleBackColor = true;
            this.btDNI.Click += new System.EventHandler(this.btDNI_Click);
            // 
            // btNombre
            // 
            this.btNombre.Location = new System.Drawing.Point(202, 26);
            this.btNombre.Name = "btNombre";
            this.btNombre.Size = new System.Drawing.Size(115, 23);
            this.btNombre.TabIndex = 1;
            this.btNombre.Text = "Nombre";
            this.btNombre.UseVisualStyleBackColor = true;
            this.btNombre.Click += new System.EventHandler(this.btNombre_Click);
            // 
            // btTelefono
            // 
            this.btTelefono.Location = new System.Drawing.Point(349, 26);
            this.btTelefono.Name = "btTelefono";
            this.btTelefono.Size = new System.Drawing.Size(115, 23);
            this.btTelefono.TabIndex = 2;
            this.btTelefono.Text = "Telefono";
            this.btTelefono.UseVisualStyleBackColor = true;
            this.btTelefono.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbDNI
            // 
            this.lbDNI.FormattingEnabled = true;
            this.lbDNI.Location = new System.Drawing.Point(55, 71);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(115, 199);
            this.lbDNI.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.FormattingEnabled = true;
            this.lbNombre.Location = new System.Drawing.Point(202, 71);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(115, 199);
            this.lbNombre.TabIndex = 4;
            // 
            // lbTelefono
            // 
            this.lbTelefono.FormattingEnabled = true;
            this.lbTelefono.Location = new System.Drawing.Point(349, 71);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(115, 199);
            this.lbTelefono.TabIndex = 5;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(202, 282);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 317);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.btTelefono);
            this.Controls.Add(this.btNombre);
            this.Controls.Add(this.btDNI);
            this.Name = "ListadoClientes";
            this.Text = "Listado de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDNI;
        private System.Windows.Forms.Button btNombre;
        private System.Windows.Forms.Button btTelefono;
        private System.Windows.Forms.ListBox lbDNI;
        private System.Windows.Forms.ListBox lbNombre;
        private System.Windows.Forms.ListBox lbTelefono;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.Button btCancelar;
    }
}