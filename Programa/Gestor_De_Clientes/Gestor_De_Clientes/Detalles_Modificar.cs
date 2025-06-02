using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_De_Clientes
{
    public partial class Detalles_Modificar: Form
    {

        private int _idDispositivo;
        private Dispositivo dispositivo;

        //Evento publico para poder actualizar el formulario principal 
        //Luego de realizar los cambios 
        public event EventHandler DatosActualizados; 

        //Constructor
        public Detalles_Modificar(int idDispositivo)
        {
            InitializeComponent();
            _idDispositivo = idDispositivo;
            this.FormClosed += Detalles_Modificar_FormClosed;
        }
        public Detalles_Modificar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Detalles_Modificar_Load(object sender, EventArgs e)
        {
            Bconfirmar_dispositivo.Enabled = false;
            Bconfirmar_cliente.Enabled = false; 
            
            Ttipo.Enabled = false;
            TmarcaModelo.Enabled = false;
            Tfalla.Enabled = false;
            CBestado.Enabled = false;
            Tcomentario.Enabled = false;
            
            Tnombre.Enabled = false;
            Tapellido.Enabled = false;
            Ttelefono.Enabled = false;
            
            
            //Ver si se puede refactorizar la forma en la que se trae un dispositivo por
            //su id, quedo medio complicado cuando es algo tan simple que no tiene 
            //muchos filtros solo es el id 
            DispositivoFiltro filtro = new DispositivoFiltro { Id = _idDispositivo };
            List<Dispositivo> lista = DispositivoBD.ObtenerDispositivos(filtro);
            dispositivo = lista[0];

            Tid.Text = Convert.ToString( dispositivo.ID);
            Ttipo.Text = dispositivo.Tipo;
            TmarcaModelo.Text = dispositivo.Marca;
            Tfalla.Text = dispositivo.Falla; 
            CBestado.Text = dispositivo.Estado;
            DTPingreso.Value = Convert.ToDateTime(dispositivo.FechaIngreso);
            Tcomentario.Text = dispositivo.Comentario;
            Tid_cliente.Text = Convert.ToString( dispositivo.Cliente.Id);
            Tnombre.Text = dispositivo.Cliente.Nombre;
            Tapellido.Text = dispositivo.Cliente.Apellido;
            Ttelefono.Text = dispositivo.Cliente.Telefono;
            DTPfecha_alta.Value = Convert.ToDateTime(dispositivo.Cliente.FechaAlta);






            //Esto de abajo fue una sugerencia de deepseek para poder usar imagenes
            //lo que hace es usar la ruta de la imagen para guardarla en la computadora
            //Ya que no es bueno guardar en la base de datos la imagen directamente 
            //Ya que consume muchos recursos
            //string rutaImagen = "/images/productos/producto1.jpg";

            //using (var conexion = new SQLiteConnection("Data Source=mi_db.db"))
            //{
            //    conexion.Open();
            //    var comando = new SQLiteCommand(
            //        "INSERT INTO Productos (Nombre, RutaImagen) VALUES (@Nombre, @RutaImagen)",
            //        conexion);

            //    comando.Parameters.AddWithValue("@Nombre", "Producto 1");
            //    comando.Parameters.AddWithValue("@RutaImagen", rutaImagen);
            //    comando.ExecuteNonQuery();
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBmodificar_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmodificar_dispositivo.Checked)
            {
                Bconfirmar_dispositivo.Enabled = true;
                
                
                Ttipo.Enabled = true;
                TmarcaModelo.Enabled = true;
                Tfalla.Enabled = true;
                CBestado.Enabled = true;
                Tcomentario.Enabled = true;
               
            }
            else
            {
                Bconfirmar_dispositivo.Enabled = false;

               
                Ttipo.Enabled = false;
                TmarcaModelo.Enabled = false;
                Tfalla.Enabled = false;
                CBestado.Enabled = false;
                Tcomentario.Enabled = false;
               
            }
        }

        private void CBmodificar_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CBmodificar_cliente.Checked)
            {
                Bconfirmar_cliente.Enabled = true;


                
                Tnombre.Enabled = true;
                Tapellido.Enabled = true;
                Ttelefono.Enabled = true;
            }
            else
            {
                Bconfirmar_cliente.Enabled = false; 
                 
                
                Tnombre.Enabled = false;
                Tapellido.Enabled = false;
                Ttelefono.Enabled = false;
            }
            
        }

        private void Bconfirmar_dispositivo_Click(object sender, EventArgs e)
        {
            if (DispoDatosCompletos())
            {
                DispositivoFiltro cambios = new DispositivoFiltro();

                if (dispositivo.Tipo != Ttipo.Text)
                {
                    cambios.Tipo = Ttipo.Text;
                }
                if (dispositivo.Marca != TmarcaModelo.Text)
                {
                    cambios.Marca = TmarcaModelo.Text;
                }
                if (dispositivo.Falla != Tfalla.Text)
                {
                    cambios.Falla = Tfalla.Text;
                }
                if(dispositivo.Estado != CBestado.Text)
                {
                    cambios.Estado = CBestado.Text;
                }
                if (dispositivo.Comentario != Tcomentario.Text)
                {
                    cambios.Comentario = Tcomentario.Text;
                }

                if (DispositivoBD.ModificarDispositivo(_idDispositivo, cambios))
                {
                    MessageBox.Show("Se modifico correctamente");
                }
            }
        }


        private bool DispoDatosCompletos()
        {
            if (Ttipo.Text == "")
            {
                EPvalidación.SetError(Ttipo, "Incompleto");
            }
            else if (TmarcaModelo.Text == "")
            {
                EPvalidación.SetError(TmarcaModelo, "incompleto");
            }
            else if (Tfalla.Text == "")
            {
                EPvalidación.SetError(Tfalla, "incompleto");
            }
            else
            {
                return true;
            }
            return false; 
            
            
                
                
        }

        private void Detalles_Modificar_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosActualizados?.Invoke(this, EventArgs.Empty);
        }
    }
}
