using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Presentacion
{
    class Conexiones
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-PT9RLI7S;DATABASE=BD_PLANILLA;integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
