
namespace capaPresentacion
{
    partial class AñadirExtra
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.tbExtraAñadira = new System.Windows.Forms.TextBox();
            this.lResultado = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(338, 138);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(338, 194);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 1;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbPrecio_TextChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(250, 141);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(250, 197);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 3;
            this.lPrecio.Text = "Precio";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(248, 79);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(223, 25);
            this.lDescripcion.TabIndex = 4;
            this.lDescripcion.Text = "Añade un nuevo extra";
            // 
            // tbExtraAñadira
            // 
            this.tbExtraAñadira.Enabled = false;
            this.tbExtraAñadira.Location = new System.Drawing.Point(253, 271);
            this.tbExtraAñadira.Name = "tbExtraAñadira";
            this.tbExtraAñadira.Size = new System.Drawing.Size(315, 20);
            this.tbExtraAñadira.TabIndex = 5;
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.Location = new System.Drawing.Point(117, 274);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(104, 13);
            this.lResultado.TabIndex = 6;
            this.lResultado.Text = "Extra que se añadira";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(311, 341);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 7;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(419, 341);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 8;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // AñadirExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 407);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.tbExtraAñadira);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbNombre);
            this.Name = "AñadirExtra";
            this.Text = "AñadirExtra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.TextBox tbExtraAñadira;
        private System.Windows.Forms.Label lResultado;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btLimpiar;
    }
}