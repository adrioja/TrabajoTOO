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
    /// Formulario para visualizar los vehiculos que estan agregados en el sistema y permite filtar 
    /// </summary>
    public partial class VisualizadorGeneralVehiculo : Form
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public VisualizadorGeneralVehiculo()
        {
            InitializeComponent();
            this.lbListaVehiculos.Enabled = false;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.mostrarTodos();
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: muestra todos los vehiculos disponible
        /// </summary>
        private void mostrarTodos()
        {
            this.lbListaVehiculos.Items.Clear();
            List<Vehiculo> lista =new List<Vehiculo>();
            foreach(Vehiculo ve in LNVehiculo.LogicaNegocioVehiculo.listaDeTodosLosVehiculos())
            {
                lista.Add(LNVehiculo.LogicaNegocioVehiculo.buscar(ve));
            }
            foreach (Vehiculo v in lista)
            {
                String vehiculo = v.ToString();
                vehiculo = vehiculo.Replace('[', ' ');
                vehiculo = vehiculo.Replace(']', ' ');
                this.lbListaVehiculos.Items.Add(vehiculo);
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: vacia todos los cuadros de tecto por los que se puede filtrar
        /// </summary>
        private void vaciar()
        {
            this.tbNumeroBastidor.Text = "";
            this.tbMarca.Text = "";
            this.tbModelo.Text = "";
            this.tbPotencia.Text = "";
            this.tbPrecio.Text = "";
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en el boton limpiar, hace que si se hace click en este boton limpia los filtros y muestra todos los vehiculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.vaciar();
            this.mostrarTodos();
        }


        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: evento que se da lugar al hacer click en el boton buscar, muestra en la lista los vehiculos que cumplen los filtros, si algun campo no cumple el fromato lo ignora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.lbListaVehiculos.Items.Clear();
            String numBastidor = this.tbNumeroBastidor.Text;
            String marca = this.tbMarca.Text;
            String modelo = this.tbModelo.Text;
            int potencia;
            if(!int.TryParse(this.tbPotencia.Text, out potencia))
            {
                potencia = 0;
            }
            double precio;
            if(!double.TryParse(this.tbPrecio.Text, out precio))
            {
                precio =0;
            }
            List<Vehiculo> lista = LNVehiculo.LogicaNegocioVehiculo.busquedaFiltrada(numBastidor,potencia,modelo,marca,precio);
            foreach(Vehiculo v in lista)
            {
                String s = v.ToString();
                s = s.Replace('[', ' ');
                s = s.Replace(']', ' ');
                this.lbListaVehiculos.Items.Add(s);
            }
        }
    }
}
