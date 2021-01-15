using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{

    /// <summary>
    /// Representa la tabla Presupuesto_Vehiculo
    /// </summary>
    class Presupuesto_VehiculoClave
    {
        String id;
        String vehiculo;

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve el id del presupuesto
        /// </summary>
        public string Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve el numero de bastidor del vehiculo
        /// </summary>
        public String Vehiculo
        {
            get { return this.vehiculo; }
        }

        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vehiculo"></param>
        public Presupuesto_VehiculoClave(String id, String vehiculo)
        {
            this.id = id;
            this.vehiculo = vehiculo;
        }
    }
}
