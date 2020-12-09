using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO
{
    class VNuevoTabla : KeyedCollection<String, VNuevoDatos>
    {
        protected override string GetKeyForItem(VNuevoDatos item)
        {
            return item.NumBastidor;
        }
    }
}
