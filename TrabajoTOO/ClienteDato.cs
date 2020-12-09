using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class ClienteDato
    {
        private string dni;
        private string nombre;
        private string telefono;
        private string categoria;

        ClienteDato(string dni, string nombre, string telefono, string categoria) 
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = categoria;
        }

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

        public string Categoria
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

        public double Descuento
        {
            get
            {
                if (this.categoria == "A")
                {
                    return 10;
                }
                else if (this.categoria == "B")
                {
                    return 10;
                }
                else
                {
                    return 10;
                }
            }
        }







    }
}
