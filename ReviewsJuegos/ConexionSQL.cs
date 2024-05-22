using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ReviewsJuegos
{
    public class ConexionSQL
    {
        private static SqlConnection cnx = new SqlConnection();
        private static void Connect()
        {
            try
            {
                cnx.ConnectionString = "Data Source=localhost; Initial Catalog=ReviewJuego;Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        private static void Disconect()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
        // Create a method to excecute a Selection query
        public static DataTable SelectQuery(string query)
        {
            var dt = new DataTable();
            try
            {
                Connect();
                var cmd = new SqlCommand(query, cnx);
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
            return dt;
        }
        // Método para ejecutar un procedimiento almacenado
        public static void ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {

            try
            {
                Connect();
                var cmd = new SqlCommand(procedureName, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters is not null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }
    }
}