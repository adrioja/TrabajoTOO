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
    public partial class FLogearse : Form
    {
        public FLogearse()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            String usuario = this.tbUsuario.Text;
            String contrasela = this.tbContraseña.Text;

            if (true)//------------------------------------------------------------CAMBIAR PARA QUE COMPRUEBEN QUE ESTA EN LA BD
            {
                FPrincipal principal = new FPrincipal(this,usuario);
                principal.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos");
            }
        }
    }
}
