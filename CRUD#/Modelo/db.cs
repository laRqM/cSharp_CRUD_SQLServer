using Newtonsoft.Json;
using System.Data.SqlClient;

namespace CRUD_.Modelo {
    class db {
        public SqlConnection DBConn() {
            string json = File.ReadAllText("sql_server_connection.json"); // Leemos el archivo JSON.
            var config = JsonConvert.DeserializeObject<ConnectionConfigSQLServer>(json); // Se realiza una deserialización para convertir el JSON en un objeto de C#.

            string connectionString = $"Server={config.Server};Database={config.Database};Integrated Security={config.IntegratedSecurity};"; // Creamos la cadena de conexión con los datos en el archivo JSON.

            try {
                SqlConnection conn = new SqlConnection(connectionString); // Creamos un objeto de tipo SqlConnection y le pasamos la cadena de conexión.
                return conn; // Retornamos la conexión.
            } catch (SqlException ex) {
                Console.WriteLine("Error de conexión: " + ex.Message); // Si algo falla, mostramos un mensaje en consola.
                return null;
            }
        }
    }
}
