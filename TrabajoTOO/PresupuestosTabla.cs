using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class PresupuestosTabla : KeyedCollection<string,PresupuestosDato>
    {
        protected override string GetKeyForItem(PresupuestosDato item)
        {
            return item.Cliente;
        }
    }
}
