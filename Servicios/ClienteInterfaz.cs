using ArrayEjercicio6.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjercicio6.Servicios
{
    /// <summary>
    /// Clase que tiene la cabecera de los metodos en relacion del cliente 
    /// <author>jpr-19-12-23</author>
    /// </summary>
    internal interface ClienteInterfaz
    {

        /// <summary>
        /// Cabecera del metodo que da alta a un cliente nuevo 
        /// <author>jpr-19-12-23</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDtos> listaAntigua);

        /// <summary>
        /// Cabecera del metodo que ordena a los clientes de forma descendente segun su edad 
        /// <author>jpr-19-12-23</author>
        /// </summary>
        /// <param name="modificarLista"></param>
        public void ordenarCliente(List<ClienteDtos> modificarLista);
    }
}
