using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Clientes
{
    public class DispositivoFiltro
    {
        //Cada propiedad de aca abajo representa una campo por el que se puede filtrar 
        public string Estado { get; set; } //Esto para filtrar por estado "A Reparar","Reparado"
        public string Tipo { get; set; } //Para filtrar por tipo asi sea celular , notebook atc...

        //Aca Tendria que seguir agregando mas propiedades para poder filtar por otro tipo de cosas
        //Pero por ahora voy a usar la propiedad de Estado para poder listar lo que esten pendientes 
        //En la pagina principal. 
    }
}
