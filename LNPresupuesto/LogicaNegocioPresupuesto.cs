using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoTOO;

namespace LNPresupuesto
{
    public class LogicaNegocioPresupuesto
    {
        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si el presupuesto existe, se añade a la base de datos y devuelve true, en caso contrario devuelve false.
        /// </summary>
        /// <param name="p"></param>
        public bool añadirPresupuesto(Presupuesto p)
        {
            if (Persistencia.Existe(p))
            {
                Persistencia.Añadir(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si el presupuesto existe, lo elimina de la base de datos y devuelve true, en caso contrario devuelve false.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool eliminarPresupuesto(Presupuesto p)
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
        public bool existePresupuesto(Presupuesto p)
        {
            return Persistencia.Existe(p);
        }

        /// <summary>
        /// Pre: P debe estar inicializado.
        /// Post: Si existe p, busca en la base de datos un presupuesto con el mismo id que p. Si lo encuentra actualiza sus valores con los de los campos de p y devuelve true. En caso contrario devuelve false.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool actualizarPresupuesto(Presupuesto p)
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
        public Presupuesto buscarPresupuesto(Presupuesto p)
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
