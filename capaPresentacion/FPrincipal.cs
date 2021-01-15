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
using capaPresentacion;
using LNVehiculo;

namespace capaPresentacion
{
    public partial class FPrincipal : Form
    {
        public FPrincipal(FLogearse log,String usuario)
        {
            log.Hide();
            InitializeComponent();
            this.IsMdiContainer = true;
            this.tsslUsuarioSesion.Text = usuario;
            this.tsslFechaActual.Text = DateTime.Now.ToLongDateString();
            
        }

        private void añadirNuevoExtraDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool continuar = false;
            while(!continuar)
            {
                FClaveExtra f = new FClaveExtra();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    //comprobar si ya existe;
                    Extra comprobar = f.devolverExtra();
                    if (LogicaNegocioVehiculo.existeYa(comprobar))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un extra con dicho nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (aviso.Equals(DialogResult.No))
                        {
                            f.Dispose();
                            continuar = true;

                        }
                        else
                        {
                            f.Dispose();
                          
                        }
                    }
                    else
                    {
                        //caso que no existe
                        continuar = true;

                        RestoDatosExtra alta = new RestoDatosExtra(f.devolverExtra().Nombre);
                        DialogResult drAlta = alta.ShowDialog();
                        if (drAlta.Equals(DialogResult.OK)) //solo entra si los formatos han validado ya correctamente
                        {
                            Extra extra = alta.devExtra();
                            LNVehiculo.LogicaNegocioVehiculo.añadir(extra);
                            MessageBox.Show("El extra se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            alta.Dispose();
                        }
                    }
                    //---------------------------------
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }

            

        }

        private void eliminarExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FClaveExtra f = new FClaveExtra(OpcionesOperacion.Baja);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosExtra baja = new RestoDatosExtra(LNVehiculo.LogicaNegocioVehiculo.buscar(f.devolverExtra()), OpcionesOperacion.Baja);
                DialogResult drBaja = baja.ShowDialog();
                if (drBaja.Equals(DialogResult.OK))
                {
                    LNVehiculo.LogicaNegocioVehiculo.eliminar(baja.devExtra());
                    MessageBox.Show("El extra se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    baja.Dispose();
                }
            }*/
        }

        private void buscarUnExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FClaveExtra f = new FClaveExtra(OpcionesOperacion.Busqueda);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosExtra busqueda = new RestoDatosExtra(LNVehiculo.LogicaNegocioVehiculo.buscar(f.devolverExtra()), OpcionesOperacion.Busqueda);
                DialogResult drBusqueda = busqueda.ShowDialog();
                busqueda.Dispose();
            }*/
        }

        private void tsmiActualizarExtra_Click(object sender, EventArgs e)
        {
            /*FClaveExtra f = new FClaveExtra(OpcionesOperacion.Busqueda);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosExtra actualizar = new RestoDatosExtra(LNVehiculo.LogicaNegocioVehiculo.buscar(f.devolverExtra()), OpcionesOperacion.Actualizar);
                DialogResult drActualizar = actualizar.ShowDialog();
                if (drActualizar.Equals(DialogResult.OK))
                {
                    LNVehiculo.LogicaNegocioVehiculo.actualizar(actualizar.devExtra());
                    MessageBox.Show("El extra se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    actualizar.Dispose();
                }
                
            }*/

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizadorGeneralExtras visualizador = new VisualizadorGeneralExtras();
            DialogResult dr = visualizador.ShowDialog();
            visualizador.Dispose();
        }

        private void añadirUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClaveVehiculo f = new FClaveVehiculo(OpcionesOperacion.Alta);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
            {
                
                RestoDatosVehiculo alta = new RestoDatosVehiculo(f.devolverVehiculo(), OpcionesOperacion.Alta);
                DialogResult drAlta = alta.ShowDialog();
                if (drAlta.Equals(DialogResult.OK))
                {
                    Vehiculo vehiculo = alta.devVehiculo();
                    VehiculoNuevo v = vehiculo as VehiculoNuevo;
                    if(v!=null)
                    {
                        LNVehiculo.LogicaNegocioVehiculo.añadir(v);
                    }
                    else
                    {
                        LNVehiculo.LogicaNegocioVehiculo.añadir(vehiculo as VehiculoSegundaMano);
                    }
                    MessageBox.Show("El vehiculo se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    alta.Dispose();
                }
            }
            else
            {
                f.Dispose();
            }
        }

        private void eliminarUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e) //mal CON SEGUNDA MANO
        {
            FClaveVehiculo f = new FClaveVehiculo(OpcionesOperacion.Baja);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                Vehiculo v = f.devolverVehiculo();
                RestoDatosVehiculo baja = new RestoDatosVehiculo(v, OpcionesOperacion.Baja);
                DialogResult drBaja = baja.ShowDialog();
                if (drBaja.Equals(DialogResult.OK))
                {
                    LNVehiculo.LogicaNegocioVehiculo.eliminar(baja.devVehiculo());
                    MessageBox.Show("El extra se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    baja.Dispose();
                }
            }
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClaveVehiculo f = new FClaveVehiculo(OpcionesOperacion.Busqueda);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosVehiculo busqueda = new RestoDatosVehiculo(f.devolverVehiculo(), OpcionesOperacion.Busqueda);
                DialogResult drBusqueda = busqueda.ShowDialog();
                busqueda.Dispose();
            }
        }

        private void actualizaDatosVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClaveVehiculo f = new FClaveVehiculo(OpcionesOperacion.Busqueda);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosVehiculo actualizar = new RestoDatosVehiculo(f.devolverVehiculo(), OpcionesOperacion.Actualizar);
                DialogResult drActualizar = actualizar.ShowDialog();
                if (drActualizar.Equals(DialogResult.OK))
                {
                    Vehiculo v = actualizar.devVehiculo();
                    VehiculoNuevo nuevo = v as VehiculoNuevo;
                    if(nuevo!=null)
                    {
                        LNVehiculo.LogicaNegocioVehiculo.actualizar(nuevo);
                    }
                    else
                    {
                        LNVehiculo.LogicaNegocioVehiculo.actualizar(v as VehiculoSegundaMano);
                    }
                    
                    MessageBox.Show("El vehiculo se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    actualizar.Dispose();
                }

            }
        }

        private void visualizarLosVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizadorGeneralVehiculo visualizador = new VisualizadorGeneralVehiculo();
            DialogResult dr = visualizador.ShowDialog();
            visualizador.Dispose();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////Clientes////////////////////////////////////////////////////////////////////////////////
        private void añadirNuevoClienteDisponibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FClaveCliente c = new FClaveCliente(OpcionesOperacion.Alta);
            DialogResult dr = c.ShowDialog();
            if (dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
            {

                RestoDatosCliente alta = new RestoDatosCliente(c.devolverCliente(), OpcionesOperacion.Alta);
                DialogResult drAlta = alta.ShowDialog();
                if (drAlta.Equals(DialogResult.OK))
                {
                    Cliente cliente = alta.devCliente();
                   
                        LNCliente.LogicaNegocioCliente.Añadir(cliente);
                    
                    MessageBox.Show("El Cliente se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    alta.Dispose();
                }
            }
            else
            {
                c.Dispose();
            }
        }

        private void eliminarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FClaveCliente f = new FClaveCliente(OpcionesOperacion.Baja);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                Cliente c = f.devolverCliente();
                RestoDatosCliente baja = new RestoDatosCliente(c, OpcionesOperacion.Baja);
                DialogResult drBaja = baja.ShowDialog();
                if (drBaja.Equals(DialogResult.OK))
                {
                    LNCliente.LogicaNegocioCliente.Eliminar(c);
                    MessageBox.Show("El cliente se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    baja.Dispose();
                }
            }
        }

        private void buscarUnClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FClaveCliente f = new FClaveCliente(OpcionesOperacion.Busqueda);
            DialogResult dr = f.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosCliente busqueda = new RestoDatosCliente(f.devolverCliente(), OpcionesOperacion.Busqueda);
                DialogResult drBusqueda = busqueda.ShowDialog();
                busqueda.Dispose();
            }
        }

        private void actualizarUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FClaveCliente c = new FClaveCliente(OpcionesOperacion.Busqueda);
            DialogResult dr = c.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                RestoDatosCliente actualizar = new RestoDatosCliente(c.devolverCliente(), OpcionesOperacion.Actualizar);
                DialogResult drActualizar = actualizar.ShowDialog();
                if (drActualizar.Equals(DialogResult.OK))
                {
                    Cliente v = actualizar.devCliente();
                    LNCliente.LogicaNegocioCliente.Actualizar(v);
                    

                    MessageBox.Show("El cliente se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    actualizar.Dispose();
                }

            }
        }
    }
}
