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
    public partial class AltaExtra : Form
    {
        public AltaExtra()
        {
            InitializeComponent();
            this.btCancelar.DialogResult = DialogResult.Cancel;
            this.btAceptar.DialogResult = DialogResult.OK;        
        }
    }
}
