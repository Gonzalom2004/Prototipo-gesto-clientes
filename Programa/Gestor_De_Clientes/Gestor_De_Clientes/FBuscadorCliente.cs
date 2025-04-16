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
    public partial class FBuscadorCliente: Form
    {
        //propiedad para exponer el cliente seleccionar
        public Cliente clienteSeleccionado { get; private set; }
        List<Cliente> Lista = new List<Cliente>();

        
        public FBuscadorCliente()
        {
            InitializeComponent();
            ListarTodo();
        }
        private void ListarTodo()
        {
            Lista = ClienteDB.ObtenerClientes();

            foreach (Cliente C in Lista)
            {
                LBbuscador.Items.Add(C.ToString());
            }
            
        }
        
        

        private void FBuscadorCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FBuscadorCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FBuscadorCliente_Load(object sender, EventArgs e)
        {

        }

        private void Bseleccionar_Click(object sender, EventArgs e)
        {
            if (LBbuscador.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un cliente");

            }
            else
            {
                clienteSeleccionado = Lista[LBbuscador.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
