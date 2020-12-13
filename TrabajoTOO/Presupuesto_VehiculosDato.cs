using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class Presupuesto_VehiculosDato
    {
        Presupuesto_VehiculoClave clave;

        public Presupuesto_VehiculoClave Clave
        {
            get { return this.clave; }
        }

        public Presupuesto_VehiculosDato(Presupuesto_VehiculoClave clave)
        {
            this.clave = clave;
        }
    }
}
