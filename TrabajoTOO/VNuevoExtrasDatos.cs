using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class VNuevoExtrasDatos
    {
        private VNuevoExtrasClave clave;
        
        /// <summary>
        /// PRE: la clase debe  de estar incializada
        /// POST: devuelve la clave
        /// </summary>
        public VNuevoExtrasClave Clave
        {
            get
            {
                return this.clave;
            }
        }
       
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="clave"></param>
        public VNuevoExtrasDatos(VNuevoExtrasClave clave)
        {
            this.clave = clave;              
        }
    }
}
