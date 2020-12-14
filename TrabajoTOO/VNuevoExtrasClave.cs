using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class VNuevoExtrasClave
    {
        private string numBastidor;
        private string nombreExtra;

        public string NumBastidor
        {
            get
            {
                return this.numBastidor;
            }
        }

        public string NombreExtra
        {
            get
            {
                return this.nombreExtra;
            }
        }

        public VNuevoExtrasClave(string numBastidor,string nombreExtra)
        {
            this.numBastidor = numBastidor;
            this.nombreExtra = nombreExtra;
        }
    }
}
