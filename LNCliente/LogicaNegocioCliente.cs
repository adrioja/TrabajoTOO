using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modeloDominio;
using TrabajoTOO;

namespace LNCliente
{
    /// <summary>
    /// Contiene toda la logica de negocio ligada a los clientes
    /// </summary>
    public class LogicaNegocioCliente
    {

        //--------------------------Metodos de busqueda---------------------------------------------------------------------

        /// <summary>
        /// Obtenemos una lista con todos los clientes de la BD
        /// </summary>
        public static List<Cliente> ListaClientes()
        {
            return Persistencia.listaClientes();
        }

        //--------------------------Metodos CRUD----------------------------------------------------------------------------
        /// <summary>
        /// PRE: el atributo debe de estar incializado;
        /// POST:Si el cliente c no existe lo añade y devuelve true, en caso cotrario devuelve false y no hace nada.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool Añadir(Cliente c)
        {
            if(!Persistencia.Existe(c))
            {
                Persistencia.Añadir(c);
                return true;
            }
            return false;
        }


        /// <summary>
        /// PRE:el atributo debe de estar incializado;
        /// POST: Si el cliente existe devuelve true y falso en caso contrario
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool Existe(Cliente c)
        {
            return Persistencia.Existe(c);
        }


        /// <summary>
        /// PRE:el atributo debe de estar incializado(C puede contener solo la clave)
        /// POST:Si c existe en la bd, lo elimina y devuelve true ,en caso contrario no hace nada y devuelve false.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool Eliminar(Cliente c)
        {
            if (!Persistencia.Existe(c))
            {
                return false;
            }
            Persistencia.Borrar(c);
            return true;
        }


        /// <summary>
        /// PRE:el atributo debe de estar incializado(C puede contener solo la clave)
        /// POST:Si c existe en la BD, nos devuelve el objeto Cliente con sus campos,En caso contrario nos devuelve null
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Cliente Buscar(Cliente c)
        {
            if (Persistencia.Existe(c))
            {
                return Persistencia.Buscar(c);
            }
            return null;
        }


        /// <summary>
        /// PRE:el atributo debe de estar incializado
        /// POST:Dado el cliente c, busca en la bd al cliente cuyo dni coincide, y modifica sus campos por los valores de c. En caso de que los datos se modifiquen devuelve true, en caso contrario devuelve false
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool Actualizar(Cliente c)
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
