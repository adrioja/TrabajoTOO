
namespace capaPresentacion
{
    partial class RestoDatosVehiculo
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbNumeroBastidor = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbPrecioRecomendado = new System.Windows.Forms.TextBox();
            this.tbPotencia = new System.Windows.Forms.TextBox();
            this.lNumeroBastidor = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lModelo = new System.Windows.Forms.Label();
            this.lPotencia = new System.Windows.Forms.Label();
            this.lPrecioRecomendado = new System.Windows.Forms.Label();
            this.rbtNuevo = new System.Windows.Forms.RadioButton();
            this.rbtSegundaMano = new System.Windows.Forms.RadioButton();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbFechaMatriculacion = new System.Windows.Forms.TextBox();
            this.lMatricula = new System.Windows.Forms.Label();
            this.lFechaMatriculacion = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(297, 337);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(417, 337);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbNumeroBastidor
            // 
            this.tbNumeroBastidor.Enabled = false;
            this.tbNumeroBastidor.Location = new System.Drawing.Point(185, 67);
            this.tbNumeroBastidor.Name = "tbNumeroBastidor";
            this.tbNumeroBastidor.ReadOnly = true;
            this.tbNumeroBastidor.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroBastidor.TabIndex = 2;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(185, 153);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 3;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(185, 111);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 4;
            // 
            // tbPrecioRecomendado
            // 
            this.tbPrecioRecomendado.Location = new System.Drawing.Point(185, 237);
            this.tbPrecioRecomendado.Name = "tbPrecioRecomendado";
            this.tbPrecioRecomendado.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioRecomendado.TabIndex = 5;
            // 
            // tbPotencia
            // 
            this.tbPotencia.Location = new System.Drawing.Point(185, 192);
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(100, 20);
            this.tbPotencia.TabIndex = 6;
            // 
            // lNumeroBastidor
            // 
            this.lNumeroBastidor.AutoSize = true;
            this.lNumeroBastidor.Location = new System.Drawing.Point(35, 70);
            this.lNumeroBastidor.Name = "lNumeroBastidor";
            this.lNumeroBastidor.Size = new System.Drawing.Size(99, 13);
            this.lNumeroBastidor.TabIndex = 7;
            this.lNumeroBastidor.Text = "Numero de bastidor";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(35, 114);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 8;
            this.lMarca.Text = "Marca";
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(35, 156);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(42, 13);
            this.lModelo.TabIndex = 9;
            this.lModelo.Text = "Modelo";
            // 
            // lPotencia
            // 
            this.lPotencia.AutoSize = true;
            this.lPotencia.Location = new System.Drawing.Point(35, 195);
            this.lPotencia.Name = "lPotencia";
            this.lPotencia.Size = new System.Drawing.Size(49, 13);
            this.lPotencia.TabIndex = 10;
            this.lPotencia.Text = "Potencia";
            // 
            // lPrecioRecomendado
            // 
            this.lPrecioRecomendado.AutoSize = true;
            this.lPrecioRecomendado.Location = new System.Drawing.Point(35, 240);
            this.lPrecioRecomendado.Name = "lPrecioRecomendado";
            this.lPrecioRecomendado.Size = new System.Drawing.Size(110, 13);
            this.lPrecioRecomendado.TabIndex = 11;
            this.lPrecioRecomendado.Text = "Precio Recomendado";
            // 
            // rbtNuevo
            // 
            this.rbtNuevo.AutoSize = true;
            this.rbtNuevo.Checked = true;
            this.rbtNuevo.Location = new System.Drawing.Point(526, 66);
            this.rbtNuevo.Name = "rbtNuevo";
            this.rbtNuevo.Size = new System.Drawing.Size(57, 17);
            this.rbtNuevo.TabIndex = 12;
            this.rbtNuevo.TabStop = true;
            this.rbtNuevo.Text = "Nuevo";
            this.rbtNuevo.UseVisualStyleBackColor = true;
            this.rbtNuevo.CheckedChanged += new System.EventHandler(this.rbtNuevo_CheckedChanged);
            // 
            // rbtSegundaMano
            // 
            this.rbtSegundaMano.AutoSize = true;
            this.rbtSegundaMano.Location = new System.Drawing.Point(604, 68);
            this.rbtSegundaMano.Name = "rbtSegundaMano";
            this.rbtSegundaMano.Size = new System.Drawing.Size(97, 17);
            this.rbtSegundaMano.TabIndex = 13;
            this.rbtSegundaMano.Text = "Segunda mano";
            this.rbtSegundaMano.UseVisualStyleBackColor = true;
            this.rbtSegundaMano.CheckedChanged += new System.EventHandler(this.rbtSegundaMano_CheckedChanged);
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(549, 156);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(152, 20);
            this.tbMatricula.TabIndex = 14;
            this.tbMatricula.Visible = false;
            // 
            // tbFechaMatriculacion
            // 
            this.tbFechaMatriculacion.Location = new System.Drawing.Point(549, 211);
            this.tbFechaMatriculacion.Name = "tbFechaMatriculacion";
            this.tbFechaMatriculacion.Size = new System.Drawing.Size(152, 20);
            this.tbFechaMatriculacion.TabIndex = 15;
            this.tbFechaMatriculacion.Visible = false;
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Location = new System.Drawing.Point(493, 159);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(50, 13);
            this.lMatricula.TabIndex = 16;
            this.lMatricula.Text = "Matricula";
            this.lMatricula.Visible = false;
            // 
            // lFechaMatriculacion
            // 
            this.lFechaMatriculacion.AutoSize = true;
            this.lFechaMatriculacion.Location = new System.Drawing.Point(426, 214);
            this.lFechaMatriculacion.Name = "lFechaMatriculacion";
            this.lFechaMatriculacion.Size = new System.Drawing.Size(117, 13);
            this.lFechaMatriculacion.TabIndex = 17;
            this.lFechaMatriculacion.Text = "Fecha de matriculacion";
            this.lFechaMatriculacion.Visible = false;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(325, 25);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(118, 20);
            this.lDescripcion.TabIndex = 18;
            this.lDescripcion.Text = "Resto de datos";
            // 
            // RestoDatosVehiculo
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lFechaMatriculacion);
            this.Controls.Add(this.lMatricula);
            this.Controls.Add(this.tbFechaMatriculacion);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.rbtSegundaMano);
            this.Controls.Add(this.rbtNuevo);
            this.Controls.Add(this.lPrecioRecomendado);
            this.Controls.Add(this.lPotencia);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lNumeroBastidor);
            this.Controls.Add(this.tbPotencia);
            this.Controls.Add(this.tbPrecioRecomendado);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbNumeroBastidor);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Name = "RestoDatosVehiculo";
            this.Text = "RestoDatosVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbNumeroBastidor;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbPrecioRecomendado;
        private System.Windows.Forms.TextBox tbPotencia;
        private System.Windows.Forms.Label lNumeroBastidor;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.Label lPotencia;
        private System.Windows.Forms.Label lPrecioRecomendado;
        private System.Windows.Forms.RadioButton rbtNuevo;
        private System.Windows.Forms.RadioButton rbtSegundaMano;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbFechaMatriculacion;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.Label lFechaMatriculacion;
        private System.Windows.Forms.Label lDescripcion;
    }
}