using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modeloDominio;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para visualizar en forma de tabla los vehiculos existentes
    /// </summary>
    public partial class FListadoVehiculo : Form
    {
        /// <summary>
        /// Inicializa la clase e introduce en el listado los coches existentes
        /// </summary>
        public FListadoVehiculo()
        {
            InitializeComponent();
            this.Text = "Listado de vehiculos";
            List<Vehiculo> lista = LNVehiculo.LogicaNegocioVehiculo.listaDeTodosLosVehiculos();

            foreach (Vehiculo v in lista)
            {
                string[] vehiculo = { v.NumBastidor, v.Marca, v.Modelo, v.Potencia.ToString(), v.PvRecomendado.ToString(), v.PVP.ToString() };
                this.listado.Rows.Add(vehiculo);
            }
        }
    }
}