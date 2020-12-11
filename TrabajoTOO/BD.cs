﻿using System;
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
        //-------------------------------------------------------------------------------------------------------------------------
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
        private static VehiculoDatos SelectVehiculo(VehiculoDatos v)
        {
            IEnumerable<VehiculoDatos> vehiculo = BD.Vehiculos.Select(Vehiculos => v);
            if (vehiculo == null)
            {
                return null;
            }
            else
                return vehiculo.First();
        }
        private static void UpdateVehiculo(VehiculoDatos v)
        {
            //FALTA //FALTA HACERLO EN TODOS
        }
        //-------------------------------------------------------------------------------------------------------------------------
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
        public static void UpdateVSegundaMano(VSegundaManoDatos v)
        {
            //FALTA //FALTA HACERLO EN TODOS
        }
        //-------------------------------------------------------------------------------------------------------------------------
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
        public static void UpdateVNuevo(VNuevoDatos v)
        {
            //FALTA //FALTA HACERLO EN TODOS
        }
        //-------------------------------------------------------------------------------------------------------------------------
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
        public static void UpdateExtra(ExtraDatos e)
        {
            //FALTA //FALTA HACERLO EN TODOS
        }
        //-------------------------------------------------------------------------------------------------------------------------
    }
}
