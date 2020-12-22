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
        /// <summary>
        /// incializa la bd
        /// </summary>
        private BD() { }


        //-------------------------------------------------------------------------------------------------------------------
        //-----------------VEHICULO------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static VehiculoTabla vehiculos;
        
        /// <summary>
        /// Devuelve la tabla de vehiculos
        /// </summary>
        public static VehiculoTabla Vehiculos
        {
            get
            {
                if (vehiculos == null)
                    vehiculos = new VehiculoTabla();
                return vehiculos;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade el vehiculo
        /// </summary>
        /// <param name="v"></param>
        private static void InsertVehiculo(VehiculoDatos v)
        {
            BD.Vehiculos.Add(v);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Elimina el vehiculo
        /// </summary>
        /// <param name="v"></param>
        private static void DeleteVehiculo(VehiculoDatos v)
        {
            BD.Vehiculos.Remove(v.Identificador);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Devuelve el vehiculo
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static VehiculoDatos SelectVehiculo(VehiculoDatos v)
        {    
           return BD.vehiculos[v.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Actualiza el vehiculo con los datos del vehiculo que se pasa por parametro
        /// </summary>
        /// <param name="v"></param>
        private static void UpdateVehiculo(VehiculoDatos v)
        {
            BD.DeleteVehiculo(v);
            BD.InsertVehiculo(v);           
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Devuelve true si el vehiculo se encuentra en nuestra coleccion y falso en caso contrario
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private static bool ExistsVehiculo(VehiculoDatos v)
        {
            return BD.vehiculos.Contains(v.Identificador);
        }

        //-------------------------------------------------------------------------------------------------------------------
        //--------------VEHICULO SEGUNDA MANO--------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static VSegundaManoTabla vSegundaMano;

        /// <summary>
        /// Devuelve la tabla de vehiculos de segunda mano
        /// </summary>
        public static VSegundaManoTabla VSegundaMano
        {
            get
            {
                if (vSegundaMano == null)
                    vSegundaMano = new VSegundaManoTabla();
                return vSegundaMano;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade el vehiculo de segunda mano a la bd 
        /// </summary>
        /// <param name="v"></param>
        public static void InsertVSegundaMano(VSegundaManoDatos v)
        {
            BD.InsertVehiculo(v);
            BD.VSegundaMano.Add(v);           
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Elimina el vehiculo de segunda mano a la bd 
        /// </summary>
        /// <param name="v"></param>
        public static void DeleteVSegundaMano(VSegundaManoDatos v)
        {
            BD.VSegundaMano.Remove(v.Identificador);
            BD.DeleteVehiculo(v);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Busca el vehiculo de segunda mano en la bd 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static VSegundaManoDatos SelectVSegundaMano(VSegundaManoDatos v)
        {
            return BD.vSegundaMano[v.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Actualiza el vehiculode segunda mano en la bd el parametro contiene los datos del vehiculo actualizado
        /// </summary>
        /// <param name="v"></param>
        public static void UpdateVSegundaMano(VSegundaManoDatos v)
        {
            BD.DeleteVSegundaMano(v);
            BD.DeleteVehiculo(v);
            BD.InsertVehiculo(v);
            BD.InsertVSegundaMano(v);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Dice si el vehiculo de segunda mano existe en la bd, si es asi devuelve true y falso en caso contrario
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool ExistsVSegundaMano(VSegundaManoDatos v)
        {
            return BD.ExistsVehiculo(v);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //-------------VEHICULO NUEVO----------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static VNuevoTabla vNuevos;

        /// <summary>
        /// Devuelve la tabla de vehiculos nuevos
        /// </summary>
        public static VNuevoTabla VNuevos
        {
            get
            {
                if (vNuevos == null)
                    vNuevos = new VNuevoTabla();
                return vNuevos;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade el vehiculo nuevo a la bd
        /// </summary>
        /// <param name="v"></param>
        public static void InsertVNuevos(VNuevoDatos v)
        {
            BD.InsertVehiculo(v);
            BD.vNuevos.Add(v);
            
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Elimina el vehiculo nuevo de la bd
        /// </summary>
        /// <param name="v"></param>
        public static void DeleteVNuevos(VNuevoDatos v)
        {
            BD.vNuevos.Remove(v.Identificador);
            BD.DeleteVehiculo(v);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Devuelve el vehiculo nuevo 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static VNuevoDatos SelectVNuevo(VNuevoDatos v)
        {
            return BD.vNuevos[v.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Actualiza el vehiculo nuevo en la bd, el parametro es el que contiene los datos actualizados
        /// </summary>
        /// <param name="v"></param>
        public static void UpdateVNuevo(VNuevoDatos v)
        {
            BD.DeleteVNuevos(v);
            BD.DeleteVehiculo(v);
            BD.InsertVehiculo(v);
            BD.InsertVNuevos(v);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Dice si el vehiculo nuevo existe en la bd y si es asi devuelve true y falso en caso contrario
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool ExistsVNuevo(VNuevoDatos v)
        {
            return BD.ExistsVehiculo(v);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //-------------EXTRA-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static ExtraTabla extras;

        /// <summary>
        /// Devuelve la tabla de extras
        /// </summary>
        public static ExtraTabla Extras
        {
            get
            {
                if (extras == null)
                    extras = new ExtraTabla();
                return extras;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade el extra a la bd
        /// </summary>
        /// <param name="e"></param>
        public static void InsertExtras(ExtraDatos e)
        {
            BD.Extras.Add(e);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Elimina el extra de la bd
        /// </summary>
        /// <param name="e"></param>
        public static void DeleteExtras(ExtraDatos e)
        {
            BD.Extras.Remove(e.Identificador);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Devuleve el extra
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static ExtraDatos SelectExtra(ExtraDatos e)
        {
            return BD.extras[e.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Actualiza el extra de la bd, el extra que se pasa como parametro es el que contiene los datos actualizados
        /// </summary>
        /// <param name="e"></param>
        public static void UpdateExtra(ExtraDatos e)
        {          
                BD.DeleteExtras(e);
                BD.InsertExtras(e);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Dice si el extra existe en la bd si es asi devuelve true y falso en caso contrario
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ExistsExtra(ExtraDatos e)
        {
            return BD.extras.Contains(e.Identificador);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //---------------------CLIENTE---------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static ClienteTabla clientes;

        /// <summary>
        /// Devuelve la tabla de cliente
        /// </summary>
        public static ClienteTabla Clientes
        {
            get
            {
                if (clientes == null)
                    clientes = new ClienteTabla();
                return clientes;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade cliente a la bd
        /// </summary>
        /// <param name="c"></param>
        public static void InsertCliente(ClienteDatos c)
        {
            BD.Clientes.Add(c);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Elimina cliente de la bd
        /// </summary>
        /// <param name="c"></param>
        public static void DeleteCliente(ClienteDatos c)
        {
            BD.Clientes.Remove(c.Identificador);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Devuelve el cliente
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static ClienteDatos SelectCliente(ClienteDatos c)
        {
            return BD.clientes[c.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Actualiza el cliente de la bd, el cliente que se pasa como parametro es el que tiene los datos actualizados
        /// </summary>
        /// <param name="c"></param>
        public static void UpdateCliente(ClienteDatos c)
        {
                BD.DeleteCliente(c);
                BD.InsertCliente(c);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Dice si existe el cliente en la bd, si es asi devuelve true y falso en caso contrario
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ExistsCliente(ClienteDatos c)
        {
            return BD.clientes.Contains(c.Identificador);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //---------------------PRESUPUESTO-----------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static PresupuestosTabla presupuestos;

        /// <summary>
        /// Devuelve la tabla de presupuestos
        /// </summary>
        public static PresupuestosTabla Presupuestos
        {
            get
            {
                if (presupuestos == null)
                    presupuestos = new PresupuestosTabla();
                return presupuestos;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade el presupuesto a la bd
        /// </summary>
        /// <param name="p"></param>
        public static void InsertPresupuesto(PresupuestosDato p)
        {
            BD.Presupuestos.Add(p);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Elimina el presupuesto de la bd 
        /// </summary>
        /// <param name="p"></param>
        public static void DeletePresupuesto(PresupuestosDato p)
        {
            BD.Presupuestos.Remove(p.Identificador);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Devuelve el Presupuesto 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static PresupuestosDato SelectPresupuesto(PresupuestosDato p)
        {
            return BD.presupuestos[p.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Actualiza el Presupuesto con esa clave de la bd, el Presupuesto que se pasa como parametro es el que tiene los datos actualizados 
        /// </summary>
        /// <param name="p"></param>
        public static void UpdatePresupuesto(PresupuestosDato p)
        {
                BD.DeletePresupuesto(p);
                BD.InsertPresupuesto(p);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Dice si existe el Presupuesto en la bd, si es asi devuelve true y falso en caso contrario
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool ExistsPresupuesto(PresupuestosDato p)
        {
            return BD.presupuestos.Contains(p.Identificador);
        }


        //-------------------------------------------------------------------------------------------------------------------
        //---------------------PRESUPUESTO_VEHICULOS-------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static Presupuesto_VehiculosTabla presupuesto_vehiculos;

        /// <summary>
        /// Devuelve la tabla de vehiculos PRESUPUESTO_VEHICULOS
        /// </summary>
        public static Presupuesto_VehiculosTabla Presupuesto_vehiculos
        {
            get
            {
                if (presupuesto_vehiculos == null)
                    presupuesto_vehiculos = new Presupuesto_VehiculosTabla();
                return presupuesto_vehiculos;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade el presupuesto_vehiculo a la bd 
        /// </summary>
        /// <param name="p"></param>
        public static void InsertPresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
            BD.Presupuesto_vehiculos.Add(p);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Elimina el presupuesto_vehiculo de la bd 
        /// </summary>
        /// <param name="p"></param>
        public static void DeletePresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
            BD.Presupuesto_vehiculos.Remove(p.Identificador);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Devuelve el Presupuesto_vehiculo 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Presupuesto_VehiculosDato SelectPresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
            return BD.presupuesto_vehiculos[p.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Dice si existe el Presupuesto_vehiculo en la bd, si es asi devuelve true y falso en caso contrario
        /// </summary>
        /// <param name="p"></param>
        public static void UpdatePresupuesto_Vehiculos(Presupuesto_VehiculosDato p)
        {
                BD.DeletePresupuesto_Vehiculos(p);
                BD.InsertPresupuesto_Vehiculos(p);
        }



        //-------------------------------------------------------------------------------------------------------------------
        //---------------------VEHICULONUEVO_EXTRA---------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------
        private static VNuevoExtrasTabla vNuevo_Extra;

        /// <summary>
        /// Devuelve la tabla de vehiculos VEHICULONUEVO_EXTRA
        /// </summary>
        public static VNuevoExtrasTabla VNuevo_Extra
        {
            get
            {
                if (vNuevo_Extra == null)
                    vNuevo_Extra = new VNuevoExtrasTabla();
                return vNuevo_Extra;
            }
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Añade p a la bd
        /// </summary>
        /// <param name="p"></param>
        public static void InsertVNuevo_Extra(VNuevoExtrasDatos p)
        {
            BD.vNuevo_Extra.Add(p);
        }


        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Borra p de la bd
        /// </summary>
        /// <param name="p"></param>
        public static void DeleteVNuevo_Extra(VNuevoExtrasDatos p)
        {
            BD.vNuevo_Extra.Remove(p.Identificador);
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Busca p en la bd y la devuelve
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static VNuevoExtrasDatos SelectVNuevo_Extra(VNuevoExtrasDatos p)
        {
            return BD.vNuevo_Extra[p.Identificador];
        }

        /// <summary>
        /// PRE: La clase que se pasa como parametro debe de estar incializada
        /// POST: Actualiza p en la bd, p contiene los datos del onjeto actualizados
        /// </summary>
        /// <param name="p"></param>
        public static void UpdateVNuevo_Extra(VNuevoExtrasDatos p)
        {
            BD.DeleteVNuevo_Extra(p);
            BD.InsertVNuevo_Extra(p);
        }


    }
}
