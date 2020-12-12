using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    public class ClienteDatos
    {
        private string dni;
        private string nombre;
        private string telefono;
        private string categoria;

        public ClienteDatos(string dni, string nombre, string telefono, string categoria)
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

        
    }
}