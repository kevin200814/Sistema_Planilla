using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ControlCargo : Conexion
    {
        private string NOMBRE_CARGO;
        private string TIPO_PAGO;
        private float SALARIO_CARGO;
        private float PAGO_DIURNO;
        private float PAGO_NOCTURNO;

       

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
    }
}
