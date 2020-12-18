using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Cliente:IEquatable<Cliente>
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private string dni;
        private string nombre;
        private string telefono;
        private CategoriaCliente categoria;
        

        /////////////////////////// CONSTRUCTOR ///////////////////////////
        /// <summary>
        /// Inicializa los atributos
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="telefono"></param>
        /// <param name="categoria"></param>
        public Cliente(string dni, string nombre, string telefono, CategoriaCliente categoria)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = categoria;
            
        }

        /// <summary>
        /// Incializa el atributo DNI
        /// </summary>
        /// <param name="dni"></param>
        public Cliente(string dni)
        {
            this.dni = dni;                     
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve DNI
        /// </summary>
        public string DNI
        {
            get
            {
                return this.dni;
            }
        }

        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST:devuelve el nombre del cliente
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve el telefono o da la posibilidad de cambiarlo
        /// </summary>
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve la categoria o da la posibilidad de cambiarla
        /// </summary>
        public CategoriaCliente Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }

        /// <summary>
        /// PRE:la clase debe de estar incializada por completo
        /// POST:Devuelve el descuento segun la categoria del cliente, si el descuento es del 10%, devuelve 0.10 
        /// </summary>
        public double Descuento {
            /* Devuelve el descuento segun la categoria del cliente,
             * Si el descuento es del 10%, devuelve 0.10 */
            get {
                if(categoria==CategoriaCliente.A)
                {
                    return 0.05;
                }
                else if(categoria==CategoriaCliente.B)
                {
                    return 0.1;
                }
                else //Solo queda el caso en que CategoriaCliente.C
                {
                    return 0.15;
                }
            }
        }

       

        /////////////////////////// METODOS ///////////////////////////


        /// <summary>
        /// PRE: el parametro debe de estar incializado
        /// POST: devuelve true si ambos clientes son iguales comparando su DNI y falso en caso contrario
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Cliente other)
        {
            return this.DNI == other.DNI;
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: devuelve una cadena con los datos del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "- Cliente: [DNI: " + this.DNI + "], [Nombre: " + this.Nombre + "], [Telefono: " + this.Telefono + "], [Categoria: " + this.Categoria + "]";
        }
    }


}
