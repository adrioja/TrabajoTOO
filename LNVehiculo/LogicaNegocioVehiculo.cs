﻿using System;
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
        //--------------------------------------METODOS VARIOS---------------------------------------

        /// <summary>
        /// PRE: marca debe contener la marca del vehiculo y modelo el nombre al completo o parte del nombre del modelo
        /// POST: devuelve una lista de coches de dicha marca y cuyo nombre contenga un su modelo parte del modelo que se le ha pasado coomo parametro
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public static List<Vehiculo> buscarPorMarcaModelo(String marca,String modelo)
        {
            List<Vehiculo> l = new List<Vehiculo>();
            foreach(Vehiculo v in Persistencia.listaVehiculos())
            {
                if(v.Marca.Equals(marca) && v.Modelo.Contains(modelo))
                {
                    l.Add(v);
                }
            }
            return l;
        }

        /// <summary>
        /// Devuelve una lista con todos los vehiculos del concesionario
        /// </summary>
        /// <returns></returns>
        public static List<Vehiculo> listaDeTodosLosVehiculos()
        {
            List<Vehiculo> l = new List<Vehiculo>();
            foreach (Vehiculo v in Persistencia.listaVehiculos())
            {
                    l.Add(v);
            }
            return l;
        }

        /// <summary>
        /// Devuelve una lista con todos los vehiculos NUEVOS del concesionario
        /// </summary>
        /// <returns></returns>
        public static List<VehiculoNuevo> listaDeTodosLosVehiculosNuevos()
        {
            List<VehiculoNuevo> l = new List<VehiculoNuevo>();
            foreach (VehiculoNuevo v in Persistencia.listaVehiculosNuevos())
            {
                l.Add(v);
            }
            return l;
        }


        /// <summary>
        /// Devuelve una lista con todos los vehiculos de SEGUNDA MANO del concesionario
        /// </summary>
        /// <returns></returns>
        public static List<VehiculoSegundaMano> listaDeTodosLosVehiculosSegundaMano()
        {
            List<VehiculoSegundaMano> l = new List<VehiculoSegundaMano>();
            foreach (VehiculoSegundaMano v in Persistencia.listaVehiculosSegundaMano())
            {
                l.Add(v);
            }
            return l;
        }

        /// <summary>
        /// DEvuelve una lista con los vehiculos que poseen dichas caracteristicas, si en algun campo no se pone nada(se pone como vacio o si es de tipo numerico 0) no se filtra por dicho parametro
        /// </summary>
        /// <param name="numBastidor"></param>
        /// <param name="potencia"></param>
        /// <param name="modelo"></param>
        /// <param name="marca"></param>
        /// <param name="pvRecomendado"></param>
        /// <returns></returns>
        public static List<Vehiculo> busquedaFiltrada(string numBastidor, int potencia, string modelo, string marca, double pvRecomendado)
        {
            List<Vehiculo> l = new List<Vehiculo>();
            bool bastidor = !numBastidor.Equals("");
            bool potenci = potencia != 0;
            bool mode = !modelo.Equals("");
            bool marc = !modelo.Equals("");
            bool pcRec = pvRecomendado != 0;
            foreach(Vehiculo v in Persistencia.listaVehiculos())
            {
                
            }
            return l;
        }

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
