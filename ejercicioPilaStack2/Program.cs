using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tirame un textito genio");
        string texto = Console.ReadLine();
        texto.ToLower();

        IDictionary<string, int> contadorPalabras = new Dictionary<string, int>();

        //hola holak;

        Console.WriteLine(holak);
        string[] palabras = texto.Split(' ');

        foreach(string palabra in palabras)
        {
            if(contadorPalabras.ContainsKey(palabra))
            {
                contadorPalabras[palabra]++;
            }
            else
            {
                contadorPalabras.Add(palabra, 1);
            }
        }

        Console.WriteLine("Frecuencia de palabras: ");
        foreach(var cama in contadorPalabras)
        {
            Console.WriteLine($"{cama.Key}: {cama.Value}");
        }
    }
}