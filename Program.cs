using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o raio do circulo.");
            double raio = double.Parse(Console.ReadLine());

            double area = raio * raio * 3.14159;
            Console.WriteLine("A= " + area.ToString("F4", CI));
        }
    }
}