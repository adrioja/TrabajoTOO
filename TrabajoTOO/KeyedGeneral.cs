using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO
{
    /// <summary>
    /// Todas las tablas heredan de esta clase
    /// </summary>
    public class KeyedGeneral<TClave, TItem> : KeyedCollection<TClave, TItem> where TItem : Entity<TClave>
    {
        /// <summary>
        /// Inicializa la clase
        /// </summary>
        public KeyedGeneral() : base() { }

        /// <summary>
        /// PRE: La clase tiene que estar inicializada
        /// POS: Devuelve la clave
        /// </summary>
        protected override TClave GetKeyForItem(TItem item)
        {
            return item.Identificador;
        }
    }
}
