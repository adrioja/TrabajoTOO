using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    public class Persistencia
    {
        public Persistencia() { }
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
        //--------------------------------------------------------------------------------------------------
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
        //--------------------------------------------------------------------------------------------------
        //------------------------------------------------EXTRA------------------------------------------
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
        //--------------------------------------------------------------------------------------------------
    }
}
