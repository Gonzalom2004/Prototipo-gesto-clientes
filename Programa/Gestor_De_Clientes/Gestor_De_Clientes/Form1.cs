using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//agregar using de paquetes para usar json
namespace Gestor_De_Clientes
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            conectarBB();
        }
        private void conectarBB()
        {
           
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // donde está appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Obtener la cadena de conexión desde el JSON
            string conexion = config.GetConnectionString("conexion");


            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string consulta = @" 
                    SELECT c.nombre, c.id, d.tipo
                    FROM Cliente c JOIN Dispositivo d ON c.id = d.id_cliente;
                    
                ";
                using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                   //aca cuando empezemos a agregar clientes y dispositivos
                   //hay que poner para que se muestren las reparaciones pendientes
                   //tomando de referencia la base de datos de prueba y el winforms de prueba
                }

            }
             
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
