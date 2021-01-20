namespace capaPresentacion
{
    partial class ListadoVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listado = new System.Windows.Forms.DataGridView();
            this.vehiculoDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSegundaManoDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logicaNegocioVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NumBastidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioRecm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSegundaManoDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicaNegocioVehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listado
            // 
            this.listado.AllowUserToAddRows = false;
            this.listado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.listado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumBastidor,
            this.Marca,
            this.Modelo,
            this.Potencia,
            this.PrecioRecm,
            this.PVP});
            this.listado.Location = new System.Drawing.Point(1, 0);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(758, 240);
            this.listado.TabIndex = 0;

            // 
            // logicaNegocioVehiculoBindingSource
            // 
            this.logicaNegocioVehiculoBindingSource.DataSource = typeof(LNVehiculo.LogicaNegocioVehiculo);
            // 
            // NumBastidor
            // 
            this.NumBastidor.HeaderText = "Numero de bastidor";
            this.NumBastidor.Name = "NumBastidor";
            this.NumBastidor.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.HeaderText = "Potencia";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // PrecioRecm
            // 
            this.PrecioRecm.HeaderText = "Precio recomendado";
            this.PrecioRecm.Name = "PrecioRecm";
            this.PrecioRecm.ReadOnly = true;
            // 
            // PVP
            // 
            this.PVP.HeaderText = "PVP";
            this.PVP.Name = "PVP";
            this.PVP.ReadOnly = true;
            // 
            // ListadoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 241);
            this.Controls.Add(this.listado);
            this.Name = "ListadoVehiculo";
            this.Text = "ListadoVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSegundaManoDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicaNegocioVehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.BindingSource vehiculoDatosBindingSource;
        private System.Windows.Forms.BindingSource vSegundaManoDatosBindingSource;
        private System.Windows.Forms.BindingSource logicaNegocioVehiculoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBastidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioRecm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVP;
    }
}