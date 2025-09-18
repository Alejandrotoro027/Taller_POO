using System;

namespace Taller01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese orden de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            MatrizOperaciones matrizOp = new MatrizOperaciones(n);

            matrizOp.MostrarMatriz();

            Console.WriteLine($"La sumatoria es: {matrizOp.Sumatoria()}");
            Console.WriteLine($"El valor máximo es: {matrizOp.Maximo()}");
            Console.WriteLine($"El valor mínimo es: {matrizOp.Minimo()}");
        }
    }
}
