class Program
{
    //SUBIR CODIGO
    class AnaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias
    {
        private int _id;
        private string _tarea;
        private bool _estadoTarea;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Tarea
        {
            get { return _tarea; }
            set { _tarea = value; }
        }

        public bool EstadoTarea
        {
            get { return _estadoTarea; }
            set { _estadoTarea = value; }
        }

        public AnaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias(int id, string tarea)
        {
            _id = id;
            _tarea = tarea;
            EstadoTarea = false;
        }

        public override string ToString()
        {
            return $"Tarea: {_tarea}";
        }
    }

    static void Main()
    {
        int idTareas = 0;
        List<AnaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias> tareas = new List<AnaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias>();

        bool menu = true;
        string desicion = "";

        while(menu)
        {
            Console.WriteLine("Menu\n" +
                "0. Salir\n" +
                "1. Agregar nueva tarea\n" +
                "2. Marcar tarea como completada\n" +
                "3. Mostrar todas las tareas pendientes");

            desicion = Console.ReadLine();

            switch(desicion)
            {
                case "0":
                    menu = false;

                    EndMenu();
                    break;

                case "1":
                    Console.Write("Escriba la tarea a agregar: ");
                    string nuevaTarea = Console.ReadLine();

                    tareas.Add(new AnaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias(idTareas, nuevaTarea));
                    idTareas++;

                    EndMenu();
                    break;

                case "2":
                    Console.WriteLine("Escriba el id de la tarea que desea marcar como completa.");
                    int idUsuario = int.Parse(Console.ReadLine());

                    foreach(AnaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias anaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias in tareas)
                    {
                        if(anaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias.Id == idUsuario)
                        {
                            anaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias.EstadoTarea = true;
                        }
                    }

                    EndMenu();
                    break;

                case "3":
                    foreach(AnaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias anaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias in tareas)
                    {
                        if(anaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias.EstadoTarea == false)
                        {
                            Console.WriteLine($"Id: {anaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias.Id} | " + anaEsUnaPersonaMuyOrganizadaYUtilizaUnaListaDeTareasParaSeguirSusActividadesDiarias + " | Estado: Incompleta");
                        }
                    }

                    EndMenu();
                    break;
            }
        }

        static void EndMenu()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}