using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Horas : Conexion
    {
        private int id_horas;
        private int num_carnet;
        private string fecha_entrada;
        private string fecha_salida;

        public int Id_horas 
        {
            get { return id_horas; }
            set { id_horas = value; }
        }

        public int Num_carnet
        {
            get { return num_carnet; }
            set { num_carnet = value; }
        }

        public string Fecha_Entrada
        {
            get { return fecha_entrada; }
            set { fecha_entrada = value; }
        }

        public string Fecha_Salida
        {
            get { return fecha_salida; }
            set { fecha_salida = value; }
        }

        public bool InsertarHoras()
        {
            string cadenaSQLInsertar = "INSERT INTO TBL_HORAS (num_carnet, fecha_entrada, fecha_salida )  VALUES('" + this.num_carnet + "','" + this.fecha_entrada + "'," + this.fecha_salida + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }
        public DataSet ConsultarHoras(int id)
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_HORAS WHERE ID_HORAS= " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        public DataSet ConsultarTodosHoras()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_HORAS";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public bool ActualizarHoras()
        {
            string cadenaSQLActualizar = "UPDATE TBL_HORAS SET num_carnet = '" + this.num_carnet + "', fecha_entrada = '" + this.fecha_entrada + "', fecha_salida = '" + this.fecha_salida + "' WHERE (ID_HORAS= " + this.id_horas + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }

        public bool EliminarHoras(string id)
        {
            string cadenaSQLElininar = "DELETE FROM TBL_HORAS WHERE ID_HORAS = " + id+"";
            bool respuestaSQL = EjecutarSQL(cadenaSQLElininar);
            return respuestaSQL;
        }
    }
}
