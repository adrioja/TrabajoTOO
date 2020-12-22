
namespace capaPresentacion
{
    partial class FLogearse
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogearse));
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lContraseña = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            resources.ApplyResources(this.tbUsuario, "tbUsuario");
            this.tbUsuario.Name = "tbUsuario";
            // 
            // tbContraseña
            // 
            resources.ApplyResources(this.tbContraseña, "tbContraseña");
            this.tbContraseña.Name = "tbContraseña";
            // 
            // lUsuario
            // 
            resources.ApplyResources(this.lUsuario, "lUsuario");
            this.lUsuario.Name = "lUsuario";
            // 
            // lContraseña
            // 
            resources.ApplyResources(this.lContraseña, "lContraseña");
            this.lContraseña.Name = "lContraseña";
            // 
            // btEntrar
            // 
            resources.ApplyResources(this.btEntrar, "btEntrar");
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // lDescripcion
            // 
            resources.ApplyResources(this.lDescripcion, "lDescripcion");
            this.lDescripcion.Name = "lDescripcion";
            // 
            // FLogearse
            // 
            this.AcceptButton = this.btEntrar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.MaximizeBox = false;
            this.Name = "FLogearse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Label lDescripcion;
    }
}

