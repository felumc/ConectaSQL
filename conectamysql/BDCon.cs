using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace conectasql
{
    public class BDCon
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("Data Source=LUISFE\\LUISFESERVER;Initial Catalog=ejercicio;user=prueba;password=prueba;Encrypt=False;");//Encrypt=False;
            //Data Source=LUDWIG\ASUS;Initial Catalog=ejercicio;Integrated Security=True    
            //SqlConnection conectar = new SqlConnection("server=LUDWIG; database=ejercicio; Userid=root; password=ludwig;");
            conectar.Open();
            return conectar;
        }
      public static SqlConnection CerrarConexion()
        {
            SqlConnection desconectar = new SqlConnection("Data Source=LUISFE\\LUISFESERVER;Initial Catalog=ejercicio;user=prueba;password=prueba;Encrypt=False;");
            //Integrated Security=SSPI;
            desconectar.Close();
            return desconectar;
      }

    }

}