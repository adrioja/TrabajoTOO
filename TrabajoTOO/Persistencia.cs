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
                    BD.InsertVNuevo_Extra(new VNuevoExtrasDatos(new VNuevoExtrasClave(v.NumBastidor, e.Nombre)));
                }
            }
        }
        public static void Borrar(VehiculoNuevo v)
        {
            
            VNuevoDatos v1 = new VNuevoDatos(v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.PvRecomendado);
            BD.DeleteVNuevos(v1);
        }
        public static VNuevoDatos Buscar(VehiculoNuevo v1)
        {
            VNuevoDatos v = new VNuevoDatos(v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            return BD.SelectVNuevo(v);
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
        public static VSegundaManoDatos Buscar(VehiculoSegundaMano v1)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion, v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            return BD.SelectVSegundaMano(v);
        }
        public static void Actualizar(VehiculoSegundaMano v1, VehiculoSegundaMano v2)
        {
            VSegundaManoDatos v = new VSegundaManoDatos(v1.Matricula, v1.FechaMatriculacion, v1.NumBastidor, v1.Marca, v1.Modelo, v1.Potencia, v1.PvRecomendado);
            VSegundaManoDatos v3 = new VSegundaManoDatos(v2.Matricula, v2.FechaMatriculacion, v2.NumBastidor, v2.Marca, v2.Modelo, v2.Potencia, v2.PvRecomendado);
            BD.UpdateVSegundaMano(v, v3);
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
        public static ExtraDatos Buscar(Extra v1)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            return BD.SelectExtra(v);
        }
        public static void Actualizar(Extra v1, Extra v2)
        {
            ExtraDatos v = new ExtraDatos(v1.Nombre, v1.PrecioFijo);
            ExtraDatos v3 = new ExtraDatos(v2.Nombre, v2.PrecioFijo);
            BD.UpdateExtra(v, v3);
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

            /*ClienteDatos cliente = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            if (BD.SelectCliente(cliente) != null)
            {
                ClienteDatos datosClienteNuevo = BD.SelectCliente(cliente);
                
                CategoriaCliente categoria;
                if (datosClienteNuevo.Categoria=="A")
                {
                    categoria = CategoriaCliente.A;
                } else if (datosClienteNuevo.Categoria == "B")
                {
                    categoria = CategoriaCliente.B;
                } else 
                {
                    categoria = CategoriaCliente.C;
                }
                Cliente clienteNuevo =new Cliente(datosClienteNuevo.DNI,datosClienteNuevo.Nombre, datosClienteNuevo.Telefono, categoria);
                return clienteNuevo;
            }
            else return null;*/

            ClienteDatos cliente = new ClienteDatos(c.DNI, c.Nombre, c.Telefono, c.Categoria.ToString());
            return BD.SelectCliente(cliente);

        }
        public static void Actualizar(Cliente c1, Cliente c2)
        {
            ClienteDatos clienteViejo = new ClienteDatos(c1.DNI, c1.Nombre, c1.Telefono, c1.Categoria.ToString());
            ClienteDatos clienteNuevo = new ClienteDatos(c2.DNI, c2.Nombre, c2.Telefono, c2.Categoria.ToString());
            BD.UpdateCliente(clienteViejo, clienteNuevo);
        }

        //------------------------------------------------PRESUPUESTO------------------------------------------------------------
        public static void Añadir(Presupuesto p)
        {
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado);
            BD.InsertPresupuesto(presupuesto);
        }
        public static void Borrar(Presupuesto p)
        {
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado);
            BD.DeletePresupuesto(presupuesto);
        }
        public static PresupuestosDato Buscar(Presupuesto p)
        {
            PresupuestosDato presupuesto = new PresupuestosDato(p.Id, p.ClienteAsociado.DNI, p.FechaRealizacion, p.Estado);
            return BD.SelectPresupuesto(presupuesto);
        }
        public static void Actualizar(Presupuesto p1, Presupuesto p2)
        {
            PresupuestosDato presupuestoViejo = new PresupuestosDato(p1.Id, p1.ClienteAsociado.DNI, p1.FechaRealizacion, p1.Estado);
            PresupuestosDato presupuestoNuevo = new PresupuestosDato(p2.Id, p2.ClienteAsociado.DNI, p2.FechaRealizacion, p2.Estado);
            BD.UpdatePresupuesto(presupuestoViejo, presupuestoNuevo);
        }
    }
}
