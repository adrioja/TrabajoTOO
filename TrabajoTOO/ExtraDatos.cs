using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    public class ExtraDatos
    {
        private String nombre;
        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        private double precioFijo;
        public double PrecioFijo
        {
            get
            {
                return this.precioFijo;
            }
        }

        public ExtraDatos(String nombre, double precioFijo)
        {
            this.nombre = nombre;
            this.precioFijo = precioFijo;
        }
    }
}
