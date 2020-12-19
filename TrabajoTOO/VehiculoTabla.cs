using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedCollection y le decimos que numero de bastidor es nuestra clave
    /// </summary>
    class VehiculoTabla : KeyedCollection<String, VehiculoDatos>
    {
        public VehiculoTabla() : base() { }

        protected override string GetKeyForItem(VehiculoDatos item)
        {
            return item.NumBastidor;
        }
    }
}
