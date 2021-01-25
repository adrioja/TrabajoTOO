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
    /// <summary>
    /// Formulario principal de la aplicación 
    /// </summary>
    public partial class FPrincipal : Form
    {

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.tsslUsuarioSesion.Text = "pondremos el usuario";
            this.tsslFechaActual.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// Pre: la clase debe de estar incializada
        /// Post: Si el extra a añadir ya existe nos pregunta si queremos introducir otro. Si no existe lo añadira si cumple con el formato.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        alta.Text = "Dar de alta un extra";
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

        /// <summary>
        /// Pre: la clase debe de estar incializada
        /// Post: Si el extra existe y tiene un formato valido se elimina, si el extra no existe nos preguna si queremos introducir otro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        busqueda.Text = "Eliminar extra";
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
        }

        /// <summary>
        /// Pre: la clase debe de estar incializada
        /// Post: Si el nombre del extra existe nos mostrara los datos del extra, si no existe no preguntara si queremos introducir otro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        busqueda.Text = "Buscar extra";
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
        }
        /// <summary>
        /// Pre: la clase debe de estar incializada
        /// Post: Si el nombre del extra existe nos actualizara los datos del extra, si no existe no preguntara si queremos introducir otro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        busqueda.Text = "Actualizar extra";
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
        }

        /// <summary>
        /// Muestra el formulario VisualizadorGenerakExtras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizadorGeneralExtras visualizador = new VisualizadorGeneralExtras();
            DialogResult dr = visualizador.ShowDialog();
            visualizador.Dispose();
        }


        //----------------------------VEHICULO----------------------------//
        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el vehiculo ya existe preguna si quieres introducir otro. Si no existe se añade el vehiculo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        alta.Text = "Dar de alta un vehiculo";
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

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el vehiculo no existe preguna si queremos introducir otro. Si existe lo elimina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        baja.Text = "Dar de baja un vehiculo";
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

        /// <summary>
        /// Pre: la calse debe estar inicializada
        /// Post: Si el vehiculo existe y el formato es correcto se muestran los datos del vehiculo. Si no existe se pregunta si se quiere introducir otro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        busqueda.Text = "Busqueda de un vehiculo";
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

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el vehiculo existe se actualizan los datos, si no existe se pregunta si se quiere introducir otro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        RestoDatosVehiculo actualizar = new RestoDatosVehiculo(v1.NumBastidor);
                        actualizar.Text = "Actualizar un vehiculo";
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

        /// <summary>
        /// Se muestra el formulario VisualizadorGeneralVehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visualizarLosVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizadorGeneralVehiculo visualizador = new VisualizadorGeneralVehiculo();
            DialogResult dr = visualizador.ShowDialog();
            visualizador.Dispose();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////Clientes////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el cliente ya existe se pregunta si se quiere introducir otro cliente. Si no existe y el formato es correcto se añadira el cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        alta.Text = "Dar de alta un cliente";
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

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el cliente no existe se preguntara si se quiere introducir otro. Si no existe se elimina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        baja.Text = "Dar de baja un cliente";
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

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el cliente introducido no existe se preguntara si se quiere introducir otro. Si existe y el formato es correcto se mostaran los datos del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        busqueda.Text = "Busqueda de un cliente";
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

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el cliente no existe se pregunara si se quiere introducir otro. Si existe y el formato es correcto se actualizaran sus datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        actualizar.Text = "Actualizar un cliente";
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



        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: evento que se produce al hacer click en recorrerClientes, muestra el formulario FRecorrerCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recorrerClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRecorrerCliente form = new FRecorrerCliente(LNCliente.LogicaNegocioCliente.ListaClientes());
            DialogResult d =  form.ShowDialog();
            form.Dispose();

        }

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: evento que se produce al hacer click en listado de los vehiculos, muestra el formulario FListadoVehiculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoDeLosVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListadoVehiculo listadoVehiculo = new FListadoVehiculo();
            DialogResult d = listadoVehiculo.ShowDialog();
            listadoVehiculo.Dispose();
        }


        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: evento que se produce al hacer click en busqueda datos cliente por DNI, muestra el formulario FbusquedaClienteDNI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void busquedaDatosClientePorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBusquedaClienteDNI f = new FBusquedaClienteDNI();
            DialogResult d = f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: evento que se produce al hacer click en recorrer vehiculos, muestra el formulario FRecorrerVehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recorrerVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRecorrerVehiculo form = new FRecorrerVehiculo();
            DialogResult d = form.ShowDialog();
            form.Dispose();
        }

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: evento que se produce al hacer click en listado clientes, muestra el formulario FListadoClientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListadoClientes f = new FListadoClientes();
            DialogResult d = f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Pre: la clase debe de estar incializada
        /// Post: evento que se produce al hacer click en listado clientes ordenado, muestra el formulario ListadoClientesOrdenados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarClientesOrdenadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoClientesOrdeanados l = new ListadoClientesOrdeanados(LNCliente.LogicaNegocioCliente.ListaClientes());
            DialogResult d = l.ShowDialog();
            l.Dispose();
        }


        //----------------PRESUPUESTOS-------------------------

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el presupuesto ya existe preguna si quieres introducir otro. Si no existe y el formato es correcto se añade el presupuesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void añadirPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bool continuar = false;
            while (!continuar)
            {
                FClavePresupuesto f = new FClavePresupuesto();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
                {
                    Presupuesto presupuesto = f.devolverPresupuesto();
                    if (LNPresupuesto.LogicaNegocioPresupuesto.existePresupuesto(presupuesto))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un presupuesto con dicho id", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                        RestoDatosPresupuesto alta = new RestoDatosPresupuesto(f.devolverPresupuesto().Id);
                        alta.Text = "Crear un presupuesto";
                        DialogResult drAlta = alta.ShowDialog();
                        if (drAlta.Equals(DialogResult.OK))
                        {
                            Presupuesto p = alta.devolverPresupuesto();
                            LNPresupuesto.LogicaNegocioPresupuesto.añadirPresupuesto(p);
                            MessageBox.Show("El presupuesto se ha añadido correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el presupuesto no existe preguna si queremos introducir otro. Si existe lo elimina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            while (!continuar)
            {
                FClavePresupuesto f = new FClavePresupuesto();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
                {
                    Presupuesto presupuesto = f.devolverPresupuesto();
                    if (!LNPresupuesto.LogicaNegocioPresupuesto.existePresupuesto(presupuesto))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un presupuesto con dicho id", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                        RestoDatosPresupuesto baja = new RestoDatosPresupuesto(LNPresupuesto.LogicaNegocioPresupuesto.buscarPresupuesto(presupuesto));
                        baja.Text = "Eliminar un presupuesto";
                        DialogResult drBaja = baja.ShowDialog();
                        if (drBaja.Equals(DialogResult.OK))
                        {
                            Presupuesto p = baja.devolverPresupuesto();
                            LNPresupuesto.LogicaNegocioPresupuesto.eliminarPresupuesto(p);
                            MessageBox.Show("El presupuesto se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: Si el presupuesto introducido no existe se preguntara si se quiere introducir otro. Si existe y el formato es correcto se mostaran los datos del presupuesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarUnPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool continuar = false;
            while (!continuar)
            {
                FClavePresupuesto f = new FClavePresupuesto();
                DialogResult dr = f.ShowDialog();
                if (dr.Equals(DialogResult.OK)) //caso en el que se puede introducir
                {
                    Presupuesto presupuesto = f.devolverPresupuesto();
                    if (!LNPresupuesto.LogicaNegocioPresupuesto.existePresupuesto(presupuesto))
                    {
                        DialogResult aviso = MessageBox.Show("¿Quieres introducir otro?", "No existe un presupuesto con dicho id", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                        RestoDatosPresupuesto baja = new RestoDatosPresupuesto(LNPresupuesto.LogicaNegocioPresupuesto.buscarPresupuesto(presupuesto));
                        baja.Text = "Buscar un presupuesto";
                        DialogResult drBaja = baja.ShowDialog();
                        MessageBox.Show("La busqueda ha finalizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baja.Dispose();

                    }
                }
                else
                {
                    f.Dispose();
                    continuar = true;
                }
            }
        }

        /// <summary>
        /// Pre: la clase debe estar inicializada
        /// Post: evento que se produce al hacer clic en recorrer presupuestos. Muestra el formulario FRecorrerPresupuesto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recorrerPresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRecorrerPresupuesto form = new FRecorrerPresupuesto(LNPresupuesto.LogicaNegocioPresupuesto.ListaPresupuestos());
            DialogResult d = form.ShowDialog();
            form.Dispose();
        }
        /// <summary>
        /// Pre:la clase debe estar inicializada
        /// Post: evento que se produce al hacer click en listado de los presupuestos, muestra el formulario FListadoPresupuestos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarPresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListadoPresupuestos form = new FListadoPresupuestos();
            DialogResult d = form.ShowDialog();
            form.Dispose();
        }
    }
}
