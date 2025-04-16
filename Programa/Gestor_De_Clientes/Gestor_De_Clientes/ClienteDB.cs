using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Gestor_De_Clientes
{
    public static  class ClienteDB
    {
       
        private static string CadenaConexion()//Tuve que crear un metodo porque si no el codigo que esta aca dentro no funciona 
                                               //siempre que se quiera obtener la cadena en los metodos de abajo llamamos a este metodo
                                               //Este metodo tambien esta en DispositivoDB buscar manera de no tener que replicar ese metodo en esa clase
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) //busca donde está appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Obtener la cadena de conexión desde el JSON
           return config.GetConnectionString("conexion");
        } 

       
        #region "Metodos" 
        //algunos tienen que ser metodos static para no tener que instanciar la clase
        public static List<Cliente> ObtenerClientes() //Este metodo lo que hace es traer los datos de la base para poder instanciar los clientes otra vez y meterlos en la lista 
        {
            List<Cliente> lista = new List<Cliente>();
            using (SQLiteConnection conn = new SQLiteConnection(CadenaConexion()))
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
        
        public static int AgregarCliente(Cliente cliente)//Usamos un metodo bool para corroborar que se hayan insertado las filas si o no 
                                                    //Sirve para saber si la operación fue exitosa o fallida es util para mostrar mensajer al usuario 
        {
          
            using (SQLiteConnection conn = new SQLiteConnection(CadenaConexion()))
            {
                conn.Open();
                string query = "INSERT INTO Cliente (Nombre, Apellido, Telefono, FechaAlta) VALUES (@nombre,@apellido, @telefono, @fechaAlta );SELECT last_insert_rowid();";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) //El using hay que usarlo para que no queden conexiones abeirta y la base de datos se bloquee
                {
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@fechaAlta", cliente.FechaAlta);


                    int nuevoID = Convert.ToInt32(cmd.ExecuteScalar());
                    return nuevoID;
                
                }
            }
        }

        public static bool EliminarCliente (int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(CadenaConexion()))
            {
                conn.Open();
                string query = "DELETE FROM Cliente WHERE id = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int filasAfectadas = cmd.ExecuteNonQuery(); // Esto nos dice la cantidad de registros/filas que fueron afectadas
                return filasAfectadas > 0; //si es mayor a cero significa que esta bien, que se elimino correctamente 
            }
        } 

        public static (bool existe, Cliente clienExistente) VerificarClientePorTelefono (string telefono) //Este metodo esta buerno ya que si existe el 
                                                                                                          //Cliente ademas de decirme que existe me devuelve el cliente 
        {
            //Primero normalizamos el teléfono (eliminar espacios, guiones, lo que sea)
            string telefonoNormalizado = NormalizarTelefono(telefono);

            if (string.IsNullOrWhiteSpace(telefonoNormalizado)) //si al normalizar nos devuelve un null no tiene sentido buscar en la base de datos
            {                                                   //Igual la idea en controlar en el codigo de la interfaz que nunca se entre un null
                                                                //probablemente tendriamos que usar un masked o algo, un estandar de numero de telefono
                return (false, null); 
            }

            using ( var conn = new SQLiteConnection(CadenaConexion()))
            {
                conn.Open();

                string query = "SELECT * FROM Cliente WHERE Telefono = @telefono limit 1";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@telefono", telefonoNormalizado);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //Retornar true y el cliente existente 
                            return (true, new Cliente
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
            }
            return (false, null); 


        }

        private static string  NormalizarTelefono(string telefono)// Es para eliminar cualquier caracter que no sea un numero
        {
            if (string.IsNullOrWhiteSpace(telefono))//Primeor verificamos que no sea null,vacio o solo contiene espacios
            {
                return null;//si es así, retorna null, indicando que no hay un número de teléfono válido para procesar
            }
            return new string(telefono.Where(char.IsDigit).ToArray()); //Aca usamos la libreria LINQ para poder iterar sobre cada caracter
                                                                       //char.Isdigit es una función que retorna true si el carácter es un 
                                                                       //digito numerico, esto para conservar solo los caracteres que son
                                                                       //digito numéricos. El .ToArray() convierte los caracteres filtrados 
                                                                       //en un array de tipo char y el new string crea un nuevo string a 
                                                                       // partir  del array de caracteres, que ahora solo tendria que contener
                                                                       //solo digitos. Repasar esto que no lo termine de entender
        }

      

        #endregion


    }
}
