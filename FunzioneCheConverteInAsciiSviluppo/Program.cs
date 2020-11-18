using System;

namespace FunzioneCheConverteInAsciiSviluppo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inserisci un carattere: ");
            char input = char.Parse(Console.ReadLine());
            int value = Convert.ToInt32(input);
            Console.WriteLine($"decimal value of {input} is {value}");
            string hexOutput = String.Format("{0:X}", value);
            Console.WriteLine($"Hexadecimal value of {input} is {hexOutput}");
            string octave = Convert.ToString(input, 8);
            Console.WriteLine($"octave value of {input} is {octave}");
            string binary = Convert.ToString(input, 2);
            Console.WriteLine($"binary value of {input} is {binary}");
        }
    }
}
