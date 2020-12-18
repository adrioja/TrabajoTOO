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

        public bool añadir(VehiculoNuevo v)
            //v debe de estar inicializado
            //comprueba que no esta añadido y si no esta lo añado en caso de añadirlo devuelve true y falso en cualquier otro caso
        {
            bool añadido = false;
            if(!this.existeYa(v))
            {
                Persistencia.Añadir(v);
                añadido = true;
            }
            return añadido;
        }

        private bool existeYa(VehiculoNuevo v)
        {
            return Persistencia.Existe(v);
        }

        public bool eliminar(VehiculoNuevo v)
            //v debe de estar incializado
            //comprueba que existe y si es asi lo borra y devuelve true y en cualquier otro caso false
        {
            bool eliminar = false;
            if (this.existeYa(v))
            {
                Persistencia.Borrar(v);
            }
            return eliminar;
        }


        public List<Extra> extrasCoche(VehiculoNuevo v)
        {
            return v.Extras;
        }

        public VehiculoNuevo buscar(VehiculoNuevo v)
            //v debe de estar incializado
            //en caso de existir lo busca y lo devuelve y si no existe devuelve null
        {
            VehiculoNuevo dev = null;
            if(this.existeYa(v))
            {
                Persistencia.Buscar(v);
            }

            return dev;
        }

        public bool actualizar(VehiculoNuevo v)
        //v debe de estar incializado y debe contener los datos actualizados del vehiculo que se quiere actualizar(tienen en mismo numBatidor)
        //comprueba que existe un coche con dicho numBastidor y si es asi lo actualiza y devuelve true y false en cualquier otro caso
        {
            bool actualizado = false;
            if (this.existeYa(v))
            {
                Persistencia.Actualizar(v);
                actualizado = true;
            }

            return actualizado;
        }


        //--------------------------------------METODOS VEHICULO SEGUNDA MANO---------------------------------------

        public bool añadir(VehiculoSegundaMano v)
        //v debe de estar inicializado
        //comprueba que no esta añadido y si no esta lo añado en caso de añadirlo devuelve true y falso en cualquier otro caso
        {
            bool añadido = false;
            if (!this.existeYa(v))
            {
                Persistencia.Añadir(v);
                añadido = true;
            }
            return añadido;
        }

        private bool existeYa(VehiculoSegundaMano v)
        {
            return Persistencia.Existe(v);
        }

        public bool eliminar(VehiculoSegundaMano v)
        //v debe de estar incializado
        //comprueba que existe y si es asi lo borra y devuelve true y en cualquier otro caso false
        {
            bool eliminar = false;
            if (this.existeYa(v))
            {
                Persistencia.Borrar(v);
            }
            return eliminar;
        }

        public String getMatricula(VehiculoSegundaMano v)
        {
            return v.Matricula;
        }
        public DateTime getFechaMatriculacion(VehiculoSegundaMano v)
        {
            return v.FechaMatriculacion;
        }


        public VehiculoSegundaMano buscar(VehiculoSegundaMano v)
            //v debe de estar incializado
            //en caso de existir lo busca y lo devuelve y si no existe devuelve null
        {
            VehiculoSegundaMano dev = null;
            if (this.existeYa(v))
            {
                Persistencia.Buscar(v);
            }
            return dev;
        }

        public bool actualizar(VehiculoSegundaMano v)
            //v debe de estar incializado y debe contener los datos actualizados del vehiculo que se quiere actualizar(tienen en mismo numBatidor)
            //comprueba que existe un coche con dicho numBastidor y si es asi lo actualiza y devuelve true y false en cualquier otro caso
        {
            bool actualizado = false;
            if(this.existeYa(v))
            {
                Persistencia.Actualizar(v);
                actualizado = true;
            }

            return actualizado;
        }

    }
}
