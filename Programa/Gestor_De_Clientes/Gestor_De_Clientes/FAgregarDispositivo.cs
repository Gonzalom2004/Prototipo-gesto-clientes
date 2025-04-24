using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_De_Clientes
{
    public partial class FAgregarDispositivo: Form
    {
        public FAgregarDispositivo()
        {
            InitializeComponent();
        }
        private Cliente _clienteActual;//Esa variable/atributo lo uso para poder traer el cliente que se selecciono en el formulario

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FAgregarDispositivo_Load(object sender, EventArgs e)
        {
            Tnombre.Enabled = false;
            Tapellido.Enabled = false;
            Ttelefono.Enabled = false;
            Tcomentario.Enabled = false;
            //Bagregar.Enabled = false;
            

        }

        private void CHagregar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CHagregar.Checked)
            {
                Tnombre.Text = null;
                Tapellido.Text = null;
                Ttelefono.Text = null; 
                Tnombre.Enabled = true;
                Tapellido.Enabled = true;
                Ttelefono.Enabled = true;
                Bagregar.Enabled = true;
                
            }
            else
            {
                Tnombre.Enabled = false;
                Tapellido.Enabled = false;
                Ttelefono.Enabled = false;
                Bagregar.Enabled = false; 
            }
        }

 

        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (DatosDispoCompletos() && DatosClienteCompletos()) // cambiar orden primero verificar capos de dispositivos
            { 
                if (CHagregar.Checked)//Hay que verificar que el cliente ya existe para no agregarlo otra vez 
                {
                    var (existe, clienteExistente) = ClienteDB.VerificarClientePorTelefono(Ttelefono.Text);
                    if (existe)
                    {
                        DialogResult respuesta = MessageBox.Show($"Cliente ya registrado con ese numero:\n\n" +
                        $"Nombre: {clienteExistente.Nombre} {clienteExistente.Apellido}\n" +
                        $"ID: {clienteExistente.Id}\n" +
                        $"Fecha Alta: {clienteExistente.FechaAlta} \n\n"+
                        "Deseas usarlo?",
                        "Advertencia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                        if (respuesta == DialogResult.Yes)
                        {
                            Tnombre.Text = clienteExistente.Nombre;
                            Tapellido.Text = clienteExistente.Apellido;
                            Ttelefono.Text = clienteExistente.Telefono;
                            Dispositivo dispositivo = new Dispositivo(Ttipo.Text, Tmarca.Text, Tfalla.Text, CBestado.Text, Tcomentario.Text, clienteExistente);
                            MessageBox.Show("Se agrego correctamente");
                            Ttipo.Text = null;
                            Tmarca.Text = null;
                            Tfalla.Text = null;
                            CBestado.Text = null;
                            Tcomentario.Text = null; 
                            Tnombre.Text = null;
                            Tapellido.Text = null;
                            Ttelefono.Text = null;
                            CHagregar.Checked = false; 
                            Tnombre.Enabled = false;
                            Tapellido.Enabled = false;
                            Ttelefono.Enabled = false;
                            
                        }
                        else if (respuesta == DialogResult.No)
                        {
                            Ttelefono.Text = null;
                            Ttelefono.Focus();
                        }


                    }
                    else
                    {
                        Cliente cliente = new Cliente(Tnombre.Text, Tapellido.Text, Ttelefono.Text);
                        int idBaseDatos = ClienteDB.AgregarCliente(cliente); //Este metodo luego de agregar el dispositivo me devuelve el id que genero el autoincrement de la base de datos
                        cliente.Id = idBaseDatos;//Agregamos el id a la propiedad de cliente 
                        Dispositivo dispositivo = new Dispositivo(Ttipo.Text, Tmarca.Text, Tfalla.Text, CBestado.Text, Tcomentario.Text, cliente);
                        DispositivoBD.AgregarDispositivo(dispositivo);
                        MessageBox.Show("Se agrego correctamente");
                        Ttipo.Text = null;
                        Tmarca.Text = null;
                        Tfalla.Text = null;
                        CBestado.Text = null;
                        Tcomentario.Text = null;
                        Tnombre.Text = null;
                        Tapellido.Text = null;
                        Ttelefono.Text = null;
                        CHagregar.Checked = false;
                        Tnombre.Enabled = false;
                        Tapellido.Enabled = false;
                        Ttelefono.Enabled = false;
                    }
                    
                }
                else
                {
                    Dispositivo dispositivo = new Dispositivo(Ttipo.Text, Tmarca.Text, Tfalla.Text, CBestado.Text, Tcomentario.Text, _clienteActual);
                    DispositivoBD.AgregarDispositivo(dispositivo);
                    MessageBox.Show("Se agrego correctamente");
                    Ttipo.Text = null;
                    Tmarca.Text = null;
                    Tfalla.Text = null;
                    CBestado.Text = null;
                    Tcomentario.Text = null;
                    Tnombre.Text = null;
                    Tapellido.Text = null;
                    Ttelefono.Text = null;
                    CHagregar.Checked = false;
                    Tnombre.Enabled = false;
                    Tapellido.Enabled = false;
                    Ttelefono.Enabled = false;
                }  
            }
        }
        private bool DatosDispoCompletos()
        {
            epValidacion.Clear(); 
            if (Ttipo.Text == "")
            {
                epValidacion.SetError(Ttipo, "Completar");
            
            }
            else if (Tmarca.Text == "")
            {
                epValidacion.SetError(Tmarca, "Completar");
            }
            else if (Tfalla.Text == "")
            {
                epValidacion.SetError(Tfalla, "Completar");
            }
            else if (CBestado.SelectedIndex == -1)
            {
                epValidacion.SetError(CBestado, "Seleccionar");
            }
            else if (Tcomentario.Text== "" && CHcomentario.Checked) //mirar si check de comentario esta activo)
            {
                epValidacion.SetError(Tcomentario, "Completar");
            }
            else
            {
                return true;
            }
            return false;
        }
        private bool DatosClienteCompletos()
        {
            if (Tnombre.Text == "")
            {
                epValidacion.SetError(Tnombre, "Completar");
            }
            else if (Tapellido.Text == "")
            {
                epValidacion.SetError(Tapellido, "Completar");
            }
            else if (Ttelefono.Text== "")
            {
                epValidacion.SetError(Ttelefono, "Completar");
            }
            else
            {
                return true; 
            }

            return false; 
        }

        private void TbuscarCliente_Click(object sender, EventArgs e)
        //Acá lo que se podria hacer es reutilizar el otro form de busqueda he implementarlo acá 
        {//Buscar maner de sacar el check cuando se cierra el form de busqueda de cliente 
         //Antes de esto hay que llamar al metodo de campos completos para verificar que los datos de dispositivo esten completos
            CHagregar.Checked = false;
            using (FBuscadorCliente fBuscador = new FBuscadorCliente())
            {
                if (fBuscador.ShowDialog() == DialogResult.OK)
                {
                    Cliente cliente = fBuscador.clienteSeleccionado;
                    Tnombre.Text = cliente.Nombre;
                    Tapellido.Text = cliente.Apellido;
                    Ttelefono.Text = cliente.Telefono;
                    _clienteActual = cliente;
                    Bagregar.Enabled = true; 

                }
               
            }


        }

        private void CHcomentario_CheckedChanged(object sender, EventArgs e)
        {
            if (CHcomentario.Checked)
            {
                Tcomentario.Enabled = true; 
            }
            else
            {
                Tcomentario.Enabled = false; 
            }
        }
    }
}
