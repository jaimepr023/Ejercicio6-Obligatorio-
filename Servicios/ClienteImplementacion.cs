using ArrayEjercicio6.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjercicio6.Servicios
{
    /// <summary>
    /// Clase cliente que implementa la interfaz cliente
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {
        /// <summary>
        /// Metodo privado que crea un nuevo cliente 
        /// </summary>
        /// <returns></returns>
        private ClienteDtos crearCliente()
        {
            ClienteDtos cliente = new ClienteDtos();

            Console.WriteLine("Dame el ID del cliente: ");
            cliente.IdCliente = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Dame el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Dame los apellidos del cliente: ");
            cliente.ApellidosClientes = Console.ReadLine();
            Console.WriteLine("Dame la edad del cliente: ");
            cliente.Edad = Int32.Parse(Console.ReadLine());

            cliente.NombreCompletoCliente = cliente.NombreCliente + " "+ cliente.ApellidosClientes;

            return cliente;
        }



        public void darAltaCliente(List<ClienteDtos> listaAntigua)
        {
            ClienteDtos cliente = crearCliente();
            listaAntigua.Add(cliente);
        }

        public void ordenarCliente(List<ClienteDtos> modificarLista)
        {
           
            
            if(modificarLista.Count >=3)
            {
                Console.WriteLine("Estos son los usuarios actuales: \n");
                mostrarClientes(modificarLista);

                burbuja(modificarLista);
               
                Console.WriteLine("Esto son los clientes ya ordenados de forma descendente(Por la edad):");
                mostrarClientes(modificarLista);

            }else
            {
                Console.WriteLine("Se necesitan mas clientes para poder realizar esta operacion.");
            }
        }

        /// <summary>
        /// Metodo privado que muestra los nombres completos de los usuarios y su edad 
        /// </summary>
        /// <param name="mostrarClie"></param>
        private void mostrarClientes(List<ClienteDtos> mostrarClie)
        {
            foreach (ClienteDtos cliente in mostrarClie)
            {
                Console.WriteLine(cliente.ToString());
            }

        }

        /// <summary>
        /// Metodo que realiza la operacion burbuja para ordenar de forma descendente a los clientes
        /// </summary>
        /// <param name="modificarLista"></param>
        private void burbuja(List<ClienteDtos> modificarLista)
        {
            for (int i = 0; i < modificarLista.Count - 1; i++)
            {
                for (int j = 0; j < modificarLista.Count - 1 - i; j++)
                {
                    if (modificarLista[j].Edad < modificarLista[j + 1].Edad)
                    {
                        ClienteDtos aux = modificarLista[j];
                        modificarLista[j] = modificarLista[j + 1];
                        modificarLista[j + 1] = aux;
                    }
                }
            }

        }



    }

}
