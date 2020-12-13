using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class BD
    {
        private BD() { }
        
        
        
        //-----------------VEHICULO------------------------------------------------------------------------------------------
        
        private static VehiculoTabla vehiculos;
        public static VehiculoTabla Vehiculos
        {
            get
            {
                if (vehiculos == null)
                    vehiculos = new VehiculoTabla();
                return vehiculos;
            }
        }

        public static void InsertVehiculo(VehiculoDatos v)
        {
            BD.Vehiculos.Add(v);
        }
        public static void DeleteVehiculo(VehiculoDatos v)
        {
            BD.Vehiculos.Remove(v.NumBastidor);
        }
        public static VehiculoDatos SelectVehiculo(VehiculoDatos v)
        {
            IEnumerable<VehiculoDatos> vehiculo = BD.Vehiculos.Select(Vehiculos => v);
            if (vehiculo == null)
            {
                return null;
            }
            else
                return vehiculo.First();
        }
        public static void UpdateVehiculo(VehiculoDatos v1 , VehiculoDatos v2)
        {
            if (SelectVehiculo(v1) != null && v1.NumBastidor == v2.NumBastidor)
            {
                BD.DeleteVehiculo(v1);
                BD.InsertVehiculo(v2);
            }
        }
        
        
       
        //--------------VEHICULO SEGUNDA MANO-------------------------------------------------------------------------------------------------------
        
        private static VSegundaManoTabla vSegundaMano;
        public static VSegundaManoTabla VSegundaMano
        {
            get
            {
                if (vSegundaMano == null)
                    vSegundaMano = new VSegundaManoTabla();
                return vSegundaMano;
            }
        }

        public static void InsertVSegundaMano(VSegundaManoDatos v)
        {
            BD.VSegundaMano.Add(v);
            BD.InsertVehiculo(v);
        }
        public static void DeleteVSegundaMano(VSegundaManoDatos v)
        {
            BD.VSegundaMano.Remove(v.NumBastidor);
            BD.DeleteVehiculo(v);
        }
        public static VSegundaManoDatos SelectVSegundaMano(VSegundaManoDatos v)
        {
            IEnumerable<VSegundaManoDatos> vehiculo = BD.VSegundaMano.Select(VSegundaMano=>v);
            if (vehiculo==null)
            {
                return null;
            }
            else
                return vehiculo.First();
        }
        public static void UpdateVSegundaMano(VSegundaManoDatos v1, VSegundaManoDatos v2 )
        {
            if (SelectVSegundaMano(v1) != null && v1.NumBastidor == v2.NumBastidor)
            {
                BD.DeleteVSegundaMano(v1);
                BD.UpdateVehiculo(v1, v2);
                BD.InsertVSegundaMano(v2);
            }
        }
        
        
        
        
        //-------------VEHICULO NUEVO-------------------------------------------------------------------------------------------
        
        private static VNuevoTabla vNuevos;
        public static VNuevoTabla VNuevos
        {
            get
            {
                if (vNuevos == null)
                    vNuevos = new VNuevoTabla();
                return vNuevos;
            }
        }
        public static void InsertVNuevos(VNuevoDatos v)
        {
            BD.VNuevos.Add(v);
            BD.InsertVehiculo(v);
        }
        public static void DeleteVNuevos(VNuevoDatos v)
        {
            BD.VNuevos.Remove(v.NumBastidor);
            BD.DeleteVehiculo(v);
        }
        public static VNuevoDatos SelectVNuevo(VNuevoDatos v)
        {
            IEnumerable<VNuevoDatos> vehiculo = BD.VNuevos.Select(VNuevos => v);
            if (vehiculo == null)
            {
                return null;
            }
            else
                return vehiculo.First();
        }
        public static void UpdateVNuevo(VNuevoDatos v1, VNuevoDatos v2)
        {
            if (SelectVNuevo(v1) != null && v1.NumBastidor == v2.NumBastidor)
            {
                BD.DeleteVNuevos(v1);
                BD.UpdateVehiculo(v1, v2);
                BD.InsertVNuevos(v2);
            }
        }
       
        
        
        //-------------EXTRA-----------------------------------------------------------------------------------------------------------
        
        private static ExtraTabla extras;
        public static ExtraTabla Extras
        {
            get
            {
                if (extras == null)
                    extras = new ExtraTabla();
                return extras;
            }
        }
        public static void InsertExtras(ExtraDatos e)
        {
            BD.Extras.Add(e);
        }
        public static void DeleteExtras(ExtraDatos e)
        {
            BD.Extras.Remove(e.Nombre);
        }
        public static ExtraDatos SelectExtra(ExtraDatos e)
        {
            IEnumerable<ExtraDatos> extra = BD.Extras.Select(Extras => e);
            if (extra == null)
            {
                return null;
            }
            else
                return extra.First();
        }
        public static void UpdateExtra(ExtraDatos e1, ExtraDatos e2)
        {
            if (SelectExtra(e1) != null && e1.Nombre==e2.Nombre)
            {
                BD.DeleteExtras(e1);
                BD.InsertExtras(e2);
            }
        }


        //---------------------CLIENTE----------------------------------------------------------------------------------------

        private static ClienteTabla clientes;
        public static ClienteTabla Clientes
        {
            get
            {
                if (clientes == null)
                    clientes = new ClienteTabla();
                return clientes;
            }
        }
        public static void InsertCliente(ClienteDatos c)
        {
            BD.Clientes.Add(c);
        }
        public static void DeleteCliente(ClienteDatos c)
        {
            BD.Clientes.Remove(c.DNI);
        }
        public static ClienteDatos SelectCliente(ClienteDatos c)
        {
            IEnumerable<ClienteDatos> cliente = BD.Clientes.Select(Clientes => c);
            if (cliente == null)
            {
                return null;
            }
            else
                return cliente.First();
        }

        public static void UpdateCliente(ClienteDatos c, ClienteDatos c2)
        {
            if(SelectCliente(c)!=null && c.DNI==c2.DNI)
            {
                BD.DeleteCliente(c);
                BD.InsertCliente(c2);
            }
        }

        //---------------------PRESUPUESTO----------------------------------------------------------------------------------------

        private static PresupuestosTabla presupuestos;
        public static PresupuestosTabla Presupuestos
        {
            get
            {
                if (presupuestos == null)
                    presupuestos = new PresupuestosTabla();
                return presupuestos;
            }
        }
        public static void InsertPresupuesto(PresupuestosDato p)
        {
            BD.Presupuestos.Add(p);
        }
        public static void DeletePresupuesto(PresupuestosDato p)
        {
            BD.Presupuestos.Remove(p.Id);
        }
        public static PresupuestosDato SelectPresupuesto(PresupuestosDato p)
        {
            IEnumerable<PresupuestosDato> presupuesto = BD.Presupuestos.Select(Presupuestos => p);
            if (presupuestos == null)
            {
                return null;
            }
            else
                return presupuesto.First();
        }

        public static void UpdatePresupuesto(PresupuestosDato p, PresupuestosDato p2)
        {
            if (SelectPresupuesto(p) != null && p.Id == p2.Id)
            {
                BD.DeletePresupuesto(p);
                BD.InsertPresupuesto(p2);
            }
        }
        //---------------------PRESUPUESTO_VEHICULOS----------------------------------------------------------------------------------------

        /*private static Presupuesto_VehiculosTabla presupuesto_vehiculos;
        public static Presupuesto_VehiculosTabla Presupuesto_vehiculos
        {
            get
            {
                if (presupuesto_vehiculos == null)
                    presupuesto_vehiculos = new Presupuesto_VehiculosTabla();
                return presupuesto_vehiculos;
            }
        }
        public static void InsertPresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
            BD.Presupuesto_vehiculos.Add(p);
        }
        public static void DeletePresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
            BD.Presupuesto_vehiculos.Remove(p.Clave);
        }
        public static Presupuesto_VehiculosDato SelectPresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
            IEnumerable<Presupuesto_VehiculosDato> presupuesto_vehiculo = BD.Presupuesto_vehiculos.Select(Presupuesto_vehiculos => p);
            if (presupuesto_vehiculos == null)
            {
                return null;
            }
            else
                return presupuesto_vehiculo.First();
        }

        public static void UpdatePresupuesto_Vehiculos(Presupuesto_VehiculosDato p, Presupuesto_VehiculosDato p2)
        {
            if (SelectPresupuesto_Vehiculos(p) != null && p.Clave == p2.Clave)
            {
                BD.DeletePresupuesto_Vehiculos(p);
                BD.InsertPresupuesto_Vehiculos(p2);
            }
        }*/

        //
    }
}
