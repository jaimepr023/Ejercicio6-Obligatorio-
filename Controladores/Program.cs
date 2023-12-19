using ArrayEjercicio6.Dtos;
using ArrayEjercicio6.Servicios;

namespace ArrayEjercicio6.Controladores
{
    /// <summary>
    /// Clase donde se encuentra el procedimiento de nuestro menu
    /// <author>jpr-19-12-23</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main donde esta todo lo nombrado del procedimiento
        /// <author>jpr-19-12-23</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<ClienteDtos> cliente = new List<ClienteDtos>();

            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            bool cerrarMenu = false;
            int opcionElegida;

            do
            {
                opcionElegida = mi.mostrarMenu();
                switch (opcionElegida)
                {
                    case 0:
                        Console.WriteLine("[INFOS]-A continuacion se cerrara el menu. Muchas gracias y que tenga un buen dia. ");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFOS]-A continuacion podra darse de alta.");
                        ci.darAltaCliente(cliente);
                        break; 
                    case 2:
                        Console.WriteLine("[INFOS]-Aqui podras ordenar los clientes que hay en la lista");
                        ci.ordenarCliente(cliente);
                        break;
                    default:
                        Console.WriteLine("[INFOS]- Se desea que de una de las opciones asequibles. Intentelo de nuevo. ");
                        break;
                }

            }while(!cerrarMenu);
        }
    }
}
