using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    class Extra: IEquatable<Extra>
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private string nombre;
        private double precioFijo;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        public Extra(string nombre, double precioFijo)
        {
            this.nombre = nombre;
            this.precioFijo = precioFijo;
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public double PrecioFijo
        {
            get
            {
                return this.precioFijo;
            }
            set
            {
                this.precioFijo = value;
            }
        }        


        /////////////////////////// METODOS ///////////////////////////
        public bool Equals(Extra other)
        {
            return this.nombre == other.nombre;
        }

        public override string ToString()
        {
            return "- Extra: [Nombre: " + this.Nombre + "], [Precio fijo: " + this.PrecioFijo + "]";
        }

        
    }
}
