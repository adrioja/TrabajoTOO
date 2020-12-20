using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modeloDominio;

namespace TrabajoTOO
{
    public class Persistencia
    {
        public Persistencia() { }

        //------------------------------------------METODOS VARIOS---------------------------------------------
        /// <summary>
        /// Devuelve la lista de todos los vehiculos que posee el concesionario
        /// </summary>
        /// <returns></returns>
        public static List<Vehiculo> listaVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            int tam = BD.Vehiculos.Count;
            for(int i=0;i<tam;i++)
            {
                VehiculoDatos v = BD.Vehiculos[i];
                Vehiculo v1 = new VehiculoNuevo(v.NumBastidor, v.Potencia, v.Modelo, v.Marca, v.PvRecomendado);
                lista.Add(v1);
            }
            return lista;
        }


        /// <summary>
        /// Devuelve la lista de todos los vehiculos nuevos que posee el concesionario
        /// </summary>
        /// <returns></returns>
        public static List<VehiculoNuevo> listaVehiculosNuevos()
        {
            List<VehiculoNuevo> lista = new List<VehiculoNuevo>();
            int tam = BD.VNuevos.Count;
            for (int i = 0; i < tam; i++)
            {
                VNuevoDatos v = BD.VNuevos[i];
                VehiculoNuevo v1 = new VehiculoNuevo(v.NumBastidor, v.Potencia, v.Modelo, v.Marca, v.PvRecomendado);
                lista.Add(v1);
            }
            return lista;
        }

        /// <summary>
        /// Devuelve la lista de todos los vehiculos de segunda mano que posee el concesionario
        /// </summary>
        /// <returns></returns>
        public static List<VehiculoSegundaMano> listaVehiculosSegundaMano()
        {
            List<VehiculoSegundaMano> lista = new List<VehiculoSegundaMano>();
            int tam = BD.VSegundaMano.Count;
            for (int i = 0; i < tam; i++)
            {
                VSegundaManoDatos v = BD.VSegundaMano[i];
                VehiculoSegundaMano v1 = new VehiculoSegundaMano(v.NumBastidor, v.Potencia, v.Modelo, v.Marca, v.PvRecomendado,v.Matricula,v.FechaMatriculacion);
                lista.Add(v1);
            }
            return lista;
        }

        //--------------------------------------------------------------------------------------------------------
        //------------------------------------------------VEHICULO NUEVO------------------------------------------
        //--------------------------------------------------------------------------------------------------------

        /// <summary>
        /// PRE:el parametro debe de estar incializado
        /// POST: Dado un VehiculoNuevo, se añade a la BD (Sin comprobar si ya existe), (Los extras que este vehiculo tiene asociados deben de ser añadidos explicitamente antes)
        /// </summary>
        /// <param name="v"></param>
        public static void Añadir(VehiculoNuevo v)
        {           
            VNuevoDatos v1 = new VNuevoDatos(v.NumBastidor,v.Marca,v.Modelo,v.Potencia,v.PvRecomendado);
            BD.InsertVNuevos(v1);

            if (v.Extras.Count != 0)
            {
                foreach (Extra e in v.Extras)
                {
                    BD.InsertVNuevo_Extra(new VNuevoExtrasDatos(new VNuevoExtrasClave(v.NumBastidor, e.Nombre)));
                }
            }
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un VehiculoNuevo (Puede ser que solo contenga la clave), se borrara sin comprobar si existe o no, su aparicion en la bd
        /// </summary>
        /// <param name="v"></param>
        public static void Borrar(VehiculoNuevo v)
        {
            //Como el objeto que recibimos puede tener solo la clave, primero obtenemos los extras de ese vehiculo:
            VehiculoNuevo vehiculo = Persistencia.Buscar(v);
            foreach(Extra e in vehiculo.Extras) //borramos las referencias en la tabla intermedia (VehiculoExtras)
            {
                BD.DeleteVNuevo_Extra(new VNuevoExtrasDatos(new VNuevoExtrasClave(v.NumBastidor, e.Nombre)));
            }

            VNuevoDatos v1 = new VNuevoDatos(v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.PvRecomendado);
            BD.DeleteVNuevos(v1);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un VehiculoNuevo (Del que solo se utilizara la clave), obtendremos un vehiculoNuevo con todos sus campos, no se contempla el caso en el que el VehiculoNuevo no esta en la BD 
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static VehiculoNuevo Buscar(VehiculoNuevo v1)
        {
            VNuevoDatos v = new VNuevoDatos(v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            VNuevoDatos dev = BD.SelectVNuevo(v);
            return new VehiculoNuevo(dev.NumBastidor, dev.Potencia, dev.Modelo, dev.Marca, dev.PvRecomendado);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un VehiculoNuevo, se actualizara el vehiculo cuya clave coincida con v1 (No se contempla el caso en el que no existe ningun vehiculo con dicha clave), cambiando todos sus campos a los valores que trae v1
        /// </summary>
        /// <param name="v1"></param>
        public static void Actualizar(VehiculoNuevo v1)
        {
            Persistencia.Borrar(v1);
            Persistencia.Añadir(v1);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un VehiculoNuvo (Del que solo se utilizara la clave), devuelve true si existe un vehiculo nuevo cuya clave coincida con v1, false en caso contrario
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static bool Existe(VehiculoNuevo v1)
        {
            VNuevoDatos v = new VNuevoDatos(v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            return BD.ExistsVNuevo(v);
        }



        //---------------------------------------------------------------------------------------------------------------
        //------------------------------------------------VEHICULO SEGUNDA MANO------------------------------------------
        //---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un VehiculoSegundaMano, se añade a la BD (Sin comprobar si existe ya)
        /// </summary>
        /// <param name="v1"></param>
        public static void Añadir(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion,v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            BD.InsertVSegundaMano(v);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:  Dado un VehiculoSegundaMano (Puede ser que solo contenga la clave), se borrara sin comprobar si existe o no, su aparicion en la bd
        /// </summary>
        /// <param name="v1"></param>
        public static void Borrar(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion, v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            BD.DeleteVSegundaMano(v);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un VehiculoSegundaMano (Del que solo se utilizara la clave), obtendremos un VehiculoSegundaMano con todos sus campos, no se contempla el caso en el que el VehiculoSegundaMano no esta en la BD
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static VehiculoSegundaMano Buscar(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion, v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            VSegundaManoDatos dev =  BD.SelectVSegundaMano(v);
            return new VehiculoSegundaMano(dev.NumBastidor, dev.Potencia, dev.Modelo, dev.Marca, dev.PvRecomendado, dev.Matricula, dev.FechaMatriculacion);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un VehiculoSegundaMano, se actualizara el vehiculo cuya clave coincida con v ,(No se contempla el caso en el que no existe ningun vehiculo con dicha clave),cambiando todos sus campos a los valores que trae v(los actualiza)
        /// </summary>
        /// <param name="v"></param>
        public static void Actualizar(VehiculoSegundaMano v)
        {
            VSegundaManoDatos v1 = new VSegundaManoDatos(v.Matricula, v.FechaMatriculacion, v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.PvRecomendado);
            BD.UpdateVSegundaMano(v1);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un VehiculoNuvo (Del que solo se utilizara la clave), devuelve true si existe un vehiculoSegundaMano cuya clave coincida con v1, false en caso contrario
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static bool Existe(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula,v1.FechaMatriculacion,v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            return BD.ExistsVSegundaMano(v);
        }



        //----------------------------------------------------------------------------------------------------------------
        //------------------------------------------------EXTRA-----------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un Extra, se añade a la BD (Sin comprobar si existe ya) 
        /// </summary>
        /// <param name="v1"></param>
        public static void Añadir(Extra v1)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            BD.InsertExtras(v);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un Extra (Puede ser que solo contenga la clave), se borrara sin comprobar si existe o no, su aparicion en la bd
        /// </summary>
        /// <param name="v1"></param>
        public static void Borrar(Extra v1)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            BD.DeleteExtras(v);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un Extra (Del que solo se utilizara la clave), obtendremos un Extra con todos sus campos, no se contempla el caso en el que el Extra no esta en la BD
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Extra Buscar(Extra v1)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            ExtraDatos dev = BD.SelectExtra(v);
            return new Extra(dev.Nombre, dev.PrecioFijo);
        }


        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un Extra, se actualizara el extra cuya clave coincida con e (no se contempla el caso en el que no existe ningun extra con dicha clave), cambiando todos sus campos a los valores que trae e
        /// </summary>
        /// <param name="e"></param>
        public static void Actualizar(Extra e)
        {
            ExtraDatos v = new ExtraDatos(e.Nombre, e.PrecioFijo);
            BD.UpdateExtra(v);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un Extra (Del que solo se utilizara la clave), devuelve true si existe un extra cuya clave coincida con e, false en caso contrario
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool Existe(Extra e)
        {
            ExtraDatos ed = new ExtraDatos(e.Nombre, e.PrecioFijo);
            return BD.ExistsExtra(ed);
        }



        //-------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------CLIENTE------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un Cliente, se añade a la BD (Sin comprobar si existe ya)
        /// </summary>
        /// <param name="c"></param>
        public static void Añadir(Cliente c)
        {
            ClienteDatos cliente = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            BD.InsertCliente(cliente);
        }


        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un Cliente (Puede ser que solo contenga la clave), se borrara sin comprobar si existe o no, su aparicion en la bd
        /// </summary>
        /// <param name="c"></param>
        public static void Borrar(Cliente c)
        {
            ClienteDatos cliente = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            BD.DeleteCliente(cliente);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un Cliente (Del que solo se utilizara la clave), obtendremos un Cliente con todos sus campos, no se contempla el caso en el que el Cliente no esta en la BD
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Cliente Buscar(Cliente c)
        {
            ClienteDatos cliente = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            ClienteDatos dev = BD.SelectCliente(cliente) ;
            CategoriaCliente categoria;
            if (dev.Categoria == "A")
            {
                categoria = CategoriaCliente.A;
            }
            else if (dev.Categoria == "B")
            {
                categoria = CategoriaCliente.B;
            }
            else
            {
                categoria = CategoriaCliente.C;
            }

            return new Cliente(dev.DNI, dev.Nombre, dev.Telefono, categoria);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST: Dado un Cliente, se actualizara el cliente cuya clave coincida con c (no se contempla el caso en el que no existe ningun cliente con dicha clave),cambiando todos sus campos a los valores que trae c 
        /// </summary>
        /// <param name="c"></param>
        public static void Actualizar(Cliente c)
        {
            ClienteDatos c1 = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            BD.UpdateCliente(c1);
        }

        /// <summary>
        /// PRE:la clase que se pasa como parametro debe de estar incializada
        /// POST:Dado un Cliente (Del que solo se utilizara la clave), devuelve true si existe un cliente cuya clave coincida con c, false en caso contrario
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool Existe(Cliente c)
        {
            ClienteDatos cd = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            return BD.ExistsCliente(cd);
        }



        //-----------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------PRESUPUESTO------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------
        public static void Añadir(Presupuesto p)
            /* Dado un Presupuesto, se añade a la BD (Sin comprobar si existe ya).
             * Se añade tambien a la tabla presupuestoVehiculo las filas correspondientes
             * dando por echo que los vehiculos asociados ya se encuentran en la bd.
             * (Se da por echo tambien que el cliente asociado y el vehiculo comprado ya existen en la bd)*/
        {
            String vehiculoComprado;
            if (p.VehiculoComprado ==null)
            {
                vehiculoComprado = "";
            } else
            {
                vehiculoComprado = p.VehiculoComprado.NumBastidor;
            } 

            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado, p.VehiculoComprado.NumBastidor);
            BD.InsertPresupuesto(presupuesto);

            if (p.Vehiculos.Count != 0)
            {
                foreach (Vehiculo e in p.Vehiculos)
                {
                    //no comprobamos si los vehiculos estan porque solo se pueden hacer presupuestos de vehiculos que ya están en la bd
                    BD.InsertPresupuesto_Vehiculos(new Presupuesto_VehiculosDato(new Presupuesto_VehiculoClave(p.Id, e.NumBastidor)));
                }
            }
        }
        public static void Borrar(Presupuesto p)
            /* Dado un Presupuesto (Puede ser que solo contenga la clave), se borrara sin comprobar si existe o no, 
            * su aparicion en la bd.
            * Se borran tambien las filas de presupuestoVehiculo*/
        {
            foreach (Vehiculo v in p.Vehiculos) //borramos las referencias en la tabla intermedia
            {
                BD.DeletePresupuesto_Vehiculos(new Presupuesto_VehiculosDato(new Presupuesto_VehiculoClave(p.Id, v.NumBastidor)));
            }
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado, ""); //Solo nos interesa la clave
            BD.DeletePresupuesto(presupuesto);

        }
        public static Presupuesto Buscar(Presupuesto p)
            /* Dado un Presupuesto (Del que solo se utilizara la clave), obtendremos un Presupuesto con todos sus campos,
            * no se contempla el caso en el que el presupuesto no esta en la BD*/
        {
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado, ""); //Solo nos interesa la clave
            PresupuestosDato dev =  BD.SelectPresupuesto(presupuesto);

            //Cliente asociado:
            Cliente c = Persistencia.Buscar(new Cliente(dev.Cliente));
            
            //Vehiculo comprado:
            Vehiculo vehiculoComprado;
            if(dev.VehiculoComprado!= "")
            {
                vehiculoComprado = null;
            } else
            {
                if (Persistencia.Existe(new VehiculoNuevo(dev.VehiculoComprado))) {
                    //Se trata de un vehiculo nuevo:
                    vehiculoComprado = Persistencia.Buscar(new VehiculoNuevo(dev.VehiculoComprado));
                }
                else
                {
                    //Se trata de un vehiculo de segunda mano:
                    vehiculoComprado = Persistencia.Buscar(new VehiculoSegundaMano(dev.VehiculoComprado));
                }
            }

            //Lista de vehiculos: 
            List<Vehiculo> l = new List<Vehiculo>();
            Presupuesto_VehiculosTabla t = BD.Presupuesto_vehiculos;
            int tam = t.Count();
            for(int i=0;i<tam; i++)
            {
                Presupuesto_VehiculosDato pv = t[i]; //vamos cogiendo elemento a elemento y miramos si coincide el id para si eso agregarlo a la lista
                if(pv.Clave.Id.Equals(p.Id))
                {
                    Vehiculo vehiculoActual;
                    if (Persistencia.Existe(new VehiculoNuevo(pv.Clave.Vehiculo))) {
                        //Se trata de un vehiculo nuevo:
                        vehiculoActual = Persistencia.Buscar(new VehiculoNuevo(pv.Clave.Vehiculo));
                    }
                    else
                    {
                        //Se trata de un vehiculo de segunda mano:
                        vehiculoActual = Persistencia.Buscar(new VehiculoSegundaMano(pv.Clave.Vehiculo));
                    }
                    l.Add(vehiculoActual);
                }

            }
            
            return new Presupuesto(dev.Id, c, dev.FechaRealizacion, dev.Estado, l, vehiculoComprado);
        }
        public static void Actualizar(Presupuesto p)
            /* Dado un Presupuesto, se actualizara el presupuesto cuya clave coincida con p 
            * (No se contempla el caso en el que no existe ningun presupuesto con dicha clave),
            * cambiando todos sus campos a los valores que trae p (Incluso la lista de vehiculos asociados)*/
        {
            Persistencia.Borrar(p);
            Persistencia.Añadir(p);
        }
        public static bool Existe(Presupuesto p)
            /* Dado un Cliente (Del que solo se utilizara la clave), devuelve true si existe un cliente cuya
             * clave coincida con c, false en caso contrario */
        {
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado, ""); //Solo nos interesa la clave
            return BD.ExistsPresupuesto(presupuesto);
        }
    }
}
