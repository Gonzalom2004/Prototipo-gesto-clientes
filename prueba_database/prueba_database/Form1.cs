using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace prueba_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {

            // Construye el objeto de configuración
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // donde está appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Obtener la cadena de conexión desde el JSON
            string conexion = config.GetConnectionString("conexion");

      


            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                //esto de aca abajo es porque chatgpt decia que un error puede ser que 
                //hay que inicializar la cf, pero funciona igual sin esto
                using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string query = @"
                    SELECT c.nombre, c.telefono, d.tipo, d.marca, d.falla, d.estado
                    FROM Cliente c
                    JOIN Dispositivo d ON c.id = d.id_cliente;
                     ";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    listView1.Items.Clear();
                    listView1.Columns.Clear();

                    listView1.View = View.Details;
                    listView1.Columns.Add("Cliente");
                    listView1.Columns.Add("Teléfono");
                    listView1.Columns.Add("Tipo");
                    listView1.Columns.Add("Marca");
                    listView1.Columns.Add("Falla");
                    listView1.Columns.Add("Estado");

                    while (reader.Read())
                    {
                        string[] row = {
                            reader["nombre"].ToString(),
                            reader["telefono"].ToString(),
                            reader["tipo"].ToString(),
                            reader["marca"].ToString(),
                            reader["falla"].ToString(),
                            reader["estado"].ToString()
                        };
                        listView1.Items.Add(new ListViewItem(row));
                    }

                    foreach (ColumnHeader column in listView1.Columns)
                    {
                        column.Width = -2;
                    }
                }
            }
        }
    }
}
