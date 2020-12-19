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

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devukve el numero de bastidor
        /// </summary>
        public string NumBastidor
        {
            get
            {
                return this.numBastidor;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devukve el nombre del extra
        /// </summary>
        public string NombreExtra
        {
            get
            {
                return this.nombreExtra;
            }
        }

        /// <summary>
        /// Incializa la clase
        /// </summary>
        /// <param name="numBastidor"></param>
        /// <param name="nombreExtra"></param>
        public VNuevoExtrasClave(string numBastidor,string nombreExtra)
        {
            this.numBastidor = numBastidor;
            this.nombreExtra = nombreExtra;
        }
    }
}
