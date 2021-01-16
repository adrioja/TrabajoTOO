using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para hacer un LOGIN --esta incompleto porque todavia no lo utlizamos
    /// </summary>
    public partial class FLogearse : Form
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public FLogearse()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: POST: evento que se da lugar al hacer click en entrar si el usuario y contraseña estan registrados en el sistema deja continuar, sino no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEntrar_Click(object sender, EventArgs e)
        {
            /*String usuario = this.tbUsuario.Text;
            String contrasela = this.tbContraseña.Text;

            if (true)//------------------------------------------------------------CAMBIAR PARA QUE COMPRUEBEN QUE ESTA EN LA BD
            {
                FPrincipal principal = new FPrincipal(this,usuario);
                principal.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos");
            }*/
        }
    }
}
