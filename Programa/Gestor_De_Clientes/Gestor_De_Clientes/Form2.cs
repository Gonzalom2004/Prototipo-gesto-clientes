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
    public partial class FAgregar : Form
    {
        public FAgregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Acordarse cambiarle nombre a los elementos
        {
            Cliente cliente = new Cliente(Tnombre.Text, Tapellido.Text, Ttelefono.Text);
            if (ClienteDB.AgregarCliente(cliente))
            {
                MessageBox.Show("Se agrego correctamente");
            }
            else
            {
                MessageBox.Show("No se agrego");
            }
            
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Falta hacer uno de estos para el texbox de fecha alta
                                                                            //Acordarse cambiarle nombre a los elementos 
        {
            if (Char.IsLetter(e.KeyChar) | Char.IsWhiteSpace(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//Acordarse cambiarle nombre a los elementos
        {
            if (Char.IsLetter(e.KeyChar) | Char.IsWhiteSpace(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)//Acordarse cambiarle nombre a los elementos
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

          
        }
    }
}
