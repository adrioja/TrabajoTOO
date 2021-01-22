namespace capaPresentacion
{
    partial class RestoDatosPresupuesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cCliente = new System.Windows.Forms.ComboBox();
            this.clbVehiculos = new System.Windows.Forms.CheckedListBox();
            this.cVehiculoComprado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(148, 31);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.ReadOnly = true;
            this.tbIdentificador.Size = new System.Drawing.Size(121, 20);
            this.tbIdentificador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de realizacion";
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(148, 102);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(100, 20);
            this.tbFecha.TabIndex = 4;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(148, 137);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(100, 20);
            this.tbEstado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(210, 391);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(349, 391);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lista de vehiculos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vehiculo comprado";
            // 
            // cCliente
            // 
            this.cCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCliente.FormattingEnabled = true;
            this.cCliente.Location = new System.Drawing.Point(148, 71);
            this.cCliente.Name = "cCliente";
            this.cCliente.Size = new System.Drawing.Size(121, 21);
            this.cCliente.TabIndex = 13;
            // 
            // clbVehiculos
            // 
            this.clbVehiculos.FormattingEnabled = true;
            this.clbVehiculos.Location = new System.Drawing.Point(148, 183);
            this.clbVehiculos.Name = "clbVehiculos";
            this.clbVehiculos.Size = new System.Drawing.Size(513, 109);
            this.clbVehiculos.TabIndex = 14;
            this.clbVehiculos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbVehiculos_ItemCheck);
            // 
            // cVehiculoComprado
            // 
            this.cVehiculoComprado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cVehiculoComprado.FormattingEnabled = true;
            this.cVehiculoComprado.Location = new System.Drawing.Point(148, 326);
            this.cVehiculoComprado.Name = "cVehiculoComprado";
            this.cVehiculoComprado.Size = new System.Drawing.Size(358, 21);
            this.cVehiculoComprado.TabIndex = 15;
            // 
            // RestoDatosPresupuesto
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.cVehiculoComprado);
            this.Controls.Add(this.clbVehiculos);
            this.Controls.Add(this.cCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdentificador);
            this.Controls.Add(this.label1);
            this.Name = "RestoDatosPresupuesto";
            this.Text = "RestoDatosPresupuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cCliente;
        private System.Windows.Forms.CheckedListBox clbVehiculos;
        private System.Windows.Forms.ComboBox cVehiculoComprado;
    }
}