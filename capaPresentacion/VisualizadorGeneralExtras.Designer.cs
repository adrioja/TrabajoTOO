
namespace capaPresentacion
{
    partial class VisualizadorGeneralExtras
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
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lbListaElementos = new System.Windows.Forms.ListBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(89, 20);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(195, 20);
            this.lDescripcion.TabIndex = 1;
            this.lDescripcion.Text = "Lista de extras disponibles";
            // 
            // lbListaElementos
            // 
            this.lbListaElementos.FormattingEnabled = true;
            this.lbListaElementos.Location = new System.Drawing.Point(26, 142);
            this.lbListaElementos.Name = "lbListaElementos";
            this.lbListaElementos.Size = new System.Drawing.Size(334, 290);
            this.lbListaElementos.TabIndex = 2;
            this.lbListaElementos.TabStop = false;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(163, 445);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(74, 75);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(210, 20);
            this.tbBuscar.TabIndex = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(74, 101);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(209, 101);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(29, 49);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(331, 13);
            this.lbBuscar.TabIndex = 7;
            this.lbBuscar.Text = "Se mostraran los extras que contengan dicha palabara en su nombre";
            // 
            // VisualizadorGeneralExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 480);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbListaElementos);
            this.Controls.Add(this.lDescripcion);
            this.MaximizeBox = false;
            this.Name = "VisualizadorGeneralExtras";
            this.Text = "Visualizador extras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.ListBox lbListaElementos;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label lbBuscar;
    }
}