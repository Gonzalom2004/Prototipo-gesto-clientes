using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Gestor_De_Clientes
{
    public class ClienteDB
    {


        #region "Constructor"
        public ClienteDB() { }
        //Este constructor lo usamos para inicializar/instanciar la clase para poder usar los metodos de abajo
        #endregion

        #region "Metodos"
        public List<Cliente> ObtenerClientes() //Este metodo lo que hace es traer los datos de la base para poder instanciar los clientes otra vez y meterlos en la lista 
        {
        
            List<Cliente> lista = new List<Cliente>();

            #region "Obtener Cadena de conexion que esta en appsettins.json"
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) //busca donde está appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Obtener la cadena de conexión desde el JSON
            string conexion = config.GetConnectionString("conexion");
            #endregion


            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT ID, Nombre, Apellido, Telefono, FechaAlta FROM Cliente"; //Aca no probe si se puese usar SELECT * asterisco porque
                                                                                                //mas abajo el reader usar los indices para seleccionar el atributo


                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cliente
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Telefono = reader.GetString(3),
                            FechaAlta = reader.GetString(4)

                        });
                    }

                }

            }
            return lista;

        }
        #endregion


    }
}
