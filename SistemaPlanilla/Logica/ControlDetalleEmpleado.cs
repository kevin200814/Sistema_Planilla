using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ControlDetalleEmpleado : Conexion
    {
        private int ID_DETALLE;
        private int NUM_CARNET;
        private float BONO_EMPLEADO;
        private float PERMISO_CON_SUELDO; 
        private int HORAS_EXTRAS;
        private int DIAS_EXTRAS;

        public int id_detalle
        {
            get { return ID_DETALLE; }
            set { ID_DETALLE = value; }
        }

        public int Carnet
        {
            get { return NUM_CARNET; }
            set { NUM_CARNET = value; }
        }

        public float Bono
        {
            get { return BONO_EMPLEADO; }
            set { BONO_EMPLEADO = value; }
        }

        public float Permiso
        {
            get { return PERMISO_CON_SUELDO; }
            set { PERMISO_CON_SUELDO = value; }
        }

        public int Horas_extras
        {
            get { return HORAS_EXTRAS; }
            set { HORAS_EXTRAS = value; }
        }

        public int Dias_extras
        {
            get { return DIAS_EXTRAS; }
            set { DIAS_EXTRAS = value; }
        }

        public bool InsertarDetalle()
        {
            string cadenaSQLInsertar = "INSERT INTO TBL_DETALLE_EMPLEADO (NUM_CARNET, BONO_EMPLEADO, PERMISO_CON_SUELDO, HORAS_EXTRAS, DIAS_EXTRAS ) VALUES(" + this.Carnet + "," + this.Bono + "," + this.Permiso + "," + this.Horas_extras + "," + this.Dias_extras + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        public DataSet ConsultarDetalle(int id)
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_DETALLE_EMPLEADO WHERE ID_DETALLE = " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        public DataSet ConsultarTodosDetalle()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_DETALLE_EMPLEADO";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        public bool ActualizarDetalle()
        {
            string cadenaSQLActualizar = "UPDATE TBL_DETALLE_EMPLEADO SET NUM_CARNET = '" + this.Carnet + "',PERMISO_CON_SUELDO='" + this.Permiso + "',HORAS_EXTRAS='" + this.Horas_extras + "',DIAS_EXTRAS='" + this.Dias_extras + "' WHERE (ID_DETALLE= " + this.id_detalle + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }
        public bool EliminarDetalle(int id)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_DETALLE_EMPLEADO WHERE ID_DETALLE = " + id + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }
    }
}
