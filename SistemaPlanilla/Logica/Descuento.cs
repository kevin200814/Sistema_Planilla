using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Descuento : Conexion
    {
        private int id_descuentos;
        private string tipo_descuento;
        private string descripcion_descuento;
        private float porcentaje_descuento;

        public int Id_descuentos
        {
            get { return id_descuentos; }
            set { id_descuentos = value; }
        }

        public string Tipo_descuento
        {
            get { return tipo_descuento; }
            set { tipo_descuento = value; }
        }

        public string Descripcion_descuento
        {
            get { return descripcion_descuento; }
            set { descripcion_descuento = value; }
        }

        public float Porcentaje_descuento
        {
            get { return porcentaje_descuento; }
            set { porcentaje_descuento = value; }
        }

        public bool InsertarDescuento()
        { 
        string cadenaSQLInsertar = "INSERT INTO TBL_DESCUENTOS (tipo_descuento, descripcion_descuento, porcentaje_descuento ) VALUES('" + this.tipo_descuento + "','" + this.descripcion_descuento + "'," + this.porcentaje_descuento + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLInsertar);
            return respuestaSQL;
        }

        public DataSet ConsultarDescuentos(int id)
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_DESCUENTOS WHERE ID_DESCUENTOS= " + id + "";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }

        public DataSet ConsultarTodosDescuentos()
        {
            string cadenaSQLConsultar = "SELECT * FROM TBL_DESCUENTOS";
            DataSet ConsultarResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultarResultante;
        }

        public bool ActualizarDescuentos()
        {
            string cadenaSQLActualizar = "UPDATE TBL_DESCUENTOS SET tipo_descuento = '" + this.tipo_descuento + "', descripcion_descuento = '" + this.descripcion_descuento + "', porcentaje_descuento = '" + this.porcentaje_descuento + "' WHERE (ID_DESCUENTOS= " + this.id_descuentos + ")";
            bool respuestaSQL = EjecutarSQL(cadenaSQLActualizar);
            return respuestaSQL;
        }

        public bool EliminarDescuentos(string id)
        {
            string cadenaSQLElininar = "DELETE FROM TBL_DESCUENTOS WHERE ID_DESCUENTOS = " + id + "";
            bool respuestaSQL = EjecutarSQL(cadenaSQLElininar);
            return respuestaSQL;
        }

    }
}
