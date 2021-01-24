using modeloDominio;
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
    /// Formulario para visualizar en forma de tabla los presupuestos existentes
    /// </summary>
    public partial class FListadoPresupuestos : Form
    {
        /// <summary>
        /// Inicializa el clase e introduce en el listado los presupuestos existentes
        /// </summary>
        public FListadoPresupuestos()
        {
            InitializeComponent();
            this.Text = "Listado de Presupuestos";
            List<Presupuesto> lista = LNPresupuesto.LogicaNegocioPresupuesto.ListaPresupuestos();
            foreach (Presupuesto p in lista)
            {
                object[] presupuesto = { p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion.ToShortDateString(), p.Estado, p.VehiculoComprado.NumBastidor };
                this.listado.Rows.Add(presupuesto);
            }
        }
    }
}
