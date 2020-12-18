using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Extra: IEquatable<Extra>
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private string nombre;
        private double precioFijo;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        
        /// <summary>
        /// Inicializa la clase por completo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precioFijo"></param>
        public Extra(string nombre, double precioFijo)
        {
            this.nombre = nombre;
            this.precioFijo = precioFijo;
        }

        /// <summary>
        /// Inicializa el atributo nombre del extra
        /// </summary>
        /// <param name="nombre"></param>
        public Extra(string nombre)
        {
            this.nombre = nombre;
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
       
        /// <summary>
        /// PRE:la clase debe estar incializada
        /// POST:devuelve el nombre del extra
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// PRE:PRE:la clase debe estar incializada
        /// POST:devuelve o asigna el precio de dicho extra
        /// </summary>
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
        
        /// <summary>
        /// PRE: la clase y el parametro deben de estar inicializadas
        /// POST:devuelve true si ambos extras son iguales comparando por el nombre
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Extra other)
        {
            return this.nombre == other.nombre;
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: devuelve una cadena con los datos del extra
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "- Extra: [Nombre: " + this.Nombre + "], [Precio fijo: " + this.PrecioFijo + "]";
        }

        
    }
}
