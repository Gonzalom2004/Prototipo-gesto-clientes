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
            ListaBuscar.Items.Clear();
            List<Dispositivo> lista = new List<Dispositivo>();

            lista = DispositivoBD.ObtenerDispositivos();

            foreach (Dispositivo D in lista)
            {
                ListaBuscar.Items.Add(D.ToString() + " | " + D.Cliente.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)//Boton para mostrar todo lo de la base de datos sin filtrar
        {

            //Falta poder filtar con mucho filtros a la vez hicimos pruebas pero con filtros separados 
            ListaBuscar.Items.Clear();
            if (CBestado.Text == "A reparar" )
            {
                DispositivoFiltro filtro = new DispositivoFiltro { Estado = "A reparar" };


                List<Dispositivo> pendientes = DispositivoBD.ObtenerDispositivos(filtro);


                foreach (Dispositivo D in pendientes)
                {
                    ListaBuscar.Items.Add(D.ToString()); //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
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
                    ListaBuscar.Items.Add(D.ToString()); //Aca solo lista los dispositivos sin los datos de cliente la idea es hacer un boton con detalles 
                                                         //o al darle doble click diga mas datos sobre el dispositivo 
                                                         //Agregar funcionalidad de cambiar estado a reparado 
                }
            }
            else if(Tnombre.Text != "")//Verificar que no haya no puedan ingresar espacion en blanco 
            {
                ClienteFiltro filtro = new ClienteFiltro { Nombre = Tnombre.Text };
                List<Cliente> clientes = ClienteDB.ObtenerClientes(filtro);
                foreach (Cliente c in clientes)
                {
                    ListaBuscar.Items.Add(c.ToString());
                }
            }
            else 
            {
                listaTodo();// Cree este metodo mas arriba porque se usa en el boton mostrar y eliminar para no repetir codigo llamamos a este igual
                //recordar que es mostrar/listar todo sin filtar ni nada 
            }

            

        }

        private void BEliminar_Click(object sender, EventArgs e) //Este metodo de eliminar funciona si los que esta listado coincide con el orden de la lista 
        {
            
            List<Dispositivo> lista = new List<Dispositivo>();
            lista = DispositivoBD.ObtenerDispositivos();//Acá estoy trayendo todo lo que hay en la base de datos sin filtrar nada
            int indice = ListaBuscar.SelectedIndex;
            
            if (indice == -1)
            {
                MessageBox.Show("Debes seleccionar un dispositivo");
            }
            else
            {
                Dispositivo dispositivo = lista[indice];
                DispositivoBD.EliminarDispositivo(dispositivo.ID);
                
            }
            ListaBuscar.Items.Clear();
            listaTodo();
        }
    }
}
