using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class Presupuesto_VehiculoClave
    {
        String id;
        String vehiculo;

        public string Id
        {
            get { return this.id; }
        }

        public String Vehiculo
        {
            get { return this.vehiculo; }
        }
        public Presupuesto_VehiculoClave(String id, String vehiculo)
        {
            this.id = id;
            this.vehiculo = vehiculo;
        }
    }
}
