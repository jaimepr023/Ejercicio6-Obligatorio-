using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjercicio6.Servicios
{
    /// <summary>
    /// Clase del menu implementacion implementado con la interfaz
    /// <author>jpr-19-12-23</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcion;

            Console.WriteLine("-------------------");
            Console.WriteLine("Opcion 0. Cerrar menu.");
            Console.WriteLine("Opcion 1. Dar alta a un cliente.");
            Console.WriteLine("Opcion 2. Ordenar clientes.");
            Console.WriteLine("------------------- \n");


            Console.WriteLine("Elige una opcion del menu:");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
