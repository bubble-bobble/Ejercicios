using System.Collections.Generic;

namespace Ejercicios.Algoritmia.HackerRank.SimpleSumaArreglo
{
    public class SimpleSumaArreglo
    {
        public int Sumar(List<int> ar)
        {
            int suma = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                suma += ar[i];
            }
            return suma;
        }
    }
}
