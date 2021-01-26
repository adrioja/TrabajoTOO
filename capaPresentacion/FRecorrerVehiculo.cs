using modeloDominio;
using System;
using System.Windows.Forms;

namespace capaPresentacion
{
    /// <summary>
    /// Formulario para recorrer todos los vehiculos existentes
    /// </summary>
    public partial class FRecorrerVehiculo : Form
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public FRecorrerVehiculo()
        {
            InitializeComponent();
            this.bindingSource.CurrentItemChanged += cambio;
            this.bindingNavigator1.BindingSource = this.bindingSource;
            this.bindingSource.DataSource = LNVehiculo.LogicaNegocioVehiculo.listaDeTodosLosVehiculos();
        }


        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: metodo de respuesta al evento CurrentItemChanged de BindingSource, actualiza los textBox para mostrar el vehiculo correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambio(Object sender, EventArgs e)
        {

            Vehiculo v = LNVehiculo.LogicaNegocioVehiculo.buscar(this.bindingSource.Current as Vehiculo);

            VehiculoNuevo nuevo = v as VehiculoNuevo ;
            if(nuevo!=null)
            {
                this.rbtNuevo.Checked = true;
                this.noMostrarSegundaDatos();
                this.asignarDatos();
            }
            else
            {
                VehiculoSegundaMano segunda = v as VehiculoSegundaMano;
                this.rbtSegundaMano.Checked = true;
                this.mostrarSegundaDatos();
                this.asignarDatos();
                this.tbMatricula.Text = segunda.Matricula;
                this.tbFechaMatricula.Text = segunda.FechaMatriculacion.ToShortDateString();
            }
            
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: hace que los elementos que solo contienen datos de vehiculos de segunda mano no esten visibles
        /// </summary>
        private void noMostrarSegundaDatos()
        {
            this.lFecha.Visible = false;
            this.lMatricula.Visible = false;
            this.tbFechaMatricula.Visible = false;
            this.tbMatricula.Visible = false;
        }


        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: hace que los elementos que solo contienen datos de vehiculos de segunda mano sean visibles
        /// </summary>
        private void mostrarSegundaDatos()
        {
            this.lFecha.Visible = true;
            this.lMatricula.Visible = true;
            this.tbFechaMatricula.Visible = true;
            this.tbMatricula.Visible = true;
        }

        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: asigna los datos comunes a los textBox del vehiculo correspondiente
        /// </summary>
        private void asignarDatos()
        {
            Vehiculo v = this.bindingSource.Current as Vehiculo;

            this.tbNumeroBastidor.Text = v.NumBastidor;
            this.tbMarca.Text = v.Marca;
            this.tbModelo.Text = v.Modelo;
            this.tbPotencia.Text = v.Potencia.ToString();
            this.tbPrecioRec.Text = v.PvRecomendado.ToString();
        }

    }
}
