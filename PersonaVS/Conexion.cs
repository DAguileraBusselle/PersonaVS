using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaVS
{
        class Conexion
        {
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["PersonasVSConnectionString"].ToString());
                conectar.Open();
                return conectar;
            }
            catch (Exception)
            {

                throw new Exception("Error en la conexion"); ;
            }
        }

        public static SqlConnection CerrarConexion()
        {
            SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["PersonasVSConnectionString"].ToString());
            conectar.Close();
            return conectar;
        }

    }
    
}