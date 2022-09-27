using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectasql
{
    public class TrabajadorDAO
    {
        public static int Agregar_Trabajador(Trabajador Trabajador)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand(string.Format("Insert into trabajador (nombre,apellido_pat,apellido_mat,direccion,telefono,num_empleado,id_usuario,id_puesto) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','{7}')",
            Trabajador.Nombre,Trabajador.Ape_pat,Trabajador.Ape_mat,Trabajador.Direccion,Trabajador.Telefono,Trabajador.Num_empleado,Trabajador.Id_usuario,Trabajador.Id_puesto), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            BDCon.CerrarConexion();
            return retorno;
        }
        public static string Consultar()
        {
            string retorno = "";
            string cadena = "select nombre from trabajador";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                retorno = retorno + "-" + registros["nombre"].ToString();
            }
            return retorno;
        }
        public static int Eliminar_Trabajador(Trabajador Trabajador)
        {
            int retorno = 0;
            string cadena = "Delete from trabajador where nombre='" + Trabajador.Nombre+ "'";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static string Consultar2(Trabajador Trabajador)
        {
            string retorno = "";
            string cadena = "select apellido_pat,apellido_mat,direccion,telefono,num_empleado,id_usuario,id_puesto from trabajador where nombre='" + Trabajador.Nombre + "'";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                retorno = registros["apellido_pat"].ToString() + "-" + registros["apellido_mat"].ToString() + "-"
                + registros["direccion"].ToString() + "-"+ registros["telefono"].ToString() + "-"+ registros["num_empleado"].ToString()
                + "-"+registros["id_usuario"].ToString() + "-"+ registros["id_puesto"].ToString();
            }
            return retorno;
        }
        public static string Consultar3()
        {
            string retorno = "";
            string cadena = "select * from trabajador";
            SqlCommand comando = new SqlCommand(cadena, BDCon.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                retorno = retorno + registros["nombre"].ToString() + "-" + registros["apellido_pat"].ToString() + "-" + registros["apellido_mat"].ToString() + "-"
                + registros["direccion"].ToString() + "-" + registros["telefono"].ToString() + "-" + registros["num_empleado"].ToString()
                + "-" + registros["id_usuario"].ToString() + "-" + registros["id_puesto"].ToString()+"-"+Environment.NewLine;
            }
            return retorno;
        }
        public static int Modificar(Trabajador Trabajador)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand(string.Format("Update trabajador set  apellido_pat='{0}', apellido_mat='{1}',direccion='{2}',telefono='{3}',num_empleado='{4}',id_usuario='{5}',id_puesto='{6}' Where nombre='{7}'",
            Trabajador.Ape_pat,Trabajador.Ape_mat,Trabajador.Direccion,Trabajador.Telefono,Trabajador.Num_empleado,Trabajador.Id_usuario,Trabajador.Id_puesto,Trabajador.Nombre), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
