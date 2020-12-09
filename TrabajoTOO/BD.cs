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
        }
        public static void DeleteVSegundaMano(VSegundaManoDatos v)
        {
            BD.VSegundaMano.Remove(v.NumBastidor);
        }
        public static void SelectVSegundaMano(VSegundaManoDatos v)
        {
            //FALTA HACERLO EN TODOS
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
        }
        public static void DeleteVNuevos(VNuevoDatos v)
        {
            BD.VNuevos.Remove(v.NumBastidor);
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
        //-------------------------------------------------------------------------------------------------------------------------
    }
}
