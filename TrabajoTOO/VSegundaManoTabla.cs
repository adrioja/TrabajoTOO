using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedGeneral y le decimos que el numero de bastidor es nuestra clave
    /// </summary>
    class VSegundaManoTabla : KeyedGeneral<String, VSegundaManoDatos>
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public VSegundaManoTabla() : base() { }
    }
}
