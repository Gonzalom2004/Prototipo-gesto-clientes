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
            
        }
       






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAgregarCliente FAgregarCliente = new FAgregarCliente();
            FAgregarCliente.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBuscar FBuscar = new FBuscar();
            FBuscar.ShowDialog();
        }

        private void dispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAgregarDispositivo fAgregarDispositivo = new FAgregarDispositivo();
            fAgregarDispositivo.ShowDialog();
        }
    }
}
