using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ControlCargo : Conexion
    {
        private int IDCARGO;
        private string NOMBRE_CARGO;
        private string TIPO_PAGO;
        private float SALARIO_CARGO;
        private float PAGO_DIURNO;
        private float PAGO_NOCTURNO;

        public int id_cargo
        {
            get { return IDCARGO; }
            set { IDCARGO = value; }
        }

        public string Nombre
        {
            get { return NOMBRE_CARGO; }
            set { NOMBRE_CARGO = value; }
        }

        public string Tipo_Pago
        {
            get { return TIPO_PAGO; }
            set { TIPO_PAGO = value; }
        }

        public float Salario
        {
            get { return SALARIO_CARGO; }
            set { SALARIO_CARGO = value; }
        }

        public float Pagod
        {
            get { return PAGO_DIURNO; }
            set { PAGO_DIURNO = value; }
        }

        public float PagoN
        {
            get { return PAGO_NOCTURNO; }
            set { PAGO_NOCTURNO = value; }
        }

        public bool InsertarCargo()
        {
            string cadenaSQLInsertar = "INSERT INTO TBL_CARGO (NOMBRE_CARGO, TIPO_PAGO, SALARIO_CARGO, PAGO_DIURNO, PAGO_NOCTURNO ) VALUES('" + this.Nombre + "','" + this.Tipo_Pago + "'," + this.Salario + "," + this.Pagod + "," + this.PagoN + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }


        public DataSet ConsultarCargo(int id)
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_CARGO WHERE ID_CARGO = " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        public DataSet ConsultarTodosCargo()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_CARGO";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
        public bool ActualizarCargo()
        {
            string cadenaSQLActualizar = "UPDATE TBL_CARGO SET NOMBRE_CARGO = '" + this.Nombre + "', TIPO_PAGO = '" + this.Tipo_Pago + "',SALARIO_CARGO='" + this.Salario + "',PAGO_DIURNO='" + this.Pagod + "',PAGO_NOCTURNO='" + this.PagoN + "' WHERE (ID_CARGO= " + this.id_cargo + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }
        public bool EliminarCargo(int id)
        {
            string cadenaSQLEliminar = "DELETE FROM TBL_CARGO WHERE ID_CARGO = " + id + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLEliminar);
            return respuestaSQL;
        }

    }
}
