using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ControlDetalleEmpleado
    {
        private int NUM_CARNET;
        private float BONO_EMPLEADO;
        private float PERMISO_CON_SUELDO;
        private int HORAS_EXTRAS;
        private DateTime DIAS_EXTRAS;

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

        public DateTime Dias_extras
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
    }
}
