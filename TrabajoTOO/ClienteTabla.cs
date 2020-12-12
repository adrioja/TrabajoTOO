using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class ClienteTabla : KeyedCollection<string, ClienteDatos>
    {
        protected override string GetKeyForItem(ClienteDatos item)
        {
            return item.DNI;
        }
    }
}