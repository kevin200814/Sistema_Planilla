using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class ControlEmpleado : Conexion
    {
        private int idEmpleado;
        private int num_carnet;
        private string nombres;
        private string apellidos;
        private int edad;
        private string sexo;
        private int idusuario;
        private int idcargo;
        private int idhorario;
        private int iddetalle;


        public int ID_EMPLEADO 
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public int NUM_CARNET
        {
            get { return num_carnet; }
            set { num_carnet = value; }
        }

        public string NOMBRES_EMPLEADO
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string APELLIDOS_EMPLEADO
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public int EDAD_EMPLEADO 
        {
            get { return edad; }
            set { edad = value; }
        }

        public string SEXO_EMPLEADO 
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int ID_USUARIO 
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public int ID_CARGO 
        {
            get { return idcargo; }
            set { idcargo = value; }
        }

        public int ID_HORARIO 
        {
            get { return idhorario; }
            set { idhorario = value; }
        }
        public int ID_DETALLE 
        {
            get { return iddetalle; }
            set { iddetalle = value; }
        }

        public bool InsertarEmpleado()
        {
            string cadenaSQLInsertar = $"INSERT INTO TBL_EMPLEADO(NUM_CARNET, NOMBRES_EMPLEADO, APELLIDOS_EMPLEADO, EDAD_EMPLEADO, SEXO_EMPLEADO, ID_USUARIO, ID_CARGO, ID_HORARIO, ID_DETALLE) VALUES ('{NUM_CARNET}','{NOMBRES_EMPLEADO}','{APELLIDOS_EMPLEADO}','{EDAD_EMPLEADO}','{SEXO_EMPLEADO}','{ID_USUARIO}','{ID_CARGO}','{ID_HORARIO}','{ID_DETALLE}')";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        public DataSet ConsultarTodosEmpleados()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_EMPLEADO";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public DataSet ConsultarEmpleado(int idEmpleado)
        {
            string cadenaSQLConsultar = $"SELECT * FROM TBL_EMPLEADO WHERE ID_EMPLEADO = {idEmpleado}";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public bool ActualizarEmpleado()
        {
            string cadenaSQLInsertar = $"UPDATE TBL_EMPLEADO SET NUM_CARNET = '{NUM_CARNET}',NOMBRES_EMPLEADO = '{NOMBRES_EMPLEADO}',APELLIDOS_EMPLEADO = '{APELLIDOS_EMPLEADO}',EDAD_EMPLEADO = '{EDAD_EMPLEADO}',SEXO_EMPLEADO = '{SEXO_EMPLEADO}',ID_USUARIO = '{ID_USUARIO}',ID_CARGO = '{ID_CARGO}',ID_HORARIO = '{ID_HORARIO}',ID_DETALLE = '{ID_DETALLE}' WHERE ID_EMPLEADO = '{ID_EMPLEADO}'";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        public bool EliminarEmpleado(int idEmpleado)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_EMPLEADO WHERE ID_EMPLEADO = " + idEmpleado + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }

        public DataSet ConsultarTodosUsuarios()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_USUARIO";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public DataSet ConsultarTodosCargos()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_CARGO";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public DataSet ConsultarTodosDetalles()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_DETALLE_EMPLEADO";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }
    }
}
