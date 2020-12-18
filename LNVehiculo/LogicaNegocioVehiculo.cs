using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modeloDominio;
using TrabajoTOO;

namespace LNVehiculo
{
    public class LogicaNegocioVehiculo
    {
        //--------------------------------------METODOS VEHICULO NUEVO---------------------------------------
        /// <summary>
        /// PRE: v debe de estar inicializado
        /// POST: comprueba que no esta añadido y si no esta lo añadE, en caso de añadirlo devuelve true y falso en cualquier otro caso
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool añadir(VehiculoNuevo v)
        {
            bool añadido = false;
            if(!existeYa(v))
            {
                Persistencia.Añadir(v);
                añadido = true;
            }
            return añadido;
        }


        /// <summary>
        /// PRE: v debe de estar inicializado
        /// POST: devuelve true si dicho vehiculo estan en nuestra coleccion y falso en caso contrario
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private static bool existeYa(VehiculoNuevo v)
        {
            return Persistencia.Existe(v);
        }


        /// <summary>
        /// PRE: v puede contener solo la clave, debe estar incializado
        /// POST:comprueba que existe y si es asi lo borra y devuelve true y en cualquier otro caso false
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool eliminar(VehiculoNuevo v)
        {
            bool eliminar = false;
            if (existeYa(v))
            {
                Persistencia.Borrar(v);
            }
            return eliminar;
        }


        /// <summary>
        /// PRE: v debe de estar incializado
        /// POST: en caso de existir lo busca y lo devuelve y si no existe devuelve null
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static VehiculoNuevo buscar(VehiculoNuevo v)
        {
            VehiculoNuevo dev = null;
            if(existeYa(v))
            {
                Persistencia.Buscar(v);
            }

            return dev;
        }


        /// <summary>
        /// PRE:v debe de estar incializado y debe contener los datos actualizados del vehiculo que se quiere actualizar(tienen en mismo numBatidor)
        /// POST:comprueba que existe un coche con dicho numBastidor y si es asi lo actualiza y devuelve true y false en cualquier otro caso
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool actualizar(VehiculoNuevo v)

        {
            bool actualizado = false;
            if (existeYa(v))
            {
                Persistencia.Actualizar(v);
                actualizado = true;
            }

            return actualizado;
        }


        /// <summary>
        /// PRE:ambos parametros deben estar incializados
        /// POST:devuelve true si se ha consegido añadir el extra y falso en cualquier otro caso
        /// </summary>
        /// <param name="v"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool añadirExtra(VehiculoNuevo v, Extra e)
        {
            bool añadido = false;
            if(existeYa(v) && Persistencia.Existe(e) && !v.Extras.Contains(e)) //comprobamos que existan en nuestra bd y que no este el extra ya añadido
            {
                v.anadirExtra(e);//añadimos el extra al vehiculo y lo actualizamos
                actualizar(v);
                añadido = true;
            }
            return añadido;
        }


        /// <summary>
        /// PRE:ambos parametros deben estar incializados
        /// POST:devuelve true si se ha consegido quitar el extra y falso en cualquier otro caso(aunque dicho coche no tenga ese extra)
        /// </summary>
        /// <param name="v"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool quitarExtra(VehiculoNuevo v, Extra e)
        {
            bool quitado = false;
            if (existeYa(v) && Persistencia.Existe(e) && v.Extras.Contains(e)) //comprobamos que existan en nuestra bd y que el vehiculo tenga dicho extra
            {
                v.eliminarExtra(e);
                actualizar(v);
                quitado = true;
            }

            return quitado;
        }

        //--------------------------------------METODOS VEHICULO SEGUNDA MANO---------------------------------------


        /// <summary>
        /// PRE:v debe de estar inicializado
        /// POST:comprueba que no esta añadido y si no esta lo añado en caso de añadirlo devuelve true y falso en cualquier otro caso
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool añadir(VehiculoSegundaMano v)
        {
            bool añadido = false;
            if (!existeYa(v))
            {
                Persistencia.Añadir(v);
                añadido = true;
            }
            return añadido;
        }

        /// <summary>
        /// PRE: v debe de estar inicializado
        /// POST: devuelve true si el vehiculo que se la psa como parametro esta en nuestra coleccion
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private static bool existeYa(VehiculoSegundaMano v)
        {
            return Persistencia.Existe(v);
        }

        /// <summary>
        /// PRE:v debe de estar inicializado
        /// POST:comprueba que existe y si es asi lo borra y devuelve true y en cualquier otro caso false
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool eliminar(VehiculoSegundaMano v)
        {
            bool eliminar = false;
            if (existeYa(v))
            {
                Persistencia.Borrar(v);
            }
            return eliminar;
        }

        /// <summary>
        /// PRE:v debe de estar inicializado
        /// POST:en caso de existir lo busca y lo devuelve y si no existe devuelve null
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static VehiculoSegundaMano buscar(VehiculoSegundaMano v)
        {
            VehiculoSegundaMano dev = null;
            if (existeYa(v))
            {
                Persistencia.Buscar(v);
            }
            return dev;
        }

        /// <summary>
        /// PRE:v debe de estar incializado y debe contener los datos actualizados del vehiculo que se quiere actualizar(tienen en mismo numBatidor)
        /// POST:comprueba que existe un coche con dicho numBastidor y si es asi lo actualiza y devuelve true y false en cualquier otro caso
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool actualizar(VehiculoSegundaMano v)
        {
            bool actualizado = false;
            if(existeYa(v))
            {
                Persistencia.Actualizar(v);
                actualizado = true;
            }

            return actualizado;
        }

    }
}
