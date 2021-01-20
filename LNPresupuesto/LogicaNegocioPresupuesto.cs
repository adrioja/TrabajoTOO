using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoTOO;

namespace LNPresupuesto
{
    /// <summary>
    /// Contiene toda la logica de negocio ligada a los presupuestos
    /// </summary>
    public class LogicaNegocioPresupuesto
    {
        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si el presupuesto no existe, se añade a la base de datos y devuelve true, en caso contrario devuelve false.
        /// </summary>
        /// <param name="p"></param>
        public static bool añadirPresupuesto(Presupuesto p)
        {
            if (Persistencia.Existe(p))
            {
                return false;
            }
            else
            {
                Persistencia.Añadir(p);
                return true;
            }
        }

        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si el presupuesto existe en la bd, lo elimina de la base de datos y devuelve true, en caso contrario devuelve false.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool eliminarPresupuesto(Presupuesto p)
        {
            if (Persistencia.Existe(p)){
                Persistencia.Borrar(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si el presupuesto existe devuelve true, en caso contrario devuelve false.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool existePresupuesto(Presupuesto p)
        {
            return Persistencia.Existe(p);
        }

        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si existe p en la bd(un preuspuesto con el mismo id), busca en la base de datos un presupuesto con el mismo id que p. Si lo encuentra actualiza sus valores con los de los campos de p y devuelve true. En caso contrario devuelve false.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool actualizarPresupuesto(Presupuesto p)
        {
            if (Persistencia.Existe(p))
            {
                Persistencia.Actualizar(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si existe p, nos devuelve de la base de datos un objeto persistencia on todos sus valores. En caso contraio devuelve null.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Presupuesto buscarPresupuesto(Presupuesto p)
        {
            if (Persistencia.Existe(p))
            {
                return Persistencia.Buscar(p);
            }
            else
            {
                return null;
            }
        }
    }
}
