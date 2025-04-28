using System.Collections.Generic;

namespace Ejercicios.Algoritmia.HackerRank.CompararTripletas
{
    public class CompararTripletas
    {
        public List<int> Comparar(List<int> a, List<int> b)
        {
            int alicePoints = 0;
            int bobPoints = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alicePoints++;
                }
                if (b[i] > a[i])
                {
                    bobPoints++;
                }
            }
            return [alicePoints, bobPoints];
        }
    }
}
