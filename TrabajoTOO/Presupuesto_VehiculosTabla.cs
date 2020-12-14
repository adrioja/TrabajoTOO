using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class Presupuesto_VehiculosTabla : KeyedCollection<Presupuesto_VehiculoClave, Presupuesto_VehiculosDato>
    {
        protected override Presupuesto_VehiculoClave GetKeyForItem(Presupuesto_VehiculosDato item)
        {
            return item.Clave;
        }
    }
}
