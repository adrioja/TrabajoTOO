
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
            this.tsmiVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmiVehiculo
            // 
            this.tsmiVehiculo.Name = "tsmiVehiculo";
            this.tsmiVehiculo.Size = new System.Drawing.Size(77, 19);
            this.tsmiVehiculo.Text = "Vehiculo";
            // 
            // tsmiCliente
            // 
            this.tsmiCliente.Name = "tsmiCliente";
            this.tsmiCliente.Size = new System.Drawing.Size(77, 19);
            this.tsmiCliente.Text = "Cliente";
            // 
            // tsmiPresupuesto
            // 
            this.tsmiPresupuesto.Name = "tsmiPresupuesto";
            this.tsmiPresupuesto.Size = new System.Drawing.Size(77, 19);
            this.tsmiPresupuesto.Text = "Presupuesto";
            // 
            // msPrincipal
            // 
            this.msPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVehiculo,
            this.tsmiCliente,
            this.tsmiPresupuesto});
            this.msPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(90, 395);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FPrincipal";
            this.Text = "Concesionario";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiPresupuesto;
        private System.Windows.Forms.MenuStrip msPrincipal;
    }
}