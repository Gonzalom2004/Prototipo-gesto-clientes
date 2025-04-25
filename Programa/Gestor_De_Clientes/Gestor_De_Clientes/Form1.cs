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

        private void Form1_Load(object sender, EventArgs e)//Cuando carga una de las cosas que hace es listar los dispositivos pendientes
        {
            DispositivoFiltro filtro = new DispositivoFiltro { Estado = "A reparar" };
          

            List<Dispositivo> pendientes = DispositivoBD.ObtenerDispositivos(filtro);


            foreach (Dispositivo D in pendientes)
            {
                Lpendientes.Items.Add(D.ToString()); //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
                                                     //o al darle doble click diga mas datos sobre el dispositivo 
                                                     //Agregar funcionalidad de cambiar estado a reparado 
            }
        }

        private void Lpendientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
