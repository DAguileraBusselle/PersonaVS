using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaVS
{
    class Persistencia
    {
        private static System.IO.Stream str = Properties.Resources.sound;
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);

        private static System.IO.Stream strMoai = Properties.Resources.moai;
        private static System.Media.SoundPlayer playMoai = new System.Media.SoundPlayer(strMoai);

        public void listar(DataGridView data)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("mostrar_registros", Conexion.ObtenerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }


        }

        public Boolean isDniRepetido(string dni)
        {
            Boolean isDniRep = true;
            try
            {
                SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM PERSONAS WHERE DNI = '" + dni + "'", Conexion.ObtenerConexion());

                Int32 numFilas = (Int32) query.ExecuteScalar();
                if(numFilas == 0)
                {
                    isDniRep = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return isDniRep;
        }

        public Boolean idIgualporDni(String dni, int id)
        {
            Boolean idIgual = false;

            try
            {
                SqlCommand query = new SqlCommand("SELECT ID FROM PERSONAS WHERE DNI = '" + dni + "'", Conexion.ObtenerConexion());

                Int32 idQuery = (Int32)query.ExecuteScalar();
                if (idQuery == id)
                {
                    idIgual = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }

            return idIgual;
        }

        public void filtrar(DataGridView data, string buscarnombre)
        {
            try
            {
                SqlCommand sql = new SqlCommand("busqueda_nombre", Conexion.ObtenerConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = buscarnombre;

                sql.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        public Boolean modificarDatos(String nombre, String ape1, String ape2, String dni, int id)
        {
            Boolean operacionExitosa = false;
            try
            {
                SqlCommand query = new SqlCommand("UPDATE PERSONAS SET NOMBRE = '" + nombre + "', APELLIDO1 = '" + ape1 + "', APELLIDO2 = '" + ape2 + "', DNI = '" + dni + "' WHERE ID = '" + id + "' ", Conexion.ObtenerConexion());

                int r = query.ExecuteNonQuery();

                if (r > 0)
                {
                    player.Play();
                    MessageBox.Show("Datos guardados");
                    operacionExitosa = true;
                }
                else
                {
                    MessageBox.Show("No se han podido guardar los datos");
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return operacionExitosa;
        }

        public Boolean introducirDatos(String nombre, String ape1, String ape2, String dni)
        {
            Boolean operacionExitosa = false;
            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO PERSONAS VALUES('" + nombre + "', '" + ape1 + "', '" + ape2 + "', '" + dni + "')", Conexion.ObtenerConexion());

                int r = query.ExecuteNonQuery();

                if (r > 0)
                {
                    player.Play();
                    MessageBox.Show("Datos guardados");
                    operacionExitosa = true;
                } else
                {
                    MessageBox.Show("No se han podido guardar los datos");
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return operacionExitosa;
        }

        public Boolean eliminarDatos(int id)
        {
            Boolean operacionExitosa = false;
            try
            {
                SqlCommand query = new SqlCommand("DELETE FROM PERSONAS WHERE ID = '"+id+"'", Conexion.ObtenerConexion());

                int r = query.ExecuteNonQuery();

                if (r > 0)
                {
                    playMoai.Play();
                    MessageBox.Show("LA PERSONA HA SIDO DESTRUIDA");
                    playMoai.Stop();
                    operacionExitosa = true;

                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el usuario");
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            return operacionExitosa;
        }
    }
}
