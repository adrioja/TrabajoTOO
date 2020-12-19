using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// la clase hereda de  KeyedCollection y le decimos que DNI es nuestra clave
    /// </summary>
    class ClienteTabla : KeyedCollection<string, ClienteDatos>
    {
        public ClienteTabla() : base() { }

        protected override string GetKeyForItem(ClienteDatos item)
        {
            return item.DNI;
        }
    }
}