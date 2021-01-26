using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedGeneral y le decimos que el numero de bastidor y el nombre del extra es nuestra clave
    /// </summary>
    class VNuevoExtrasTabla : KeyedGeneral<VNuevoExtrasClave, VNuevoExtrasDatos>
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public VNuevoExtrasTabla() : base() { }
    }
}
