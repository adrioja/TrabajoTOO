using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO 
{
    /// <summary>
    /// la clase hereda de  KeyedCollection y le decimos que el no,bre del extra es nuestra clave
    /// </summary>
    class ExtraTabla : KeyedCollection<String, ExtraDatos>
    {
        public ExtraTabla() : base() { }

        protected override string GetKeyForItem(ExtraDatos item)
        {
            return item.Nombre;
        }
    }
}
