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
    class VNuevoTabla : KeyedGeneral<String, VNuevoDatos>
    {
        public VNuevoTabla() : base() { }
    }
}
