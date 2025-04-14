using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Clientes
{
    public static class DispositivoBD
    {
        private static string CadenaConexion()//Tuve que crear un metodo porque si no el codigo que esta aca dentro no funciona 
                                              //siempre que se quiera obtener la cadena en los metodos de abajo llamamos a este metodo

        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) //busca donde está appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Obtener la cadena de conexión desde el JSON
            return config.GetConnectionString("conexion");
        }

        #region "Metodos"
        public static List<Dispositivo> ObtenerDispositivos()
        {
            List<Cliente> clientes = ClienteDB.ObtenerClientes();

            List<Dispositivo> lista = new List<Dispositivo>();
            using (SQLiteConnection conn = new SQLiteConnection(CadenaConexion()))
            {
                conn.Open();
                string query = "SELECT ID, ID_Cliente, Tipo, Marca, Falla, Estado, Comentario FROM Dispositivo"; 
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using(SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idcliente = reader.GetInt32(1);
                        Cliente cliente = clientes.FirstOrDefault(c => c.Id == idcliente);


                        lista.Add(new Dispositivo
                        {//Le asignamos los valores a las propiedades
                           ID= reader.GetInt32(0),
                           Tipo= reader.GetString(2),
                           Marca= reader.GetString(3),
                           Falla= reader.GetString(4),
                           Estado= reader.GetString(5),
                           Comentario= reader.GetString(6),
                           Cliente= cliente
                        });
                    }
                }
            }
            return lista;
        }

        public static bool EliminarDispositivo(int id) 
        {
            using (SQLiteConnection conn = new SQLiteConnection(CadenaConexion()))
            {
                conn.Open();
                string query = "DELETE FROM Dispositivo WHERE id = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int filasAfectadas = cmd.ExecuteNonQuery(); // Esto nos dice la cantidad de registros/filas que fueron afectadas
                return filasAfectadas > 0; //si es mayor a cero significa que esta bien, que se elimino correctamente 
            }
        }

        public static bool AgregarDispositivo(Dispositivo dispositivo)//Usamos un metodo bool para corroborar que se hayan insertado las filas si o no 
                                                          //Sirve para saber si la operación fue exitosa o fallida es util para mostrar mensajer al usuario 
        {

            using (SQLiteConnection conn = new SQLiteConnection(CadenaConexion()))
            {
                conn.Open();
                string query = "INSERT INTO Dispositivo (ID_Cliente, Tipo, Marca, Falla, Estado, Comentario, FechaIngreso) VALUES (@id_cliente, @tipo, @marca, @falla, @estado, @comentario, @fechaingreso)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) //El using hay que usarlo para que no queden conexiones abeirta y la base de datos se bloquee
                {
                    cmd.Parameters.AddWithValue("@id_cliente",   dispositivo.Cliente.Id);
                    cmd.Parameters.AddWithValue("@tipo", dispositivo.Tipo);
                    cmd.Parameters.AddWithValue("@marca", dispositivo.Marca);
                    cmd.Parameters.AddWithValue("@falla",dispositivo.Falla);
                    cmd.Parameters.AddWithValue("@estado", dispositivo.Estado);
                    cmd.Parameters.AddWithValue("@comentario", dispositivo.Comentario);
                    cmd.Parameters.AddWithValue("@fechaingreso", dispositivo.FechaIngreso);

                    int filasAfectadas = cmd.ExecuteNonQuery(); // Esto nos dice la cantidad de registros/filas que fueron afectadas
                    return filasAfectadas > 0; //si es mayor a cero significa que esta bien que se inserto correctamente 

                }
            }
        }


       
        #endregion
    }
}
