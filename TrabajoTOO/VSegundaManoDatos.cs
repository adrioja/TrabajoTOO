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
    public class VSegundaManoDatos : VehiculoDatos
    {
        private String matricula;
        
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve la matricula
        /// </summary>
        public String Matricula
        {
            get
            {
                return this.matricula;
            }
        }
        private DateTime fechaMatriculacion;

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve la fecha de matriculacion
        /// </summary>
        public DateTime FechaMatriculacion
        {
            get
            {
                return this.fechaMatriculacion;
            }
        }


        /// <summary>
        /// Incializa la clase
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="fechaMatriculacion"></param>
        /// <param name="numBastidor"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="potencia"></param>
        /// <param name="pvRecomen"></param>
        public VSegundaManoDatos(String matricula, DateTime fechaMatriculacion,String numBastidor, String marca, String modelo, int potencia, double pvRecomen):base(numBastidor,marca,modelo,potencia,pvRecomen)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
        }

    }
}
