using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Clientes
{
    public class Dispositivo
    {
        #region "Atributos"
        private int _id; //Que lo genera la base de datos.
        private string _tipo; //Aca la idea es que sean tres tipos: TELEFONO, TABLET, VARIOS cuando le das a varios se aber una texbox donde agregar el tipo que sea
        private string _marca;
        private string _falla;//Para ingresar la descripcion sencilla/corta como: pantalla rota, cambio de bateria 
        private string _estado;//Aca la idea es que sean 2 opciones: A REPARAR, REPARADO
        private string _comentario; //Para ingresar aspectos importantes sobre la reparación 
        private Cliente _cliente; //Este atributos es para saber a que cliente corresponde cada dispositivo
        private string _fechaingreso;
        //Hay que agregar tambien el atributo fecha de alta en el caso de que se agrega un dispositivo sin cliente 
        #endregion


        #region "Propiedades"
        //Pensar la necesidad de poner algun condicional para la asignación correcta de valores
        public string FechaIngreso 
        {
            get { return _fechaingreso; }
            set {  _fechaingreso = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Falla
        {
            get { return _falla; }
            set { _falla = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }
        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        #endregion

        #region "Constructor"
        public Dispositivo() { }// Necesitamos este constructor vacio para poder usar 
        //El inicializador de objetos que metemos en el while de la clase DispositivoDB (new Cliente {....})
        public Dispositivo (string _tipo, string _marca, string _falla, string _estado, string _comentario, Cliente _cliente)
        {
            this._id = 0;
            this._tipo = _tipo;
            this._marca = _marca;
            this._falla = _falla;
            this._estado = _estado;
            this._comentario = _comentario;
            this._cliente = _cliente; 
            this._fechaingreso = DateTime.Today.ToString();
        }
        public Dispositivo(int _id, string _tipo, string _marca, string _falla, string _estado, string _comentario, Cliente _cliente)
        {
            this._id = _id;
            this._tipo = _tipo;
            this._marca = _marca;
            this._falla = _falla;
            this._estado = _estado;
            this._comentario = _comentario;
            this._cliente = _cliente;
            this._fechaingreso = DateTime.Today.ToString();
        }
        #endregion

        //Faltar agregar los metodos
        #region "Metodos"
        //Saber fecha de modificacion de estado();
        #endregion


    }
}
