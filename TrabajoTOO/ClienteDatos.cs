using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class ClienteDatos
    {
        private string dni;
        private string nombre;
        private string telefono;
        private string categoria;


        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="telefono"></param>
        /// <param name="categoria"></param>
        public ClienteDatos(string dni, string nombre, string telefono, string categoria)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = categoria;
        }


        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve el dni
        /// </summary>
        public string DNI
        {
            get
            {
                return this.dni;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST:devueleve o asigna el telefono
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
        /// PRE: la clase debe de estar incializada
        /// POST:devueleve o asigna la categoria
        /// </summary>
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