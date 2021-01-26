using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedGeneral y le decimos que el id del presupuesto y el numero de bastidor es nuestra clave
    /// </summary>
    class Presupuesto_VehiculosTabla : KeyedGeneral<Presupuesto_VehiculoClave, Presupuesto_VehiculosDato>
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public Presupuesto_VehiculosTabla() : base() { }
    }
}
