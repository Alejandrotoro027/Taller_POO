using System;

namespace Taller01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número a descomponer: ");
            int num = int.Parse(Console.ReadLine());

            try
            {
                Factorizacion fact = new Factorizacion(num);
                Console.WriteLine(fact.MostrarFactores());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
