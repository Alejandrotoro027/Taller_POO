using System;
using System.Collections.Generic;

namespace Taller01
{
    public class Factorizacion
    {
        private int numero;

        public Factorizacion(int numero)
        {
            if (numero <= 1)
                throw new ArgumentException("El número debe ser mayor que 1.");

            this.numero = numero;
        }

        public List<int> ObtenerFactores()
        {
            List<int> factores = new List<int>();
            int n = numero;

            while (n % 2 == 0)
            {
                factores.Add(2);
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    factores.Add(i);
                    n /= i;
                }
            }

            if (n > 1)
            {
                factores.Add(n);
            }

            return factores;
        }
        public string MostrarFactores()
        {
            var factores = ObtenerFactores();
            return $"{numero} = {string.Join(" × ", factores)}";
        }
    }
}
