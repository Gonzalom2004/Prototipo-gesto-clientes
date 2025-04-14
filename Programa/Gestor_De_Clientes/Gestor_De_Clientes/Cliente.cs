using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Clientes
{
    public class Cliente
    {
        //Clase hecha para guardar la logica de negocio, esta clase solo tiene la responsabilidad de guardar
        //propiedades y metodos. Despues se hacer una para la conexion con la base de datos asi cada clase tiene una unica 
        //responsabilidad. 

        #region "Atributos" 
        private int _id; //Que lo genera la base de datos.
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _fechaAlta;
        #endregion
        //Las propiedades las ponemos en private para serguir la regla de encapsulamiento 

        #region "Propiedades"
        //Pensar la necesidad de poner algun condicional para la asignación de valores
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }


        #endregion

        #region "Constructor"

        public Cliente() { } // Necesitamos este constructor vacio para poder usar 
        //El inicializador de objetos que metemos en el while de la clase ClienteDB (new Cliente {....})
        public Cliente (string _nombre, string _apellido, string _telefono)
        {
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._id = 0;//mirar esto deberia ser null
            this._telefono = _telefono;
            this._fechaAlta = Convert.ToString( DateTime.Today);

        }
        public Cliente(string _nombre, string _apellido, int _id, string _telefono, string _fechaAlta)
        {
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._id = _id ;
            this._telefono = _telefono;
            this._fechaAlta = _fechaAlta;
        }
        #endregion

        //Faltan agregar mas metodos 
        #region "Metodos"
        
        public override string ToString()
        {
            return $"{Id} | {Nombre} | {Apellido}";
           
        }

        #endregion
    }
}
