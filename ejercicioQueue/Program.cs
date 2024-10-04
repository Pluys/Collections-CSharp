using System.Runtime.CompilerServices;

class Progam
{
    static void Main()
    {
        Queue<string> cola = new Queue<string>();
        bool menu = true;
        string desicion = "";

        while(menu)
        {
            Console.WriteLine("Menu\n" +
                "0. Salir\n" +
                "1. Agregar cliente a la cola\n" +
                "2. Atender primer cliente\n" +
                "3. Mostrar cola de clientes");

            desicion = Console.ReadLine();

            switch (desicion)
            {
                case "0":
                    menu = false;

                    EndMenu();
                    break;

                case "1":
                    Console.WriteLine("Tirame un nuevo cliente");
                    cola.Enqueue(Console.ReadLine());

                    EndMenu();
                    break;

                case "2":
                    if(cola.Count() > 0)
                    {
                        Console.WriteLine($"{cola.Dequeue()} a recibido la atencion necesaria.");
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes a atender.");
                    }

                    EndMenu();
                    break;

                case "3":
                    if(cola.Count() > 0)
                    {
                        Console.WriteLine("Clientes a atender en orden de prioridad:");
                        foreach (string cliente in cola)
                        {
                            Console.WriteLine(cliente);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes en la cola.");
                    }

                    EndMenu();
                    break;

                default:

                    EndMenu();
                    break;
            }
        }

        static void EndMenu()
        {
            Console.WriteLine("\nPresione cualquier boton para confirmar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}