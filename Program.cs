using System.Collections;
using CSharp_taller2;

clientsService clientsService = new clientsService();
productsService productsService = new productsService();

Console.WriteLine("*****************************");
Console.WriteLine("** Bienvenido a JuandiTech **");
Console.WriteLine("*****************************");
Console.WriteLine("");
Console.WriteLine("");

/* ? Se pide el nombre de la empresa */

Console.WriteLine("Para empezar, ingrese el nombre de la empresa");
string companyName = Console.ReadLine();

/* Confirmar nombre */
Console.WriteLine("");
Console.WriteLine("¿Está seguro que desea crear la empresa " + companyName + "?");
Console.WriteLine("");
Console.WriteLine("Presione 's' para confirmar, o cualquier otra tecla para cancelar");
string confirm = Console.ReadLine();

/* Si la respues es s sigue con la ejecucion del programa, sino vuelve a preguntar el nombre de la empresa y vuelve a confirmar*/
int execute = 0;

while (execute == 0)
{
    if (confirm == "s")
    {
        Console.WriteLine("Empresa creada");
        execute = 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese el nombre de la empresa");
        companyName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("¿Está seguro que desea crear la empresa " + companyName + "?");
        Console.WriteLine("");
        Console.WriteLine("Presione 's' para confirmar, o cualquier otra tecla para cancelar");
        confirm = Console.ReadLine();
    }
}

/* Valida que el dato ingresado sea un número y lo guarda en la variable option */
Console.WriteLine("Por favor ingrese el módulo al que desea acceder o ingrese '0' para salir");
Console.WriteLine("1. Módulo de clientes");
Console.WriteLine("2. Módulo de productos");
Console.WriteLine("3. Módulo de ventas");
Console.WriteLine("4. Módulo de reportes");
Console.WriteLine("5. Módulo de configuración");



int option = 0;
while (option == 0)
{
    try
    {
        option = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("");
        Console.WriteLine("Por favor ingrese un número");
    }
}

/* Menu de opciones dependiendo del modulo, siempre se ejecuta y puede volver atras si entra a uno de los modulos */
while (option != 0)
{
    switch (option)
    {
        // ***************************************** Modulo de clientes *******************************************************************************
        case 1:

            Clients client = new Clients();

            Console.WriteLine("");
            Console.WriteLine("*****************************");
            Console.WriteLine("**   Módulo de Clientes    **");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese la acción que desea realizar");
            Console.WriteLine("");
            Console.WriteLine("1. Crear cliente");
            Console.WriteLine("2. Buscar clientes");
            Console.WriteLine("3. Actualizar cliente");
            Console.WriteLine("4. Eliminar cliente");

            int optionClient = 0;

            /* Validación */
            while (optionClient == 0)
            {
                try
                {
                    optionClient = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Por favor ingrese un número");
                }
            }

            /* Crear cliente */
            if (optionClient == 1)
            {

                Console.WriteLine("");
                Console.WriteLine("Ingrese el nombre del cliente:");
                client.name = Console.ReadLine();
                Console.WriteLine("Ingrese el dirección del cliente:");
                client.direction = Console.ReadLine();

                /* Valida que el telefono y la cedula sean numeros */
                Console.WriteLine("Ingrese el teléfono del cliente:");
                int phone = 0;
                while (phone == 0)
                {
                    try
                    {
                        phone = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }
                client.phone = phone.ToString();

                Console.WriteLine("Ingrese la cedula del cliente:");
                int id = 0;
                while (id == 0)
                {
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }
                client.id = id.ToString();

                /* Confirmar datos */
                Console.WriteLine("");
                Console.WriteLine("Cliente ingresado");
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + client.name);
                Console.WriteLine("Dirección: " + client.direction);
                Console.WriteLine("Teléfono: " + client.phone);
                Console.WriteLine("Cédula: " + client.id);
                Console.WriteLine("");
                Console.WriteLine(
                    "Presione 's' para confirmar, o cualquier otra tecla para cancelar"
                );
                string confirmClient = Console.ReadLine();

                int executeClient = 0;

                while (executeClient == 0)
                {
                    if (confirmClient == "s")
                    {
                        clientsService.addClient(client);
                        executeClient = 1;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el nombre del cliente:");
                        client.name = Console.ReadLine();
                        Console.WriteLine("Ingrese el dirección del cliente:");
                        client.direction = Console.ReadLine();
                        Console.WriteLine("Ingrese el teléfono del cliente:");
                        client.phone = Console.ReadLine();
                        Console.WriteLine("Ingrese la cedula del cliente:");
                        client.id = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("Cliente ingresado");
                        Console.WriteLine("");
                        Console.WriteLine("Nombre: " + client.name);
                        Console.WriteLine("Dirección: " + client.direction);
                        Console.WriteLine("Teléfono: " + client.phone);
                        Console.WriteLine("Cédula: " + client.id);

                        Console.WriteLine("");
                        Console.WriteLine("¿Está seguro que desea crear el cliente?");

                        Console.WriteLine(
                            "Presione 's' para confirmar, o cualquier otra tecla para cancelar"
                        );
                        confirmClient = Console.ReadLine();
                    }
                }
            }
            /* Buscar cliente por cedula */
            else if (optionClient == 2)
            {
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("Ingrese la cedula del cliente:");
                /* Valida que el dato ingresado sea un número */
                int id = 0;
                while (id == 0)
                {
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }

                clientsService.findClient(id.ToString());
            }
            /* Editar cliente */
            else if (optionClient == 3)
            {
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("Ingrese la cédula del cliente que desea editar: ");
                int id = 0;
                while (id == 0)
                {
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }

                clientsService.editClient(id.ToString());
            }
            else if (optionClient == 4)
            {
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("Ingrese la cédula del cliente que desea eliminar: ");
                int id = 0;
                while (id == 0)
                {
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }

                clientsService.deleteClient(id.ToString());
            }
            else if (optionClient == 5)
            {
                Console.Clear();

                clientsService.showClients();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor ingrese una opción válida");
            }
            break;
        // *****************************************/ / / Modulo de clientes / / / *******************************************************************************

        // *****************************************/ / / Modulo de productos / / / *******************************************************************************
        case 2:

            Products product = new Products();

            Console.WriteLine("");
            Console.WriteLine("*****************************");
            Console.WriteLine("**   Módulo de Productos    **");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese la acción que desea realizar");
            Console.WriteLine("");
            Console.WriteLine("1. Crear producto");
            Console.WriteLine("2. Buscar productos");
            Console.WriteLine("3. Actualizar producto");
            Console.WriteLine("4. Eliminar producto");

            int optionProduct = 0;

            while (optionProduct == 0)
            {
                try
                {
                    optionProduct = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Por favor ingrese un número");
                }
            }

            /* Crear producto */
            if (optionProduct == 1)
            {

                Console.WriteLine("");
                Console.WriteLine("Ingrese el nombre del producto:");
                product.name = Console.ReadLine();

                Console.WriteLine("Ingrese el precio del producto:");
                int price = 0;
                while (price == 0)
                {
                    try
                    {
                        price = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }
                product.price = price;

                Console.WriteLine("Ingrese la cantidad del producto:");
                int stock = 0;
                while (stock == 0)
                {
                    try
                    {
                        stock = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }
                product.stock = stock;

                Console.WriteLine("Ingrese el código del producto:");
                int code = 0;
                while (code == 0)
                {
                    try
                    {
                        code = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }
                product.id = code;

                /* Confirmar datos */
                Console.WriteLine("");
                Console.WriteLine("Producto agregado:  ");
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + product.name);
                Console.WriteLine("Precio: " + product.price);
                Console.WriteLine("Cantidad: " + product.stock);
                Console.WriteLine("Código: " + product.id);
                Console.WriteLine("");
                Console.WriteLine(
                    "Presione 's' para confirmar, o cualquier otra tecla para cancelar"
                );
                string confirmProduct = Console.ReadLine();

                int executeProduct = 0;

                while (executeProduct == 0)
                {
                    if (confirmProduct == "s")
                    {
                        productsService.addProducts(product);
                        executeProduct = 1;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el nombre del producto:");
                        product.name = Console.ReadLine();

                        Console.WriteLine("Ingrese el precio del producto:");
                        price = 0;
                        while (price == 0)
                        {
                            try
                            {
                                price = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Por favor ingrese un número");
                            }
                        }
                        product.price = price;

                        Console.WriteLine("Ingrese la cantidad del producto:");
                        stock = 0;
                        while (stock == 0)
                        {
                            try
                            {
                                stock = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Por favor ingrese un número");
                            }
                        }
                        product.stock = stock;

                        Console.WriteLine("Ingrese el código del producto:");
                        code = 0;
                        while (code == 0)
                        {
                            try
                            {
                                code = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Por favor ingrese un número");
                            }
                        }
                        product.id = code;

                        Console.WriteLine("Producto ingresado");
                        Console.WriteLine("");
                        Console.WriteLine("Nombre: " + product.name);
                        Console.WriteLine("Precio: " + product.price);
                        Console.WriteLine("Cantidad: " + product.stock);
                        Console.WriteLine("Código: " + product.id);


                        Console.WriteLine("");
                        Console.WriteLine(
                            "Presione 's' para confirmar, o cualquier otra tecla para cancelar"
                        );
                        confirmProduct = Console.ReadLine();
                    }

                }
            }
            else if(optionProduct == 2){
                
            }

            else if (optionProduct == 5)
            {

                productsService.showProducts();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor ingrese una opción válida");
            }



            break;
    }
}
