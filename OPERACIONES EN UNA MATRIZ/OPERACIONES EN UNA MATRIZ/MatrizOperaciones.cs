using System;

namespace Taller01
{
    public class MatrizOperaciones
    {
        private int[,] matriz;
        private int n;

        public MatrizOperaciones(int n)
        {
            this.n = n;
            matriz = new int[n, n];
            LlenarMatriz();
        }

        private void LlenarMatriz()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = (i + 1) - j;
                }
            }
        }

        public void MostrarMatriz()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int Sumatoria()
        {
            int suma = 0;
            foreach (int valor in matriz)
            {
                suma += valor;
            }
            return suma;
        }
        public int Maximo()
        {
            int max = matriz[0, 0];
            foreach (int valor in matriz)
            {
                if (valor > max) max = valor;
            }
            return max;
        }

        public int Minimo()
        {
            int min = matriz[0, 0];
            foreach (int valor in matriz)
            {
                if (valor < min) min = valor;
            }
            return min;
        }
    }
}
