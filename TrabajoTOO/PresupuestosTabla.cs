using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedGeneral y le decimos que id es nuestra clave
    /// </summary>
    class PresupuestosTabla : KeyedGeneral<string, PresupuestosDato>
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public PresupuestosTabla() : base() { }
    }
}
