using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO
{
    class VSegundaManoTabla : KeyedCollection<String, VSegundaManoDatos>
    {
        protected override string GetKeyForItem(VSegundaManoDatos item)
        {
            return item.NumBastidor;
        }
    }
}
