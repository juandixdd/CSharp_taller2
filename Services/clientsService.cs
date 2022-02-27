using System.Collections;

namespace CSharp_taller2
{
    class clientsService
    {
        ArrayList clients = new ArrayList();

        public void addClient(Clients client)
        {
            clients.Add(client);
            Console.WriteLine("Cliente agregado");
        }

        public void showClients()
        {
            Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("** Lista de clientes: **");
            Console.WriteLine("************************");

            if (clients.Count == 0)
            {
                Console.WriteLine("No hay clientes");
            }
            else
            {
                foreach (Clients client in clients)
                {
                    Console.WriteLine("Nombre: " + client.name);
                    Console.WriteLine("     - Direccion: " + client.direction);
                    Console.WriteLine("     - Telefono: " + client.phone);
                    Console.WriteLine("     - Cedula: " + client.id);
                    Console.WriteLine("***************************************************");
                }
            }
        }

        public void findClient(string id)
        {
            Console.Clear();

            foreach (Clients client in clients)
            {
                if (client.id == id)
                {
                    Console.WriteLine("************************");
                    Console.WriteLine("** Cliente **");
                    Console.WriteLine("Nombre: " + client.name);
                    Console.WriteLine("     - Direccion: " + client.direction);
                    Console.WriteLine("     - Telefono: " + client.phone);
                    Console.WriteLine("     - Cedula: " + client.id);
                    Console.WriteLine("***************************************************");
                }
                else
                {
                    Console.WriteLine("El cliente no existe");
                }
            }
        }

        public void editClient(string id)
        {
            Console.Clear();

            Console.WriteLine("");
            foreach (Clients client in clients)
            {
                if (client.id == id)
                {
                    Console.WriteLine("Ingrese el nuevo nombre del cliente:");
                    client.name = Console.ReadLine();
                    Console.WriteLine("Ingrese la nueva dirección del cliente:");
                    client.direction = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo teléfono del cliente:");
                    client.phone = Console.ReadLine();
                    Console.WriteLine("Ingrese la nueva cédula del cliente:");
                    client.id = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Cliente editado");
                    Console.WriteLine("");
                    Console.WriteLine("Nombre: " + client.name);
                    Console.WriteLine("Dirección: " + client.direction);
                    Console.WriteLine("Teléfono: " + client.phone);
                    Console.WriteLine("Cédula: " + client.id);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("El cliente no existe");
                }
            }

        }

        public void deleteClient(string id)
        {
            Console.Clear();

            Console.WriteLine("Está seguro que desea eliminar el cliente? (s/n)");
            String answer = Console.ReadLine();

            if (answer == "s")
            {
                foreach (Clients client in clients)
                {
                    if (client.id == id)
                    {
                        clients.Remove(client);
                        Console.WriteLine("Cliente eliminado");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El cliente no existe");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se eliminó el cliente");
            }
        }
    }

}