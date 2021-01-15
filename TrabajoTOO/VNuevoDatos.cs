using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// Representa la forma que tienen los datos de la tabla vehiculosNuevos en el sistema de persistencia
    /// </summary>
    public class VNuevoDatos:VehiculoDatos
    {
        /// <summary>
        /// Inicializa la clase y llama al constructor de la clase padre
        /// </summary>
        /// <param name="numBastidor"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="potencia"></param>
        /// <param name="pvRecomen"></param>
        public VNuevoDatos(String numBastidor, String marca, String modelo, int potencia, double pvRecomen) : base(numBastidor, marca, modelo, potencia, pvRecomen)
        {

        }
    }
}
