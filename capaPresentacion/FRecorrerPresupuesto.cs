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
    /// Formulario para visualizar todos los presupuestos y recorrerlos de uno a uno.
    /// </summary>
    public partial class FRecorrerPresupuesto : Form
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="listaPresupuestos"></param>
        public FRecorrerPresupuesto(List<Presupuesto> listaPresupuestos)
        {
            InitializeComponent();
            this.bindingSource.CurrentItemChanged += cambio;
            this.bindingNavigator1.BindingSource = this.bindingSource;
            this.bindingSource.DataSource = listaPresupuestos;
        }

        private void cambio(Object sender, EventArgs e)
        {
            this.tbIdentificador.Text = ((Presupuesto)this.bindingSource.Current).Id;
            this.cCliente.Text = ((Presupuesto)this.bindingSource.Current).ClienteAsociado.DNI;
            this.tbFecha.Text = ((Presupuesto)this.bindingSource.Current).FechaRealizacion.ToShortDateString();
            this.tbEstado.Text = ((Presupuesto)this.bindingSource.Current).Estado;
            List<Vehiculo> listaV = ((Presupuesto)this.bindingSource.Current).Vehiculos;
            foreach (Vehiculo v in listaV)
            {
                String s = v.NumBastidor + "- " + v.Modelo + "  -  " + v.Marca + "  -  " + v.PvRecomendado.ToString();
                this.clbVehiculos.Items.Add(s);
            }
            this.cVehiculoComprado.Text = ((Presupuesto)this.bindingSource.Current).VehiculoComprado.NumBastidor;
        }
    }
}
