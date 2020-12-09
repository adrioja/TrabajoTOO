using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class VSegundaManoDatos : VehiculoDatos
    {
        private String matricula;
        public String Matricula
        {
            get
            {
                return this.matricula;
            }
        }
        private DateTime fechaMatriculacion;
        public DateTime FechaMatriculacion
        {
            get
            {
                return this.fechaMatriculacion;
            }
        }

    }
}
