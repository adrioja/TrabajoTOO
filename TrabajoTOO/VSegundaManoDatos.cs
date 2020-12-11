using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    public class VSegundaManoDatos : VehiculoDatos
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

        public VSegundaManoDatos(String matricula, DateTime fechaMatriculacion,String numBastidor, String marca, String modelo, int potencia, double pvRecomen):base(numBastidor,marca,modelo,potencia,pvRecomen)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
        }

    }
}
