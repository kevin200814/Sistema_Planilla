using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class ControlHorario : Conexion
    {
        private int idHorario;
        private string tipo_horario;
        private string hora_inicio;
        private string hora_final;

        public int ID_HORARIO 
        {
            get { return idHorario; }
            set { idHorario = value; }
        }

        public string TIPO_HORARIO
        {
            get { return tipo_horario; }
            set { tipo_horario = value; }
        }

        public string HORA_INICIO
        {
            get { return hora_inicio; }
            set { hora_inicio = value; }
        }

        public string HORA_FINAL
        {
            get { return hora_final; }
            set { hora_final = value; }
        }


        public bool InsertarHorario()
        {
            string cadenaSQLInsertar = $"INSERT INTO TBL_HORARIO (TIPO_HORARIO,HORA_INICIO,HORA_FINAL) VALUES ('{TIPO_HORARIO}','{HORA_INICIO}','{HORA_FINAL}')";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        public DataSet ConsultarTodosHorarios()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_HORARIO";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public DataSet ConsultarHorario(string idHorario)
        {
            string cadenaSQLConsultar = $"SELECT * FROM TBL_HORARIO WHERE ID_HORARIO = '{idHorario}'";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public bool ActualizarHorario()
        {
            string cadenaSQLInsertar = $"UPDATE TBL_HORARIO SET TIPO_HORARIO = '{TIPO_HORARIO}',HORA_INICIO = '{HORA_INICIO}',HORA_FINAL = '{HORA_FINAL}' WHERE ID_HORARIO = '{ID_HORARIO}'";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        public bool EliminarHorario(int idHorario)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_HORARIO WHERE ID_HORARIO = " + idHorario + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }
    }
}
