using System;

namespace FunzioneCheConverteInAsciiSviluppo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ascii;
            int num;
            Console.Write("inserisci il codice di una lettera: ");
            num = Convert.ToInt32(Console.ReadLine());
            ascii = Convert.ToChar(num);
            Console.WriteLine($"{ascii}");
            Console.ReadLine();
        }
        
    }
}
