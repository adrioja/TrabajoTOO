namespace capaPresentacion
{
    partial class FBusquedaClienteDNI
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
            this.grupo = new System.Windows.Forms.GroupBox();
            this.rbtC = new System.Windows.Forms.RadioButton();
            this.rbtB = new System.Windows.Forms.RadioButton();
            this.rbtA = new System.Windows.Forms.RadioButton();
            this.lCategoria = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lDni = new System.Windows.Forms.Label();
            this.cbDNIs = new System.Windows.Forms.ComboBox();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.rbtC);
            this.grupo.Controls.Add(this.rbtB);
            this.grupo.Controls.Add(this.rbtA);
            this.grupo.Controls.Add(this.lCategoria);
            this.grupo.Controls.Add(this.tbTelefono);
            this.grupo.Controls.Add(this.tbNombre);
            this.grupo.Controls.Add(this.lTelefono);
            this.grupo.Controls.Add(this.lNombre);
            this.grupo.Location = new System.Drawing.Point(29, 99);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(299, 182);
            this.grupo.TabIndex = 0;
            this.grupo.TabStop = false;
            // 
            // rbtC
            // 
            this.rbtC.AutoSize = true;
            this.rbtC.Enabled = false;
            this.rbtC.Location = new System.Drawing.Point(201, 143);
            this.rbtC.Name = "rbtC";
            this.rbtC.Size = new System.Drawing.Size(32, 17);
            this.rbtC.TabIndex = 7;
            this.rbtC.TabStop = true;
            this.rbtC.Text = "C";
            this.rbtC.UseVisualStyleBackColor = true;
            // 
            // rbtB
            // 
            this.rbtB.AutoSize = true;
            this.rbtB.Enabled = false;
            this.rbtB.Location = new System.Drawing.Point(148, 143);
            this.rbtB.Name = "rbtB";
            this.rbtB.Size = new System.Drawing.Size(32, 17);
            this.rbtB.TabIndex = 6;
            this.rbtB.TabStop = true;
            this.rbtB.Text = "B";
            this.rbtB.UseVisualStyleBackColor = true;
            // 
            // rbtA
            // 
            this.rbtA.AutoSize = true;
            this.rbtA.Enabled = false;
            this.rbtA.Location = new System.Drawing.Point(101, 143);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(32, 17);
            this.rbtA.TabIndex = 5;
            this.rbtA.TabStop = true;
            this.rbtA.Text = "A";
            this.rbtA.UseVisualStyleBackColor = true;
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(28, 143);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 4;
            this.lCategoria.Text = "Categoria";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(101, 88);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.ReadOnly = true;
            this.tbTelefono.Size = new System.Drawing.Size(132, 20);
            this.tbTelefono.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(101, 28);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(132, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(25, 91);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(49, 13);
            this.lTelefono.TabIndex = 1;
            this.lTelefono.Text = "Telefono";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(25, 31);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDni.Location = new System.Drawing.Point(53, 37);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(37, 20);
            this.lDni.TabIndex = 1;
            this.lDni.Text = "DNI";
            // 
            // cbDNIs
            // 
            this.cbDNIs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDNIs.FormattingEnabled = true;
            this.cbDNIs.Location = new System.Drawing.Point(110, 39);
            this.cbDNIs.Name = "cbDNIs";
            this.cbDNIs.Size = new System.Drawing.Size(179, 21);
            this.cbDNIs.TabIndex = 2;
            this.cbDNIs.SelectedIndexChanged += new System.EventHandler(this.cbDNIs_SelectedIndexChanged);
            // 
            // FBusquedaClienteDNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 319);
            this.Controls.Add(this.cbDNIs);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.grupo);
            this.Name = "FBusquedaClienteDNI";
            this.Text = "Datos de un cliente";
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.ComboBox cbDNIs;
        private System.Windows.Forms.RadioButton rbtA;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.RadioButton rbtC;
        private System.Windows.Forms.RadioButton rbtB;
    }
}