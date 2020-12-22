using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrabajoTOO
{
    public class KeyedGeneral<TClave, TItem> : KeyedCollection<TClave, TItem> where TItem : Entity<TClave>
    {
        public KeyedGeneral() : base() { }

        protected override TClave GetKeyForItem(TItem item)
        {
            return item.Identificador;
        }
    }
}
