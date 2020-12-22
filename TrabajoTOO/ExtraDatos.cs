using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    public class ExtraDatos : Entity<String>
    {
        private String nombre;
        
        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve el nombre del extra
        /// </summary>
        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        private double precioFijo;

        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve el precio de dicho extra
        /// </summary>
        public double PrecioFijo
        {
            get
            {
                return this.precioFijo;
            }
        }
        /// <summary>
        /// Incializa la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precioFijo"></param>
        public ExtraDatos(String nombre, double precioFijo): base(nombre)
        {
            this.nombre = nombre;
            this.precioFijo = precioFijo;
        }
    }
}
