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
    public partial class VisualizadorGeneralVehiculo : Form
    {
        public VisualizadorGeneralVehiculo()
        {
            InitializeComponent();
            this.lbListaVehiculos.Enabled = false;
            this.btAceptar.DialogResult = DialogResult.OK;
            this.mostrarTodos();
        }

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

        private void vaciar()
        {
            this.tbNumeroBastidor.Text = "";
            this.tbMarca.Text = "";
            this.tbModelo.Text = "";
            this.tbPotencia.Text = "";
            this.tbPrecio.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.vaciar();
            this.mostrarTodos();
        }

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
