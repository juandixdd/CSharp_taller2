using System.Collections;
clientsService clientsService = new clientsService();




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

    while (execute == 0){
        if (confirm == "s"){
            Console.WriteLine("Empresa creada");
            execute = 1;
        }
        else{
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

    int option = 0;
    while (option == 0){
        try{
            option = int.Parse(Console.ReadLine());
        }
        catch{
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese un número");
        }
    }

    /* Menu de opciones dependiendo del modulo, siempre se ejecuta y puede volver atras si entra a uno de los modulos */
    while (option != 0){
        switch(option){
            // ***************************************** Modulo de clientes *******************************************************************************
            case 1: 

            
                Client client = new Client();

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
                while (optionClient == 0){
                    try{
                        optionClient = int.Parse(Console.ReadLine());
                    }
                    catch{
                        Console.WriteLine("");
                        Console.WriteLine("Por favor ingrese un número");
                    }
                }

                /* Crear cliente */
                if (optionClient == 1){
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nombre del cliente:");
                    client.name = Console.ReadLine();
                    Console.WriteLine("Ingrese el dirección del cliente:");
                    client.direction = Console.ReadLine();

                    /* Valida que el telefono y la cedula sean numeros */
                    Console.WriteLine("Ingrese el teléfono del cliente:");
                    int phone = 0;
                    while (phone == 0){
                        try{
                            phone = int.Parse(Console.ReadLine());
                        }
                        catch{
                            Console.WriteLine("");
                            Console.WriteLine("Por favor ingrese un número");
                        }
                    }
                    client.phone = phone.ToString();

                    Console.WriteLine("Ingrese la cedula del cliente:");
                    int id = 0;
                    while (id == 0){
                        try{
                            id = int.Parse(Console.ReadLine());
                        }
                        catch{
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
                    Console.WriteLine("Presione 's' para confirmar, o cualquier otra tecla para cancelar");
                    string confirmClient = Console.ReadLine();

                    int executeClient = 0;

                    while (executeClient == 0){
                        if (confirmClient == "s"){
                            clientsService.addClient(client);
                            Console.WriteLine("Cliente creado");
                            executeClient = 1;

                            
                        }
                        else{
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
                            
                            Console.WriteLine("Presione 's' para confirmar, o cualquier otra tecla para cancelar");
                            confirmClient = Console.ReadLine();
                        }
                    }

                }
                /* Buscar cliente por cedula */
                else if(optionClient == 2){
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cedula del cliente:");
                    /* Valida que el dato ingresado sea un número */
                    int id = 0;
                    while (id == 0){
                        try{
                            id = int.Parse(Console.ReadLine());
                        }
                        catch{
                            Console.WriteLine("");
                            Console.WriteLine("Por favor ingrese un número");
                        }
                    }

                    clientsService.findClient(id.ToString());

                }
                /* Editar cliente */
                else if(optionClient == 3){

                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cédula del cliente que desea editar: ");
                    int id = 0;
                    while (id == 0){
                        try{
                            id = int.Parse(Console.ReadLine());
                        }
                        catch{
                            Console.WriteLine("");
                            Console.WriteLine("Por favor ingrese un número");
                        }
                    }

                    clientsService.editClient(id.ToString());
                }
                else if(optionClient == 4){
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cédula del cliente que desea eliminar: ");
                    int id = 0;
                    while (id == 0){
                        try{
                            id = int.Parse(Console.ReadLine());
                        }
                        catch{
                            Console.WriteLine("");
                            Console.WriteLine("Por favor ingrese un número");
                        }
                    }

                    clientsService.deleteClient(id.ToString());
                }
                else if(optionClient == 5){
                    clientsService.showClients();
                }
                else{
                    Console.WriteLine("");
                    Console.WriteLine("Por favor ingrese una opción válida");
                }
                break;
                // *****************************************/ / / Modulo de clientes / / / *******************************************************************************

        }
    }


// **************************************************  CLASES  ****************************************************************

/* ? Clase de cliente */
class Client
{
    public string name;
    public string direction;
    public string phone;
    public string id;
}

/* ? Servicios de cliente */
class clientsService
{
    ArrayList clients = new ArrayList();

    public void addClient(Client client)
    {
        clients.Add(client);
        Console.WriteLine("Cliente agregado");
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
            foreach (Client client in clients)
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
        foreach (Client client in clients)
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
        Console.WriteLine("");
        foreach(Client client in clients)
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
            foreach (Client client in clients)
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

