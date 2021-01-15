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
        /*public FPrincipal(FLogearse log,String usuario)
        {
            log.Hide();
            InitializeComponent();
            this.IsMdiContainer = true;
            this.tsslUsuarioSesion.Text = usuario;
            this.tsslFechaActual.Text = DateTime.Now.ToLongDateString();
        }*/

        public FPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.tsslUsuarioSesion.Text = "pondremos el usuario";
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
                        alta.Name = "Dar de alta";
                        DialogResult drAlta = alta.ShowDialog();
                        if (drAlta.Equals(DialogResult.OK)) //solo entra si los formatos han validado ya correctamente
                        {
                            Extra extra = alta.devExtra();
                            LNVehiculo.LogicaNegocioVehiculo.añadir(extra);
                            MessageBox.Show("El extra se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            alta.Dispose();
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
            bool continuar = false;
            while (!continuar)
            {
                FClaveExtra f = new FClaveExtra();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    //comprobar si ya existe;
                    Extra comprobar = f.devolverExtra();
                    if (LogicaNegocioVehiculo.existeYa(comprobar))
                    {
                        continuar = true;

                        Extra resultadoBusqueda = LNVehiculo.LogicaNegocioVehiculo.buscar(comprobar);
                        RestoDatosExtra busqueda = new RestoDatosExtra(resultadoBusqueda);
                        busqueda.Name = "Eliminar extra";
                        DialogResult drBusqueda = busqueda.ShowDialog();
                        if (drBusqueda.Equals(DialogResult.OK)) //solo entra si los formatos han validado ya correctamente
                        {
                            LNVehiculo.LogicaNegocioVehiculo.eliminar(resultadoBusqueda);
                            MessageBox.Show("El extra se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            busqueda.Dispose();
                        }
                        else
                        {
                            busqueda.Dispose();
                        }

                    }
                    else
                    {
                        //caso que no existe
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un extra con dicho nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    //---------------------------------
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }


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
            bool continuar = false;
            while (!continuar)
            {
                FClaveExtra f = new FClaveExtra();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    //comprobar si ya existe;
                    Extra comprobar = f.devolverExtra();
                    if (LogicaNegocioVehiculo.existeYa(comprobar))
                    {
                        continuar = true;

                        Extra resultadoBusqueda = LNVehiculo.LogicaNegocioVehiculo.buscar(comprobar);
                        RestoDatosExtra busqueda = new RestoDatosExtra(resultadoBusqueda);
                        busqueda.Name = "Buscar extra";
                        DialogResult drBusqueda = busqueda.ShowDialog();
                        if (drBusqueda.Equals(DialogResult.OK)) //solo entra si los formatos han validado ya correctamente
                        {
                            busqueda.Dispose();
                        }
                        else
                        {
                            busqueda.Dispose();
                        }

                    }
                    else
                    {
                        //caso que no existe
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un extra con dicho nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    //---------------------------------
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }


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
            bool continuar = false;
            while (!continuar)
            {
                FClaveExtra f = new FClaveExtra();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    //comprobar si ya existe;
                    Extra comprobar = f.devolverExtra();
                    if (LogicaNegocioVehiculo.existeYa(comprobar))
                    {
                        continuar = true;
                        RestoDatosExtra busqueda = new RestoDatosExtra(comprobar.Nombre);
                        busqueda.Name = "Actualizar extra";
                        DialogResult drBusqueda = busqueda.ShowDialog();
                        if (drBusqueda.Equals(DialogResult.OK)) //solo entra si los formatos han validado ya correctamente
                        {
                            LNVehiculo.LogicaNegocioVehiculo.actualizar(busqueda.devExtra());
                            busqueda.Dispose();
                        }
                        else
                        {
                            busqueda.Dispose();
                        }

                    }
                    else
                    {
                        //caso que no existe
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un extra con dicho nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    //---------------------------------
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }
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


        //----------------------------VEHICULO----------------------------//

        private void añadirUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            while (!continuar)
            {
                FClaveVehiculo f = new FClaveVehiculo();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
                {
                    Vehiculo vehiculo1 = f.devolverVehiculo();
                    if(LNVehiculo.LogicaNegocioVehiculo.existeYa(vehiculo1))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un vehiculo con dicho bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        continuar = true;
                        
                        RestoDatosVehiculo alta = new RestoDatosVehiculo(f.devolverVehiculo().NumBastidor);
                        alta.Name = "Dar de alta un vehiculo";
                        DialogResult drAlta = alta.ShowDialog();
                        if (drAlta.Equals(DialogResult.OK))
                        {
                            Vehiculo vehiculo = alta.devVehiculo();
                            VehiculoNuevo v = vehiculo as VehiculoNuevo;
                            if (v != null)
                            {
                                LNVehiculo.LogicaNegocioVehiculo.añadir(v);
                            }
                            else
                            {
                                LNVehiculo.LogicaNegocioVehiculo.añadir(vehiculo as VehiculoSegundaMano);
                            }
                            MessageBox.Show("El vehiculo se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            alta.Dispose();
                        }
                        else
                        {
                            alta.Dispose();
                        }
                        
                    }   
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }

            
        }

        private void eliminarUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e) //mal CON SEGUNDA MANO
        {
            bool continuar = false;
            while (!continuar)
            {
                FClaveVehiculo f = new FClaveVehiculo();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    Vehiculo v = f.devolverVehiculo();
                    if (!LogicaNegocioVehiculo.existeYa(v))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un vehiculo con dicho nnumero de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        continuar = true;
                        Vehiculo resultadoBusqueda = LNVehiculo.LogicaNegocioVehiculo.buscar(v);
                        RestoDatosVehiculo baja = new RestoDatosVehiculo(resultadoBusqueda);
                        baja.Name = "Dar de baja un vehiculo";
                        DialogResult drBaja = baja.ShowDialog();
                        if (drBaja.Equals(DialogResult.OK))
                        {
                            LNVehiculo.LogicaNegocioVehiculo.eliminar(baja.devVehiculo());
                            MessageBox.Show("El extra se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            baja.Dispose();
                        }
                        else
                        {
                            baja.Dispose();
                        }
                    }
                    
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }

            
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            while (!continuar)
            {
                FClaveVehiculo f = new FClaveVehiculo();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    Vehiculo v = f.devolverVehiculo();
                    if(!LogicaNegocioVehiculo.existeYa(v))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un vehiculo con dicho numero de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        continuar = true;
                        Vehiculo resultadoBusqueda = LNVehiculo.LogicaNegocioVehiculo.buscar(v);
                        RestoDatosVehiculo busqueda = new RestoDatosVehiculo(resultadoBusqueda);
                        busqueda.Name = "Busqueda de un vehiculo";
                        DialogResult drBusqueda = busqueda.ShowDialog();
                        if (drBusqueda.Equals(DialogResult.OK)) //solo entra si los formatos han validado ya correctamente
                        {
                            busqueda.Dispose();
                        }
                        else
                        {
                            busqueda.Dispose();
                        }
                        MessageBox.Show("Busqueda finalizada", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }

            
        }

        private void actualizaDatosVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool continuar = false;
            while (!continuar)
            {
                FClaveVehiculo f = new FClaveVehiculo();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    Vehiculo v1 = f.devolverVehiculo();
                    if(!LNVehiculo.LogicaNegocioVehiculo.existeYa(v1))
                    {

                    }
                    else
                    {
                        continuar = true;
                        RestoDatosVehiculo actualizar = new RestoDatosVehiculo(v1.NumBastidor);
                        actualizar.Name = "Actualizar un vehiculo";
                        DialogResult drActualizar = actualizar.ShowDialog();
                        if (drActualizar.Equals(DialogResult.OK))
                        {
                            Vehiculo v = actualizar.devVehiculo();
                            VehiculoNuevo nuevo = v as VehiculoNuevo;
                            if (nuevo != null)
                            {
                                LNVehiculo.LogicaNegocioVehiculo.actualizar(nuevo);
                            }
                            else
                            {
                                LNVehiculo.LogicaNegocioVehiculo.actualizar(v as VehiculoSegundaMano);
                            }

                            MessageBox.Show("El vehiculo se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizar.Dispose();
                        }
                        else
                        {
                            actualizar.Dispose();
                        }
                    }
                }
                else
                {
                    f.Dispose();
                    continuar = true;
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
            bool continuar = false;
            while (!continuar)
            {
                FClaveCliente c = new FClaveCliente();
                DialogResult dr = c.ShowDialog();
                if (dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
                {
                    Cliente cliente1 = c.devolverCliente();
                    if(LNCliente.LogicaNegocioCliente.Existe(cliente1))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un cliente con dicho DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (aviso.Equals(DialogResult.No))
                        {
                            c.Dispose();
                            continuar = true;

                        }
                        else
                        {
                            c.Dispose();

                        }
                    }
                    else
                    {
                        continuar = true;
                        RestoDatosCliente alta = new RestoDatosCliente(c.devolverCliente().DNI);
                        alta.Name = "Dar de alta un cliente";
                        DialogResult drAlta = alta.ShowDialog();
                        if (drAlta.Equals(DialogResult.OK))
                        {
                            Cliente cliente = alta.devCliente();
                            LNCliente.LogicaNegocioCliente.Añadir(cliente);
                            MessageBox.Show("El Cliente se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            alta.Dispose();
                        }
                        else
                        {
                            alta.Dispose();
                        }
                    }
                    
                }
                else
                {
                    c.Dispose();
                    continuar = true;
                }
            }
        }

        private void eliminarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            while (!continuar)
            {
                FClaveCliente f = new FClaveCliente();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    Cliente c = f.devolverCliente();
                    if (!LNCliente.LogicaNegocioCliente.Existe(c))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con dicho DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        continuar = true;
                        Cliente resultadoBusqueda = LNCliente.LogicaNegocioCliente.Buscar(c);
                        RestoDatosCliente baja = new RestoDatosCliente(resultadoBusqueda);
                        baja.Name = "Dar de baja un cliente";
                        DialogResult drBaja = baja.ShowDialog();
                        if (drBaja.Equals(DialogResult.OK))
                        {
                            LNCliente.LogicaNegocioCliente.Eliminar(c);
                            MessageBox.Show("El cliente se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            baja.Dispose();
                        }
                        else
                        {
                            baja.Dispose();
                        }
                    }  
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }
        }

        private void buscarUnClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            while (!continuar)
            {
                FClaveCliente f = new FClaveCliente();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    Cliente c = f.devolverCliente();
                    if(!LNCliente.LogicaNegocioCliente.Existe(c))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con dicho DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        continuar = true;
                        Cliente resultadoBusqueda = LNCliente.LogicaNegocioCliente.Buscar(c);
                        RestoDatosCliente busqueda = new RestoDatosCliente(resultadoBusqueda);
                        busqueda.Name = "Busqueda de un cliente";
                        DialogResult drBusqueda = busqueda.ShowDialog();
                        if (drBusqueda.Equals(DialogResult.OK)) //solo entra si los formatos han validado ya correctamente
                        {
                            busqueda.Dispose();
                        }
                        else
                        {
                            busqueda.Dispose();
                        }
                        MessageBox.Show("Busqueda finalizada", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        busqueda.Dispose();
                    }
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }   
        }

        private void actualizarUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            while (!continuar)
            {
                FClaveCliente c = new FClaveCliente();
                DialogResult dr = c.ShowDialog();
                if (dr.Equals(DialogResult.OK))
                {
                    Cliente cliente = c.devolverCliente();
                    if(!LNCliente.LogicaNegocioCliente.Existe(cliente))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con dicho DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (aviso.Equals(DialogResult.No))
                        {
                            c.Dispose();
                            continuar = true;

                        }
                        else
                        {
                            c.Dispose();

                        }
                    }
                    else
                    {
                        continuar = true;

                        RestoDatosCliente actualizar = new RestoDatosCliente(c.devolverCliente().DNI);
                        actualizar.Name = "Actualizar un cliente";
                        DialogResult drActualizar = actualizar.ShowDialog();
                        if (drActualizar.Equals(DialogResult.OK))
                        {
                            Cliente v = actualizar.devCliente();
                            LNCliente.LogicaNegocioCliente.Actualizar(v);
                            MessageBox.Show("El cliente se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizar.Dispose();
                        }
                        else
                        {
                            actualizar.Dispose();
                        }
                    }
                }
                else
                {
                    c.Dispose();
                    continuar = true;
                }
            }
        }
    }
}
