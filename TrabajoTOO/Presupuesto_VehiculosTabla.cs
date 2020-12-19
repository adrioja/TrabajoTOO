using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedCollection y le decimos que el id del presupuesto y el numero de bastidor es nuestra clave
    /// </summary>
    class Presupuesto_VehiculosTabla : KeyedCollection<Presupuesto_VehiculoClave, Presupuesto_VehiculosDato>
    {
        public Presupuesto_VehiculosTabla() : base() { }

        protected override Presupuesto_VehiculoClave GetKeyForItem(Presupuesto_VehiculosDato item)
        {
            return item.Clave;
        }
    }
}
