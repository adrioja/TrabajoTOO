using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    
    class VNuevoExtrasTabla : KeyedCollection<VNuevoExtrasClave, VNuevoExtrasDatos>
    {
        public VNuevoExtrasTabla() : base() { }

        protected override VNuevoExtrasClave GetKeyForItem(VNuevoExtrasDatos item)
        {
            return item.Clave;
        }
    }
}
