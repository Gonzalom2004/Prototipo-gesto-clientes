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
            
        }


        // Construye el objeto de configuración
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // donde está appsettings.json
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();

        // Obtener la cadena de conexión desde el JSON
        string conexion = config.GetConnectionString("conexion");

//       Asi se tiene que ver appsettings.json {
  
//  "ConnectionStrings": {
  
//    "conexion": "Data Source= C:\\Users\\04gon\\OneDrive\\Escritorio\\Prototipo-gesto-clientes\\Programa\\Base_De_Datos\\Gestor_De_Cliente.db; Version=3;"
//   }
//}



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
