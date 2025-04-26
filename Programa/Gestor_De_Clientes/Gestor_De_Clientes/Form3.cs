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
    public partial class FBuscar: Form
    {
        public FBuscar()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listaTodo();

        }
        private void listaTodo() // Cree este metodo porque se usa en el boton mostrar y eliminar para no repetir codigo llamamos a este igual
                                //recordar que es mostrar/listar todo sin filtar ni nada 
        {

            listViewBuscar.Items.Clear();
            listViewBuscar.Columns.Clear();
            listViewBuscar.View = View.Details;
            listViewBuscar.GridLines = true;
            listViewBuscar.FullRowSelect = true;
            listViewBuscar.Columns.Add("ID", 50);
            listViewBuscar.Columns.Add("Cliente", 150);
            listViewBuscar.Columns.Add("Teléfono", 100);
            listViewBuscar.Columns.Add("Tipo", 100);
            listViewBuscar.Columns.Add("Marca", 100);
            listViewBuscar.Columns.Add("Falla", 200);
            listViewBuscar.Columns.Add("Estado", 80);
            listViewBuscar.Columns.Add("Fecha Ingreso", 100);
            listViewBuscar.Columns.Add("Comentario", 200);


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

                listViewBuscar.Items.Add(item);
            }

            
            foreach (ColumnHeader column in listViewBuscar.Columns)// Autoajustar columnas al contenido
            {
                column.Width = -2;
            }
        }

        //falta acomodar las columnas para cuando se filtra
        //falta acomodar las columnas para cuando se filtra
        //falta acomodar las columnas para cuando se filtra
        //falta acomodar las columnas para cuando se filtra
        //falta acomodar las columnas para cuando se filtra
        private void button1_Click(object sender, EventArgs e)//Boton para mostrar todo lo de la base de datos sin filtrar
        {

            //Falta poder filtar con mucho filtros a la vez hicimos pruebas pero con filtros separados 
            listViewBuscar.Items.Clear();
            if (CBestado.Text == "A reparar")
            {
                DispositivoFiltro filtro = new DispositivoFiltro { Estado = "A reparar" };


                List<Dispositivo> pendientes = DispositivoBD.ObtenerDispositivos(filtro);


                foreach (Dispositivo D in pendientes)
                {
                    listViewBuscar.Items.Add(D.ToString()); //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
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
                    listViewBuscar.Items.Add(D.ToString()); //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
                                                            //o al darle doble click diga mas datos sobre el dispositivo 
                                                            //Agregar funcionalidad de cambiar estado a reparado 
                }
            }
            else if (Tnombre.Text != "")//Verificar que no haya no puedan ingresar espacion en blanco 
            {
                ClienteFiltro filtro = new ClienteFiltro { Nombre = Tnombre.Text };
                List<Cliente> clientes = ClienteDB.ObtenerClientes(filtro);
                foreach (Cliente c in clientes)
                {
                    listViewBuscar.Items.Add(c.ToString());
                }
            }
            else
            {
                listaTodo();// Cree este metodo mas arriba porque se usa en el boton mostrar y eliminar para no repetir codigo llamamos a este igual
                //recordar que es mostrar/listar todo sin filtar ni nada 
            }



        }
        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay algún elemento seleccionado
            if (listViewBuscar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debes seleccionar un dispositivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el primer elemento seleccionado (en caso de selección múltiple)
            ListViewItem itemSeleccionado = listViewBuscar.SelectedItems[0];

            // Obtener el objeto Dispositivo desde el Tag
            Dispositivo dispositivo = (Dispositivo)itemSeleccionado.Tag;


            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de eliminar el dispositivo {dispositivo.ID} - {dispositivo.Tipo}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool eliminado = DispositivoBD.EliminarDispositivo(dispositivo.ID);

                if (eliminado)
                {
                    MessageBox.Show("Dispositivo eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaTodo(); 
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el dispositivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
