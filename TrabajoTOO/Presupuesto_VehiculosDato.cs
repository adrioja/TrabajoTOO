using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// Representa la forma que tienen los datos de la tabla Presupuesto_Vehiculo en el sistema de persistencia
    /// </summary>
    class Presupuesto_VehiculosDato : Entity<Presupuesto_VehiculoClave>
    {
        Presupuesto_VehiculoClave clave;

        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST:devuelve la clave
        /// </summary>
        public Presupuesto_VehiculoClave Clave
        {
            get { return this.clave; }
        }

        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="clave"></param>
        public Presupuesto_VehiculosDato(Presupuesto_VehiculoClave clave):base(clave)
        {
            this.clave = clave;
        }
    }
}
