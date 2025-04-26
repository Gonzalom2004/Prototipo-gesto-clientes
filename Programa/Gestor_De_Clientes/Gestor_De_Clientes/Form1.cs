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
using System.Globalization;
using System.Diagnostics;
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
            Form1_Load(sender, e);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBuscar FBuscar = new FBuscar();
            FBuscar.ShowDialog();
            Form1_Load(sender, e);
        }

        private void dispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAgregarDispositivo fAgregarDispositivo = new FAgregarDispositivo();
            fAgregarDispositivo.ShowDialog();
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewPendientes.Items.Clear();
            listViewPendientes.Columns.Clear();
            listViewPendientes.View = View.Details;
            listViewPendientes.GridLines = true; // Líneas de cuadrícula
            listViewPendientes.FullRowSelect = true; // Selección de fila completa
            listViewPendientes.Columns.Add("ID", 80, HorizontalAlignment.Left);
            listViewPendientes.Columns.Add("Cliente", 150, HorizontalAlignment.Left);
            listViewPendientes.Columns.Add("Tipo", 120, HorizontalAlignment.Left);
            listViewPendientes.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            listViewPendientes.Columns.Add("Falla", 200, HorizontalAlignment.Left);
            listViewPendientes.Columns.Add("Estado", 100, HorizontalAlignment.Center);
            listViewPendientes.Columns.Add("Fecha Ingreso", 120, HorizontalAlignment.Center);


            DispositivoFiltro filtro = new DispositivoFiltro { Estado = "A reparar" };
            List<Dispositivo> pendientes = DispositivoBD.ObtenerDispositivos(filtro);

            foreach (Dispositivo dispositivo in pendientes)
            {
                ListViewItem item = new ListViewItem(dispositivo.ID.ToString());

                item.SubItems.Add(dispositivo.Cliente != null ? dispositivo.Cliente.Nombre : "Sin cliente");
                item.SubItems.Add(dispositivo.Tipo ?? "N/D");
                item.SubItems.Add(dispositivo.Marca ?? "N/D");
                item.SubItems.Add(dispositivo.Falla ?? "Sin descripción");
                item.SubItems.Add(dispositivo.Estado ?? "N/D");
                item.SubItems.Add(dispositivo.FechaIngreso ?? "N/D");

                // Almacenar objeto completo para referencia, esto sirve para lo de editar que lo voy a hacer proximamente
                item.Tag = dispositivo;

                listViewPendientes.Items.Add(item);
            }

            // Autoajustar columnas al contenido
            foreach (ColumnHeader columna in listViewPendientes.Columns)
            {
                columna.Width = -2; // Autoajustar al contenido
            }
        }
        private void Lpendientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
