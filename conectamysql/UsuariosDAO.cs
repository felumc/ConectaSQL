using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace conectasql
{
    public class UsuariosDAO
    {

        public static int Agregar(Usuarios Usuario)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand(string.Format("Insert into usuarios (usuario, passwd, estado,tipo_usuario) values ('{0}','{1}','{2}', '{3}')",
            Usuario.Usuario, Usuario.Passwd, Usuario.Estado, Usuario.Tipo_usuario), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            BDCon.CerrarConexion();
            return retorno;
        }
        public static string Consultar()
        {
            string retorno = "";
            string cadena = "select usuario from usuarios";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                retorno = retorno + "-" + registros["usuario"].ToString();
            }
            return retorno;
        }
        public static int Eliminar(Usuarios Usuario) {
            int retorno = 0;
            string cadena = "Delete from usuarios where usuario='" + Usuario.Usuario + "'";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static string Consultar2(Usuarios Usuario)
        {
            string retorno = "";
            string cadena = "select passwd,estado,tipo_usuario from usuarios where usuario='" + Usuario.Usuario + "'";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                retorno = registros["passwd"].ToString() + "-" + registros["estado"].ToString() + "-" + registros["tipo_usuario"].ToString();
            }
            return retorno;
        }
        public static string Consultar3()
        {
            string retorno = "";
            string cadena = "select * from usuarios";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                retorno = retorno+ registros["usuario"].ToString()+"-"+registros["passwd"].ToString() + "-" + registros["estado"].ToString() + "-" + registros["tipo_usuario"].ToString()+"-"+Environment.NewLine;
            }
            return retorno;
        }
        public static int Modificar(Usuarios Usuario)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand(string.Format("Update usuarios set  passwd='{0}', estado='{1}',tipo_usuario='{2}' Where usuario='{3}'",
            Usuario.Passwd, Usuario.Estado, Usuario.Tipo_usuario, Usuario.Usuario), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno; 
        }
    }
}
