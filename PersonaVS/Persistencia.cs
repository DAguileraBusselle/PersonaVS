﻿using System;
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
        public void listar(DataGridView data)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("mostrar_registros", Conexion.ObtenerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                data.Columns[4].Width = 35;
                data.Columns[4].HeaderCell.Value = "ID";
                
                data.Columns[0].HeaderCell.Value = "Nombre";
                
                data.Columns[1].HeaderCell.Value = "Apellido1";
                
                data.Columns[2].HeaderCell.Value = "Apellido2";
                
                data.Columns[3].HeaderCell.Value = "DNI";


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

        public Boolean introducirDatos(String nombre, String ape1, String ape2, String dni)
        {
            Boolean operacionExitosa = false;
            try
            {
                SqlCommand query = new SqlCommand("INSERT INTO PERSONAS VALUES('" + nombre + "', '" + ape1 + "', '" + ape2 + "', '" + dni + "')", Conexion.ObtenerConexion());

                int r = query.ExecuteNonQuery();

                if (r > 0)
                {
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
                    MessageBox.Show("Se ha eliminado correctamente el usuario");
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