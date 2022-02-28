using System.Collections;

namespace CSharp_taller2
{
    class clientsService
    {
        ArrayList clients = new ArrayList();

        public void addClient(Clients client)
        {
            Boolean exist = false;

            foreach (Clients item in clients)
            {
                if (item.id == client.id)
                {
                    exist = true;
                }
                else
                {
                    exist = false;
                }
            }

            if (exist == false)
            {
                clients.Add(client);
            }
            else
            {
                Console.WriteLine("El cliente ya existe");
            }
        }

        public void showClients()
        {
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

        public Boolean findClient(string id)
        {
            Boolean clientExist = false;

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
                    clientExist = true;
                }
                else
                {
                    Console.WriteLine("El cliente no existe");
                    clientExist = false;
                }
            }
            return clientExist;
        }

        public void editClient(string id)
        {

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

    class productsService
    {
        ArrayList products = new ArrayList();

        public void addProducts(Products product)
        {
            Boolean exist = false;

            foreach (Products item in products)
            {
                if (item.id == product.id)
                {
                    exist = true;
                }
                else
                {
                    exist = false;
                }
            }

            if (exist == false)
            {
                products.Add(product);
            }
            else
            {
                Console.WriteLine("El producto ya existe");
            }
        }

        public void showProducts()
        {
            Console.WriteLine("************************");
            Console.WriteLine("** Lista de productos: **");
            Console.WriteLine("************************");

            if (products.Count == 0)
            {
                Console.WriteLine("No hay productos");
            }
            else
            {
                foreach (Products product in products)
                {
                    Console.WriteLine("Nombre: " + product.name);
                    Console.WriteLine("     - Precio: " + product.price);
                    Console.WriteLine("     - Stock: " + product.stock);
                    Console.WriteLine("     - Id: " + product.id);
                    Console.WriteLine("***************************************************");
                }
            }

        }

        /* public Boolean findClient(string id)
        {
            Boolean clientExist = false;

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
                    clientExist = true;
                }
                else
                {
                    Console.WriteLine("El cliente no existe");
                    clientExist = false;
                }
            }
            return clientExist;
        } */

        public Boolean findProduct(string id){
            Boolean productExist = false;

            foreach (Products product in products)
            {
                if (product.id.ToString() == id)
                {
                    Console.WriteLine("************************");
                    Console.WriteLine("** Producto **");
                    Console.WriteLine("Nombre: " + product.name);
                    Console.WriteLine("     - Precio: " + product.price);
                    Console.WriteLine("     - Stock: " + product.stock);
                    Console.WriteLine("     - Id: " + product.id);
                    Console.WriteLine("***************************************************");
                    productExist = true;
                }
                else
                {
                    Console.WriteLine("El producto no existe");
                    productExist = false;
                }
            }
            return productExist;
        }

        public void editProduct(string id)
        {

            Console.WriteLine("");
            foreach (Products product in products)
            {
                if (product.id.ToString() == id)
                {
                    Console.WriteLine("Ingrese el nuevo nombre del producto:");
                    product.name = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo precio del producto:");
                    product.price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo stock del producto:");
                    product.stock = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo id del producto:");
                    product.id = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Producto editado");
                    Console.WriteLine("");
                    Console.WriteLine("Nombre: " + product.name);
                    Console.WriteLine("Precio: " + product.price);
                    Console.WriteLine("Stock: " + product.stock);
                    Console.WriteLine("Id: " + product.id);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("El producto no existe");
                }
            }

        }

        public void deleteProduct(string id){
            Console.WriteLine("Está seguro que desea eliminar el producto? (s/n)");
            String answer = Console.ReadLine();

            if (answer == "s")
            {
                foreach (Products product in products)
                {
                    if (product.id.ToString() == id)
                    {
                        products.Remove(product);
                        Console.WriteLine("Producto eliminado");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El producto no existe");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se eliminó el producto");
            }
        }
    }
}