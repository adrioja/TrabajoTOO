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
        //--------------------------------------------------------------------------------------------------------
        //------------------------------------------------VEHICULO NUEVO------------------------------------------
        public static void Añadir(VehiculoNuevo v)
        {           
            VNuevoDatos v1 = new VNuevoDatos(v.NumBastidor,v.Marca,v.Modelo,v.Potencia,v.PvRecomendado);
            BD.InsertVNuevos(v1);

            if (v.Extras.Count != 0)
            {
                foreach (Extra e in v.Extras)
                {
                    /*ExtraDatos dato = new ExtraDatos(e.Nombre, e.PrecioFijo);
                    //miramos si los extras estan en la tabla extra sino lo añadimos
                    if(BD.SelectExtra(dato) == null)
                    {
                        BD.InsertExtras(dato);
                    }*/                                                                     //nose si ponerlo podemos exigir que no se pueda mas que con extras que esten ya registrados
                    //--------------------------------------------------------------
                    BD.InsertVNuevo_Extra(new VNuevoExtrasDatos(new VNuevoExtrasClave(v.NumBastidor, e.Nombre)));
                }
            }
        }
        public static void Borrar(VehiculoNuevo v)
        {
            foreach(Extra e in v.Extras) //borramos las referencias en la tabla intermedia
            {
                BD.DeleteVNuevo_Extra(new VNuevoExtrasDatos(new VNuevoExtrasClave(v.NumBastidor, e.Nombre)));
            }

            VNuevoDatos v1 = new VNuevoDatos(v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.PvRecomendado);
            BD.DeleteVNuevos(v1);
        }
        public static VehiculoNuevo Buscar(VehiculoNuevo v1)
        {
            VNuevoDatos v = new VNuevoDatos(v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            VNuevoDatos dev = BD.SelectVNuevo(v);
            return new VehiculoNuevo(dev.NumBastidor, dev.Potencia, dev.Modelo, dev.Marca, dev.PvRecomendado);
        }
        public static void Actualizar(VehiculoNuevo v1)
        {
            VNuevoDatos v = new VNuevoDatos(v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            BD.UpdateVNuevo(v);
        }

        public static bool Existe(VehiculoNuevo v1)
        {
            VNuevoDatos v = new VNuevoDatos(v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            return BD.ExistsVNuevo(v);
        }
        //---------------------------------------------------------------------------------------------------------------
        //------------------------------------------------VEHICULO SEGUNDA MANO------------------------------------------
        public static void Añadir(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion,v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            BD.InsertVSegundaMano(v);
        }
        public static void Borrar(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion, v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            BD.DeleteVSegundaMano(v);
        }
        public static VehiculoSegundaMano Buscar(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion, v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            VSegundaManoDatos dev =  BD.SelectVSegundaMano(v);
            return new VehiculoSegundaMano(dev.NumBastidor, dev.Potencia, dev.Modelo, dev.Marca, dev.PvRecomendado, dev.Matricula, dev.FechaMatriculacion);
        }
        public static void Actualizar(VehiculoSegundaMano v)
        {
            VSegundaManoDatos v1 = new VSegundaManoDatos(v.Matricula, v.FechaMatriculacion, v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.PvRecomendado);
            BD.UpdateVSegundaMano(v1);
        }
        //----------------------------------------------------------------------------------------------------------------
        //------------------------------------------------EXTRA-----------------------------------------------------------
        public static void Añadir(Extra v1)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            BD.InsertExtras(v);
        }
        public static void Borrar(Extra v1)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            BD.DeleteExtras(v);
        }
        public static Extra Buscar(Extra v1)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            ExtraDatos dev = BD.SelectExtra(v);
            return new Extra(dev.Nombre, dev.PrecioFijo);
        }
        public static void Actualizar(Extra e)
        {
            ExtraDatos v = new ExtraDatos(e.Nombre, e.PrecioFijo);
            BD.UpdateExtra(v);
        }
        //-------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------CLIENTE------------------------------------------------------------
        public static void Añadir(Cliente c)
        {
            ClienteDatos cliente = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            BD.InsertCliente(cliente);
        }
        public static void Borrar(Cliente c)
        {
            ClienteDatos cliente = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            BD.DeleteCliente(cliente);
        }
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
        public static void Actualizar(Cliente c)
        {
            ClienteDatos c1 = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            BD.UpdateCliente(c1);
        }

        //------------------------------------------------PRESUPUESTO------------------------------------------------------------
        public static void Añadir(Presupuesto p)
        {
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado);
            BD.InsertPresupuesto(presupuesto);

            if (p.Vehiculos.Count != 0)
            {
                foreach (Vehiculo e in p.Vehiculos)
                {
                    //no comprobamos si los vehiculos estan porque solo se pueden hacer presupuestos de vehiculos que se poseen
                    BD.InsertPresupuesto_Vehiculos(new Presupuesto_VehiculosDato(new Presupuesto_VehiculoClave(p.Id, e.NumBastidor)));
                }
            }
        }
        public static void Borrar(Presupuesto p)
        {

            foreach (Vehiculo v in p.Vehiculos) //borramos las referencias en la tabla intermedia
            {
                BD.DeletePresupuesto_Vehiculos(new Presupuesto_VehiculosDato(new Presupuesto_VehiculoClave(p.Id, v.NumBastidor)));
            }
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado);
            BD.DeletePresupuesto(presupuesto);

        }
        public static Presupuesto Buscar(Presupuesto p)
        {
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado);
            PresupuestosDato dev =  BD.SelectPresupuesto(presupuesto);

            //tengo que consegir vehiculos                                  //falta-------------------------------------------------------------------------

            Cliente c = Persistencia.Buscar(new Cliente(dev.Cliente));

            List<Vehiculo> l = new List<Vehiculo>();
            Presupuesto_VehiculosTabla t = BD.Presupuesto_vehiculos;
            int tam = t.Count();
            for(int i=0;i<tam; i++)
            {
                Presupuesto_VehiculosDato pv = t[i]; //vamos cogiendo elemento a elemento y miramos si coincide el id para si eso agregarlo a la lista
                if(pv.Clave.Id.Equals(p.Id))
                {
                    VehiculoDatos n = BD.SelectVehiculo(new VehiculoDatos(pv.Clave.Vehiculo, "", "", 0, 0)); //no se pueden crear instancias de vehiculo
                    Vehiculo b = new VehiculoNuevo(n.NumBastidor, n.Potencia, n.Modelo, n.Marca, n.PvRecomendado);
                    l.Add(b);
                }

            }
            


            return new Presupuesto(dev.Id, c, dev.FechaRealizacion, dev.Estado, l);
        }
        public static void Actualizar(Presupuesto p)
        {
            PresupuestosDato p1 = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado);
            BD.UpdatePresupuesto(p1);
        }
    }
}
