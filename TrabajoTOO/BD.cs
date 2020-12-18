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

        private static void InsertVehiculo(VehiculoDatos v)
        {
            BD.Vehiculos.Add(v);
        }
        private static void DeleteVehiculo(VehiculoDatos v)
        {
            BD.Vehiculos.Remove(v.NumBastidor);
        }
        public static VehiculoDatos SelectVehiculo(VehiculoDatos v)
        {    
           return BD.vehiculos[v.NumBastidor];
        }
        private static void UpdateVehiculo(VehiculoDatos v)
        {
            BD.DeleteVehiculo(v);
            BD.InsertVehiculo(v);           
        }
        private static bool ExistsVehiculo(VehiculoDatos v)
        {
            return BD.vehiculos.Contains(v.NumBastidor);
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
            BD.InsertVehiculo(v);
            BD.VSegundaMano.Add(v);           
        }
        public static void DeleteVSegundaMano(VSegundaManoDatos v)
        {
            BD.VSegundaMano.Remove(v.NumBastidor);
            BD.DeleteVehiculo(v);
        }
        public static VSegundaManoDatos SelectVSegundaMano(VSegundaManoDatos v)
        {
            return BD.vSegundaMano[v.NumBastidor];
        }
        public static void UpdateVSegundaMano(VSegundaManoDatos v)
        {
            BD.DeleteVSegundaMano(v);
            BD.DeleteVehiculo(v);
            BD.InsertVehiculo(v);
            BD.InsertVSegundaMano(v);
        }
        public static bool ExistsVSegundaMano(VSegundaManoDatos v)
        {
            return BD.ExistsVehiculo(v);
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
            BD.InsertVehiculo(v);
            BD.vNuevos.Add(v);
            
        }
        public static void DeleteVNuevos(VNuevoDatos v)
        {
            BD.vNuevos.Remove(v.NumBastidor);
            BD.DeleteVehiculo(v);
        }

        public static VNuevoDatos SelectVNuevo(VNuevoDatos v)
        {
            return BD.vNuevos[v.NumBastidor];
        }
        public static void UpdateVNuevo(VNuevoDatos v)
        {
            BD.DeleteVNuevos(v);
            BD.DeleteVehiculo(v);
            BD.InsertVehiculo(v);
            BD.InsertVNuevos(v);
        }
        public static bool ExistsVNuevo(VNuevoDatos v)
        {
            return BD.ExistsVehiculo(v);
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
            return BD.extras[e.Nombre];
        }
        public static void UpdateExtra(ExtraDatos e)
        {          
                BD.DeleteExtras(e);
                BD.InsertExtras(e);
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
            return BD.clientes[c.DNI];
        }

        public static void UpdateCliente(ClienteDatos c)
        {
                BD.DeleteCliente(c);
                BD.InsertCliente(c);
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
            return BD.presupuestos[p.Id];
        }

        public static void UpdatePresupuesto(PresupuestosDato p)
        {
                BD.DeletePresupuesto(p);
                BD.InsertPresupuesto(p);
        }
        
        //---------------------PRESUPUESTO_VEHICULOS----------------------------------------------------------------------------------------

        private static Presupuesto_VehiculosTabla presupuesto_vehiculos;
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
            return BD.presupuesto_vehiculos[p.Clave];
        }

        public static void UpdatePresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
                BD.DeletePresupuesto_Vehiculos(p);
                BD.InsertPresupuesto_Vehiculos(p);
        }




        //---------------------VEHICULONUEVO_EXTRA----------------------------------------------------------------------------------------

        private static VNuevoExtrasTabla vNuevo_Extra;
        public static VNuevoExtrasTabla VNuevo_Extra
        {
            get
            {
                if (vNuevo_Extra == null)
                    vNuevo_Extra = new VNuevoExtrasTabla();
                return vNuevo_Extra;
            }
        }
        public static void InsertVNuevo_Extra(VNuevoExtrasDatos p)
        {
            BD.vNuevo_Extra.Add(p);
        }
        public static void DeleteVNuevo_Extra(VNuevoExtrasDatos p)
        {
            BD.vNuevo_Extra.Remove(p.Clave);
        }
        public static VNuevoExtrasDatos SelectVNuevo_Extra(VNuevoExtrasDatos p)
        {
            return BD.vNuevo_Extra[p.Clave];
        }

        public static void UpdateVNuevo_Extra(VNuevoExtrasDatos p)
        {
            BD.DeleteVNuevo_Extra(p);
            BD.InsertVNuevo_Extra(p);
        }


    }
}
