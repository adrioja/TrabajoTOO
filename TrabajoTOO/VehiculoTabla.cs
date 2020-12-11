using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO
{
    class VehiculoTabla : KeyedCollection<String, VehiculoDatos>
    {
        public VehiculoTabla() : base() { }

        protected override string GetKeyForItem(VehiculoDatos item)
        {
            return item.NumBastidor;
        }
    }
}
