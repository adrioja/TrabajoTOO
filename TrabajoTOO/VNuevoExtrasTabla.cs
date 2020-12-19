using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedCollection y le decimos que el numero de bastidor y el nombre del extra es nuestra clave
    /// </summary>
    class VNuevoExtrasTabla : KeyedCollection<VNuevoExtrasClave, VNuevoExtrasDatos>
    {
        public VNuevoExtrasTabla() : base() { }

        protected override VNuevoExtrasClave GetKeyForItem(VNuevoExtrasDatos item)
        {
            return item.Clave;
        }
    }
}
