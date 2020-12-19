using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedCollection y le decimos que id es nuestra clave
    /// </summary>
    class PresupuestosTabla : KeyedCollection<string, PresupuestosDato>
    {
        public PresupuestosTabla() : base() { }

        protected override string GetKeyForItem(PresupuestosDato item)
        {
            return item.Id;
        }
    }
}
