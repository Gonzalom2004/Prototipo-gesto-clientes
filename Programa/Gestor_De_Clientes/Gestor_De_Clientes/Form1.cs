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
            string dbRelativePath = Path.Combine("..", "..", "Base_De_Datos", "Gestor_De_Clientes.db");
            string dbAbsolutePath = Path.GetFullPath(dbRelativePath);
            string connectionString = $"Data Source={dbAbsolutePath};Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                MessageBox.Show("se abrio"); 
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
