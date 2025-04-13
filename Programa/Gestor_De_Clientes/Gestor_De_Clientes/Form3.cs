using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_De_Clientes
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<Cliente> lista = new List<Cliente>();

            lista = ClienteDB.ObtenerClientes();

            foreach (Cliente C in lista)
            {
                ListaBuscar.Items.Add(C.ToString());
            }

            List<Dispositivo> list = new List<Dispositivo>();

            list = DispositivoBD.ObtenerDispositivos(lista);

        }
    }
}
