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
                        lista.Add(new Dispositivo
                        {//Le asignamos los valores a las propiedades
                           ID= reader.GetInt32(0)
                           
                           //Falta terminar porque no se que hacer con el id_cliente porque 
                           //la clase dispositovo tiene de atributo a cliente 
                           //¿Tendriamos que buscar aca tambien el cliente para poder ingresarlo como atributo?
                           


                        });
                    }
                }
            }
            return lista;
        }

        #endregion
    }
}
