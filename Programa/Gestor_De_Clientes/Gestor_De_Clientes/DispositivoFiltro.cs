using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Clientes
{
    public class DispositivoFiltro
    {
        //La clase esta solo hecha con propiedades por esta diseñada como un DTO (Data Transfer Object) o objeto de transferencia de datos
        //Su estructura simple con solo propiedades tiene varias razones importantes
        //Con esta clase tambien seguimos el principio de responsabilidad única es decir solo se encargar de trasportar datos de filtrado
        //No debe contener lógica de negocio ni saber cómo se aplican los filtros 

        //Cada propiedad de aca abajo representa una campo por el que se puede filtrar 
        public string Estado { get; set; } //Esto para filtrar por estado "A Reparar","Reparado"
        public string Tipo { get; set; } //Para filtrar por tipo asi sea celular , notebook atc...

        //Aca Tendria que seguir agregando mas propiedades para poder filtar por otro tipo de cosas
        //Pero por ahora voy a usar la propiedad de Estado para poder listar lo que esten pendientes 
        //En la pagina principal. 
    }
}
