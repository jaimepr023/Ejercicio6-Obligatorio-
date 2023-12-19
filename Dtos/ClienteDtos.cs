using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjercicio6.Dtos
{
    /// <summary>
    /// Clase donde se encuetra los atributos de nuestro cliente
    /// <author>jpr-19-12-23</author>
    /// </summary>
    internal class ClienteDtos
    {
        long idCliente;

        string nombreCliente = "aaaaa";

        string apellidosClientes = "aaaaa";

        string nombreCompletoCliente = "aaaaa";

        int edad = 0;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosClientes { get => apellidosClientes; set => apellidosClientes = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }

        public ClienteDtos(long idCliente, string nombreCliente, string apellidosClientes, string nombreCompletoCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosClientes = apellidosClientes;
            this.nombreCompletoCliente = nombreCliente + " " + apellidosClientes;
            this.edad = edad;
        }

        public ClienteDtos()
        {

        }

        override
            public string ToString()
        {
            string cliente = "Nombre: "+ nombreCompletoCliente + "\n"+ "Edad: "+ edad+"\n";
            return cliente;
        }
    }
}
