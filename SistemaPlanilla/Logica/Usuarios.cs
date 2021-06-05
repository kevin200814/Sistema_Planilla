using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
   public class Usuarios : Conexion
    {
        private int id_usuario;
        private string usuario;
        private string contrasena;
        private int id_rol;
        private string nombre_rol;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public int Id_rol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }

        public string Nombre_rol
        {
            get { return nombre_rol; }
            set { nombre_rol = value; }
        }

        public DataSet Login(string user, string pass)
        {
            string cadenaSQLConsultar = $"SELECT U.NICK_USUARIO, U.CONTRASENA_USUARIO,R.ACCESO_ROL FROM TBL_USUARIO U INNER JOIN TBL_ROL R ON R.ID_ROL = U.ID_ROL WHERE NICK_USUARIO = '{user}' AND CONTRASENA_USUARIO = '{pass}'";
            DataSet ConsultaResultante = ConsultarSQL(cadenaSQLConsultar);
            return ConsultaResultante;
        }
    }
}
