using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaATM.SQL
{
    public class ConexionSQL
    {
        private SqlConnection sqlConnection;

        // Crea el Connection String para conectarse a la DB
        // En Data Source poner el nombre de tu servidor
        // En Initial Catalog poner el nombre de la db
        // en User ID el usuario que se conecta si aplica
        // y en password su password si aplica
        private const string connectionString = "Data Source=;" +
                                                "Initial Catalog=master;" +
                                                "User id=;" +
                                                "Password=;";





        /// <summary>
        /// Este metodo hace un query al llamar uno de los procedimientos creados por el 
        /// profesor en el archivo ATM.sql
        /// </summary>
        /// <param name="procedure">el nombre del procedimiento</param>
        /// <param name="paramName">el nombre del parametro dentro del procedimiento</param>
        /// <param name="param">el valor del paremetro</param>
        /// <returns></returns>
        public string query(string procedure, string columnName, string paramName, string param)
        {
            string r = "No existe";
            SqlDataReader reader = null;
            try
            {
                // Crea el objeto SqlConnection y le pasa el connection string
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                // Crea un objeto SqlCommand para realizar el query que se hara llamando
                // uno de los procedures que el profesor creo en el archivo ATM.sql
                SqlCommand cmd = new SqlCommand(procedure, sqlConnection);

                // Indicamos que es un StoreProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 
                cmd.Parameters.AddWithValue(paramName, param);

                // Crea el reader para almacenar el resultado del query
                reader = cmd.ExecuteReader();
                reader.Read();
                r = reader[columnName].ToString();
            } 
            catch (Exception e)
            {
                if (e is SqlException || e is InvalidOperationException)
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                if (reader != null)
                    reader.Close();
            }
            return r;
        }
    }
}
