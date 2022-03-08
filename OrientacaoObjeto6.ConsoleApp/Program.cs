using System;

namespace OrientacaoObjeto6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celcius Converter = new Celcius();
            Converter.C = 22;
            Console.WriteLine($"{Converter.C}° graus celcius é a mesma coisa que {Converter.conversao():F2}° graus em Fahrenheit");
            Console.ReadKey();
        }
    }
}
