using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolas.Data
{
    public class Conexión
    {
        public static string Cn = "Data Source = ETHANDÁVILA ;Initial Catalog = Consolas; Integrated Security = True";
        public static SqlConnection Conexion = new SqlConnection(Cn);
    }
}
