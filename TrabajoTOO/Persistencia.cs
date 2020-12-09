using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class Persistencia
    {
        static string conexion = "Data Source=localhost; Integrated Security=SSPI;Initial Catalog=Concesionario";
        static SqlConnection cn = new SqlConnection(conexion);
        static SqlTransaction t;


    }
}
