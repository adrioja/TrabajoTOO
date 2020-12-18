using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modeloDominio;
using TrabajoTOO;

namespace LNCliente
{
    public class LogicaNegocioCliente
    {
        public bool añadir(Cliente c)
            /* Si el cliente c no existe lo añade y devuelve true,
             * en caso cotrario devuelve false y no hace nada. */
        {
            if(!Persistencia.Existe(c))
            {
                Persistencia.Añadir(c);
                return true;
            }
            return false;
        }

        private bool existe(Cliente c)
            /* Si el cliente existe devuelve true */
        {
            return Persistencia.Existe(c);
        }

        public bool eliminar(Cliente c)
            /* C puede contener solo la clave
             * Si c existe en la bd, lo elimina y devuelve true
             * En caso contrario no hace nada y devuelve false. */

        {
            if (!Persistencia.Existe(c))
            {
                return false;
            }
            Persistencia.Borrar(c);
            return true;
        }

        public Cliente buscar(Cliente c)
            /* C puede contener solo la clave
             * Si c existe en la BD, nos devuelve el objeto Cliente con sus campos.
             * En caso contrario nos devuelve null */
        {
            if (Persistencia.Existe(c))
            {
                return Persistencia.Buscar(c);
            }
            return null;
        }

        public bool actualizar(Cliente c)
            /* Dado el cliente c, busca en la bd al cliente cuyo dni coincide, y modifica sus campos por los valores de c.
             * En caso de que los datos se modifiquen devuelve true,
             * En caso contrario devuelve false. */
        {
            if (Persistencia.Existe(c))
            {
                Persistencia.Actualizar(c);
                return true;
            }
            return false;
        }
    }
}
