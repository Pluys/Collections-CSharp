class Program
{
    static void Main()
    {
        Stack<string> paginas = new Stack<string>();
        string pagina = "";
        bool menu = true;
        string desicion = "";

        Console.WriteLine("Que onda kpo");
        while (menu)
        {
            Console.WriteLine("Menu\n" +
                "1.Agregar pagina al historial\n" +
                "2.Retroceder a la pagina anterior\n" +
                "3.Mostrar historial de paginas");

            desicion = Console.ReadLine();

            switch (desicion)
            {
                case "1":
                    Console.WriteLine("Tirame que pagina visitaste");
                    pagina = Console.ReadLine();
                    paginas.Push(pagina);

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case "2":
                    if(paginas.Count > 0)
                    {
                        Console.WriteLine($"estas yendote de {paginas.Pop()}");
                    }
                    else
                    {
                        Console.WriteLine("No tenemos historial.");
                    }

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "3":
                    Console.WriteLine("Historial (Incluyendo pagina actual)");
                    foreach (string paginaHistorial in paginas)
                    {
                        Console.WriteLine(paginaHistorial);
                    }
                    Console.ReadKey();
                    Console.Clear();

                    break;

                default:

                    Console.Clear();
                    break;
            }
        }
    }
}