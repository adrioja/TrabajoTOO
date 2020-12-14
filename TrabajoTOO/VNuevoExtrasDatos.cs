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
        
        
        public VNuevoExtrasClave Clave
        {
            get
            {
                return this.clave;
            }
        }
       

        public VNuevoExtrasDatos(VNuevoExtrasClave clave)
        {
            this.clave = clave;              
        }
    }
}
