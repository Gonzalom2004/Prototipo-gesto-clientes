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
            GBDispositivo.Visible = true;
            GBfiltros_cliente.Visible = false;
            DTPfecha_alta.Enabled = false; 
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBdispositivo_CheckedChanged(object sender, EventArgs e)
        {
            if(RBdispositivo.Checked)
            {
                GBfiltros_cliente.Visible = false; 
                GBDispositivo.Visible = true;

                //Lid_cliente.Visible = true;
                //Tid_cliente.Visible = true;
                //Ltipo.Visible = true;
                //Ttipo.Visible = true;
                //Lmodelo_marca.Visible = true;
                //Tmodelo.Visible = true;
                //Lfalla.Visible = true;
                //Tfalla.Visible = true;
                //Lestado.Visible = true;
                //CBestado.Visible = true;
                //Lcomentario.Visible = true;

                
            }

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBcliente_CheckedChanged(object sender, EventArgs e)
        {
            if (RBcliente.Checked)
            {
                GBDispositivo.Visible = false;
                GBfiltros_cliente.Visible = true;
            }
            
        }

        private void listViewPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bmostar_Click(object sender, EventArgs e)
        {
            //fijarse si es mejor meter los filtros en variables para luego usarlos en ortas partes
            //como pasa aca abajo uso "A reparar" dos veces lo cual puede dar error. Usar variables 
            //Para que no haya posibles errores al reescribir el filtro
            LVbuscador.Items.Clear();
            LVbuscador.Columns.Clear();
            if (RBdispositivo.Checked) //Primera situación es que el usuario quiera filtrar por Dispositivos
            {
                if (CBestado.Text == "A reparar")
                {
                    DispositivoFiltro filtro = new DispositivoFiltro { Estado = "A reparar" };

                    List<Dispositivo> pendientes = DispositivoBD.ObtenerDispositivos(filtro);


                    foreach (Dispositivo D in pendientes)
                    {
                        LVbuscador.Items.Add(D.ToString()); //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
                                                            //o al darle doble click diga mas datos sobre el dispositivo 
                                                            //Agregar funcionalidad de cambiar estado a reparado 
                    }
                }
                else if (CBestado.Text == "Reparado")
                {
                    DispositivoFiltro filtro = new DispositivoFiltro { Estado = "Reparado" };


                    List<Dispositivo> pendientes = DispositivoBD.ObtenerDispositivos(filtro);


                    foreach (Dispositivo D in pendientes)
                    {
                        LVbuscador.Items.Add(D.ToString()); //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
                                                            //o al darle doble click diga mas datos sobre el dispositivo 
                                                            //Agregar funcionalidad de cambiar estado a reparado 
                    }
                }
                else if (Tnombre.Text != "")
                {
                    ClienteFiltro filtro = new ClienteFiltro { Nombre = Tnombre.Text };
                    List<Cliente> clientes = ClienteDB.ObtenerClientes(filtro);
                    foreach (Cliente c in clientes)
                    {
                        LVbuscador.Items.Add(c.ToString());
                    }
                }
                else
                {
                    listaTodoDispositivo();// Cree este metodo mas arriba porque se usa en el boton mostrar y eliminar para no repetir codigo llamamos a este igual
                                //recordar que es mostrar/listar todo sin filtar ni nada 
                }
            }
            else if (RBcliente.Checked) //Segunda situación es que el usuario quiera filtrar por Cliente
            {
                ClienteFiltro filtros_cliente = new ClienteFiltro();
                bool sin_filtro = true;
                if (Tid_clientefiltro.Text != "")
                {
                    filtros_cliente.ID = Convert.ToInt32(Tid_clientefiltro.Text);
                    sin_filtro = false;
                }
                if (Tnombre.Text != "")
                {
                    filtros_cliente.Nombre = Tnombre.Text;
                    sin_filtro = false;
                }
                if (Tapellido.Text != "")
                {
                    filtros_cliente.Apellido = Tapellido.Text;
                    sin_filtro = false;
                }
                if (Ttelefono.Text != "")
                {
                    filtros_cliente.Telefono = Ttelefono.Text;
                    sin_filtro = false;
                }
                if (CBfecha_alta.Checked)
                {
                    filtros_cliente.Fecha_Alta = DTPfecha_alta.Value;
                    sin_filtro = false;
                }
                if (sin_filtro)
                {
                    ListarTodoCliente();
                }
                else
                {
                    List<Cliente> listaClientes = ClienteDB.ObtenerClientes(filtros_cliente);
                }
            }
                
              
            
        }

        private void listaTodoDispositivo() // Cree este metodo porque se usa en el boton mostrar y eliminar para no repetir codigo llamamos a este igual
                                 //recordar que es mostrar/listar todo sin filtar ni nada 
        {

            LVbuscador.Items.Clear();
            LVbuscador.Columns.Clear();
            LVbuscador.View = View.Details;
            LVbuscador.GridLines = true;
            LVbuscador.FullRowSelect = true;
            LVbuscador.Columns.Add("ID", 50);
            LVbuscador.Columns.Add("Cliente", 150);
            LVbuscador.Columns.Add("Teléfono", 100);
            LVbuscador.Columns.Add("Tipo", 100);
            LVbuscador.Columns.Add("Marca", 100);
            LVbuscador.Columns.Add("Falla", 200);
            LVbuscador.Columns.Add("Estado", 80);
            LVbuscador.Columns.Add("Fecha Ingreso", 100);
            LVbuscador.Columns.Add("Comentario", 200);


            List<Dispositivo> dispositivos = DispositivoBD.ObtenerDispositivos();

            foreach (Dispositivo dispositivo in dispositivos)
            {
                ListViewItem item = new ListViewItem(dispositivo.ID.ToString());


                item.SubItems.Add(dispositivo.Cliente != null ? dispositivo.Cliente.Nombre : "Sin cliente");
                item.SubItems.Add(dispositivo.Cliente != null ? dispositivo.Cliente.Telefono : "N/D");
                item.SubItems.Add(dispositivo.Tipo ?? "N/D");
                item.SubItems.Add(dispositivo.Marca ?? "N/D");
                item.SubItems.Add(dispositivo.Falla ?? "Sin descripción");
                item.SubItems.Add(dispositivo.Estado ?? "N/D");
                item.SubItems.Add(dispositivo.FechaIngreso ?? "N/D");
                item.SubItems.Add(dispositivo.Comentario ?? "Sin comentarios");

                // Guardar el objeto completo para referencia, sirve para editar y eliminar desp
                item.Tag = dispositivo;

                LVbuscador.Items.Add(item);
            }


            foreach (ColumnHeader column in LVbuscador.Columns)// Autoajustar columnas al contenido
            {
                column.Width = -2;
            }
        }

        private void ListarTodoCliente()
        {
            LVbuscador.Items.Clear();
            LVbuscador.Columns.Clear();
            LVbuscador.View = View.Details;
            LVbuscador.GridLines = true;
            LVbuscador.FullRowSelect = true;
            LVbuscador.Columns.Add("ID", 50);
            LVbuscador.Columns.Add("Nombre", 150);
            LVbuscador.Columns.Add("Apellido", 100);
            LVbuscador.Columns.Add("Telefono", 100);
            LVbuscador.Columns.Add("Fecha Alta", 100);


            List<Cliente> clientes = ClienteDB.ObtenerClientes() ;

            foreach (Cliente cliente in clientes)
            {
                ListViewItem item = new ListViewItem(cliente.Id.ToString());


                item.SubItems.Add(cliente.Nombre ??  "Sin Nombre");
                item.SubItems.Add(cliente.Apellido ?? "N/D");
                item.SubItems.Add(cliente.Telefono ?? "N/D");
                item.SubItems.Add(cliente.FechaAlta ?? "Sin fecha");
               

                // Guardar el objeto completo para referencia, sirve para editar y eliminar desp
                item.Tag = cliente;

                LVbuscador.Items.Add(item);
            }


            foreach (ColumnHeader column in LVbuscador.Columns)// Autoajustar columnas al contenido
            {
                column.Width = -2;
            }
        }
        



        private void CBfecha_alta_CheckedChanged(object sender, EventArgs e)
        {
            if (CBfecha_alta.Checked)
            {
                DTPfecha_alta.Enabled = true;
            }
            else if (!CBfecha_alta.Checked)
            {
                DTPfecha_alta.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BMostrarCantPendiente_Click(object sender, EventArgs e)
        {
            
            //Este boton es para poner la cantidad de pendientes que quiero ver ya que el dia de mañana
            //Cuando haya mucha cantidad si los traigo todos van a ser muchos los dispositivos que voy 
            //a tener que traer y se va a relentizar la data 

            //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
            //o al darle doble click diga mas datos sobre el dispositivo 
            //Agregar funcionalidad de cambiar estado a reparado


            //Agregar un if que controle la cantidad de pendientes que existen
            listViewPendientes.Items.Clear();
            DispositivoFiltro filtro = new DispositivoFiltro
            {
                Estado = "A reparar",
                Limite = Convert.ToInt32(NUDCantPendientes.Value)
            };



            List <Dispositivo> pendientes = DispositivoBD.ObtenerDispositivos(filtro);


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
                

                // Autoajustar columnas al contenido
                foreach (ColumnHeader columna in listViewPendientes.Columns)
                {
                    columna.Width = -2; // Autoajustar al contenido
                }
            }

            if(Convert.ToInt16(NUDCantPendientes.Value) > pendientes.Count) 
            {
                //Este condicional es para mostrarle al usuario que la cantidad que 
                //seleccionó es mucho mayor a la cantidad de pendientes que existen
                MessageBox.Show($"Solo hay {pendientes.Count} en estado pendiente");
                NUDCantPendientes.Value = Convert.ToDecimal(pendientes.Count);
                NUDCantPendientes.Focus(); 
            }
            
        }

        private void listViewPendientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewPendientes.SelectedItems.Count > 0)
            {
                //Obtener el id del dispositivo seleccionado sabiendo 
                //que esta en la primer columna 

                int idDispositivo = Convert.ToInt32(listViewPendientes.SelectedItems[0].SubItems[0].Text);
                Detalles_Modificar formDetalles = new Detalles_Modificar(idDispositivo);
                formDetalles.ShowDialog();
            }
        }
    }
}
