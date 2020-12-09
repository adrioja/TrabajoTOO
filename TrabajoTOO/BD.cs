using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class BD
    {
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

    }
}
