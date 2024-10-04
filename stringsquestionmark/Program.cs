class Program
{
    static void Main()
    {
        Stack<char> stack = new Stack<char>();
        string cadenaUsuario = Console.ReadLine();

        for (int i = 0; i < cadenaUsuario.Length; i++)
        {
            stack.Push(cadenaUsuario[i]);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
    }
}
