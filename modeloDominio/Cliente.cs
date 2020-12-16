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
        public Cliente(string dni, string nombre, string telefono, CategoriaCliente categoria)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = categoria;
            
        }
        public Cliente(string dni)
        {
            this.dni = dni;                     
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        public string DNI
        {
            get
            {
                return this.dni;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

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
        public bool Equals(Cliente other)
        {
            return this.DNI == other.DNI;
        }

        public override string ToString()
        {
            return "- Cliente: [DNI: " + this.DNI + "], [Nombre: " + this.Nombre + "], [Telefono: " + this.Telefono + "], [Categoria: " + this.Categoria + "]";
        }
    }


}
