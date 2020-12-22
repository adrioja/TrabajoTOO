using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoTOO
{
    public abstract class Entity<T> : IEquatable<Entity<T>>
    {
        private T identificador;
        /// <summary>
        /// Devuelve la clave de la tabla
        /// </summary>
        public T Identificador
        {
            get
            {
                return this.identificador;
            }
        }

        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="t"></param>
        public Entity(T t)
        {
            this.identificador = t;
        }


        /// <summary>
        /// Devuelve true si tienen la misma clave y false en caso contrario
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Entity<T> other)
        {
            return this.Identificador.Equals(other.Identificador);
        }
    }
}
