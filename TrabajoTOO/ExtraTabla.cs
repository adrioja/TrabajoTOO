using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO 
{
    class ExtraTabla : KeyedCollection<String, ExtraDatos>
    {
        public ExtraTabla() : base() { }

        protected override string GetKeyForItem(ExtraDatos item)
        {
            return item.Nombre;
        }
    }
}
