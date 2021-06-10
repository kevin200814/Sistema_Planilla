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
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=BD_PLANILLA;Integrated Security=True");
            cn.Open();
            return cn;
        }
    }
}
