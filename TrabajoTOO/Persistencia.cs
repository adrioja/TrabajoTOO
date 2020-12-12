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
        public static void Añadir(VNuevoDatos v)
        {
            BD.InsertVNuevos(v);
        }
        public static void Borrar(VNuevoDatos v)
        {
            BD.DeleteVNuevos(v);
        }
        public static VNuevoDatos Buscar(VNuevoDatos v)
        {
            return BD.SelectVNuevo(v);
        }
        public static void Actualizar(VNuevoDatos v)
        {
            //Falta
        }
        //---------------------------------------------------------------------------------------------------------------
        //------------------------------------------------VEHICULO SEGUNDA MANO------------------------------------------
        public static void Añadir(VSegundaManoDatos v)
        {
            BD.InsertVSegundaMano(v);
        }
        public static void Borrar(VSegundaManoDatos v)
        {
            BD.DeleteVSegundaMano(v);
        }
        public static VSegundaManoDatos Buscar(VSegundaManoDatos v)
        {
            return BD.SelectVSegundaMano(v);
        }
        public static void Actualizar(VSegundaManoDatos v)
        {
            //Falta
        }
        //----------------------------------------------------------------------------------------------------------------
        //------------------------------------------------EXTRA-----------------------------------------------------------
        public static void Añadir(ExtraDatos v)
        {
            BD.InsertExtras(v);
        }
        public static void Borrar(ExtraDatos v)
        {
            BD.DeleteExtras(v);
        }
        public static ExtraDatos Buscar(ExtraDatos v)
        {
            return BD.SelectExtra(v);
        }
        public static void Actualizar(ExtraDatos v)
        {
            //Falta
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
            else return null;
        }
        public static void Actualizar(Cliente c1, Cliente c2)
        {
            ClienteDatos clienteViejo = new ClienteDatos(c1.DNI, c1.Nombre, c1.Telefono, c1.Categoria.ToString());
            ClienteDatos clienteNuevo = new ClienteDatos(c2.DNI, c2.Nombre, c2.Telefono, c2.Categoria.ToString());

            if (c1.Equals(c2))
            {
                BD.UpdateCliente(clienteViejo, clienteNuevo);
            }
        }
    }
}
