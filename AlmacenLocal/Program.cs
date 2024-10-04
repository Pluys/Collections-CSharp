class Program
{
    class Producto
    {
        private int _codigoProducto;
        private string _nombreProducto;
        private int _stockProducto;

        public int CodigoProducto
        {
            get { return _codigoProducto; }
            set {  _codigoProducto = value; }
        }

        public string NombreProducto
        {
            get { return _nombreProducto; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombreProducto = value;
                }
            }
        }

        public int StockProducto
        {
            get { return _stockProducto; }
            set { _stockProducto = value; }
        }

        public Producto(int codigoProducto, string nombreProducto, int stockProducto)
        {
            _codigoProducto = codigoProducto;
            _nombreProducto = nombreProducto;
            _stockProducto = stockProducto;
        }

        public override string ToString()
        {
            return $"{_codigoProducto}, {_nombreProducto}, Stock: {_stockProducto}";
        }
    }

    static void Main()
    {
        List<Producto> productos = new List<Producto>();
        int codigoProductos = 1;

        bool menu = true;
        string desicion = "";

        while (menu)
        {
            Console.WriteLine("Menu\n" +
                "0. Salir\n" +
                "1. Agregar nuevo producto\n" +
                "2. Actualizar stock de un producto\n" +
                "3. Mostrar productos en stock");

            desicion = Console.ReadLine();

            switch (desicion)
            {
                case "0":
                    menu = false;

                    EndMenu();
                    break;

                case "1":
                    Console.Write("Tirame el nombre del producto: ");
                    string nombreProducto = Console.ReadLine();

                    Console.Write("Tirame el stock del producto: ");
                    int stockProducto = int.Parse(Console.ReadLine());

                    productos.Add(new Producto(codigoProductos, nombreProducto, stockProducto));

                    codigoProductos++;
                    EndMenu();
                    break;

                case "2":
                    Console.Write("Escriba el codigo del producto al cual desea cambiar el stock: ");
                    int codigoUsuario = int.Parse(Console.ReadLine());

                    foreach(Producto producto in productos)
                    {
                        if(producto.CodigoProducto == codigoUsuario)
                        {
                            Console.WriteLine($"Stock actual: {producto.StockProducto}");
                            Console.Write("Escriba el nuevo valor de el stock: ");
                            int stockUsuario = int.Parse(Console.ReadLine());

                            producto.StockProducto = stockUsuario;
                            Console.WriteLine("Stock cambiado exitosamente.");
                            break;
                        }
                    }

                    EndMenu();
                    break;

                case "3":
                    Console.WriteLine("Productos con stock disponible:");
                    foreach(Producto producto in productos)
                    {
                        Console.WriteLine(producto);
                    }

                    EndMenu();
                    break;

                default:

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