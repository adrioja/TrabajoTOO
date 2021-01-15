using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{

    /// <summary>
    /// Representa la forma que tienen los datos de la tabla VNuevoExtras en el sistema de persistencia
    /// </summary>
    class VNuevoExtrasDatos : Entity<VNuevoExtrasClave>
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
        public VNuevoExtrasDatos(VNuevoExtrasClave clave):base(clave)
        {
            this.clave = clave;              
        }
    }
}
