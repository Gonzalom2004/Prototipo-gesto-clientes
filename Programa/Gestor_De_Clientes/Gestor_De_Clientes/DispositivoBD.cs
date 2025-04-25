using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Gestor_De_Clientes
{
    public static class DispositivoBD
    {
        private static string CadenaConexion()//Tuve que crear un metodo porque si no el codigo que esta aca dentro no funciona 
        {                                     //siempre que se quiera obtener la cadena en los metodos de abajo llamamos a este metodo

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) //busca donde está appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Obtener la cadena de conexión desde el JSON
            return config.GetConnectionString("conexion");
        }

        #region "Metodos"
        public static List<Dispositivo> ObtenerDispositivos(DispositivoFiltro filtros = null)//el null es para decir que no es necesario mandar algun parametros por si es es el caso de que se quiere listar todos los dispositivos  
        {                                                    
            List<Cliente> clientes = ClienteDB.ObtenerClientes();

            List<Dispositivo> lista = new List<Dispositivo>();
            using (SQLiteConnection conn = new SQLiteConnection(CadenaConexion())) //El objeto del tipo SQLiteConnection conn se encarga de manejar toda la comunicación con la BD                                                                                    
            {                                                                       //Cuando recien se instancia se establece como .Closed() por eso abajo la abrimos con conn.Open()
                                                                                    //El using se encargar de cerrar la conexion cuando hay una excepcion o se deja de usar y libera los recursos 
                                                                                    //Es para una ejecución segura 
                conn.Open();//Se abre la conexión fisica con la base de datos
                
                string query = "SELECT ID, ID_Cliente, Tipo, Marca, Falla, Estado, Comentario FROM Dispositivo";

                //Lista para condiciones y parámetros:
                var condiciones = new List<string>(); //Es una lista para guardar las condiciones WHERE que se aplicarán a la consulta SQL guarda lo que despues se forma en una cadena
                var parametros = new List<SQLiteParameter>();//Es lista es para guardar parametros que se usarán en la consulta SQL es decir los valores que se asignaron en el filtro 
                                                             

                //Construir condiciones dinámicamente si hay filtros:
                if (filtros != null)
                {
                    if (!string.IsNullOrEmpty(filtros.Estado)) 
                    {
                        condiciones.Add("Estado = @Estado");
                        parametros.Add(new SQLiteParameter("@Estado", filtros.Estado));//Metemos la propiedad Estado de la clase DispositivoFiltro 
                    }
                    if (!string.IsNullOrEmpty(filtros.Tipo))
                    {
                        condiciones.Add("Tipo = @Tipo");
                        parametros.Add(new SQLiteParameter("@Tipo", filtros.Tipo)); //Metemos la propiedad Tipo de la clase DispositivoFiltro
                    }
                    
                    //Aca podemos seguir metiendo mas condiciones para el filtrado es bastante escalable esta forma de filtrar 
                }
                //Aca agregamos el WHERE si es que hay condiciones. Se hace el ensamblado final de la consulta 
                if(condiciones.Count > 0)//Si es distinto de 0 quiere decir que hay condiciones para agregar con WHERE  
                {
                    query += " WHERE " + string.Join(" AND ", condiciones);//String.Join("Separador",listaDeStrings) dejando una cadena WHERE Estado = @Estado AND Tipo = @Tipo
                }


                //Aca ejecutamos la consulta:
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) //necesitamos el SQLiteCommand porque a diferencia de SQLiteConnection que se encarga de la conexion fisica, 
                {                                                          //SQLiteCommand se encarga de ejecutar comando SQL o sea consultas 
                                                                           //Se encargar de devolver resultados a través de ExecuteReader(), ExecuteScalar() o ExecuteNonQuery()
                    foreach (var param in parametros)
                    {
                        cmd.Parameters.Add(param);//Esto se encargar de reemplazar cada @atributo con el valor como por ejemplo a @Estado lo remplaza con el valor de parametro es decir 
                                                //por ejemplo "A reparar"
                    }

                    //Aca con el reader leemos los resultados
                    using (SQLiteDataReader reader = cmd.ExecuteReader()) //Con cmd.ExcuteReader() se encarga de ejecutar la consulta y se encarga de devolver un lector de resultado
                    {                                                      
                        while (reader.Read())//Esto avanza a la siguiente fila de resultados (devuelve false cuando no hay más filas)
                        {                   //Dentro de este while se procesa cada fila 
                            int idcliente = reader.GetInt32(1);
                            Cliente cliente = clientes.FirstOrDefault(c => c.Id == idcliente); //Aca se encarga de buscar al cliente en la lista, que corresponde con el dispositivo por id_cliente
                                                                                                //para mas abajo asignarlo al atributo de su dispositivo

                            lista.Add(new Dispositivo
                            {//Le asignamos los valores a las propiedades
                                ID = reader.GetInt32(0),
                                Tipo = reader.GetString(2),
                                Marca = reader.GetString(3),
                                Falla = reader.GetString(4),
                                Estado = reader.GetString(5),
                                Comentario = reader.GetString(6),
                                Cliente = cliente
                            });
                        }
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
