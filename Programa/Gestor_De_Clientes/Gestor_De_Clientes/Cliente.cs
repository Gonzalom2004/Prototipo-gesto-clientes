using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Clientes
{
    class Cliente
    {
        //Clase hecha para guardar la logica de negocio, esta clase solo tiene la responsabilidad de guardar
        //propiedades y metodos. Despues se hacer una para la conexion con la base de datos asi cada clase tiene una unica 
        //responsabilidad. 

        #region "Atributos" 
        private string _nombre;
        private string _apellido;
        private string _id; //Que lo genera la base de datos. 
        private string _telefono;
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
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


        #endregion

        #region "Constructor"
        public Cliente (string _nombre, string _apellido, string _id, string _telefono)
        {
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._id = _id;
            this._telefono = _telefono; 
        }
        #endregion

        //Faltan agregar los metodos 
        #region "Metodos"
        #endregion
    }
}
