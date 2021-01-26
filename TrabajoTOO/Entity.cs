using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoTOO
{
    /// <summary>
    /// Clase abstracta de la que derivan las tablas con los datos, El parametro genérico se corresponde con el tipo de la clave
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
        /// PRE: La clase y el parámetro other tinen que estar inicializados
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Entity<T> other)
        {
            return this.Identificador.Equals(other.Identificador);
        }
    }
}
