using System.Collections.Generic;

namespace Ejercicios.Algoritmia.HackerRank.GranSuma
{
    public class GranSuma
    {
        public long Sumar(List<long> ar)
        {
            long result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                result += ar[i];
            }
            return result;
        }
    }
}
