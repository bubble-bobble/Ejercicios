using System;
using System.Collections.Generic;

namespace Ejercicios.Algoritmia.HackerRank.DiferenciaDiagonal
{
    public class DiferenciaDiagonal
    {
        public int Calcular(List<List<int>> arr)
        {
            int diagonalLeftToRight = 0;
            int diagonalRightToLeft = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                diagonalLeftToRight += arr[i][i];
                diagonalRightToLeft += arr[i][^(i + 1)];
            }
            return Math.Abs(diagonalLeftToRight - diagonalRightToLeft);
        }
    }
}
