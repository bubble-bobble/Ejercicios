using System.Text;

namespace Ejercicios.Algoritmia.HackerRank.Escalera
{
    public class Escalera
    {
        public string Dibujar(int n)
        {
            StringBuilder escalera = new();
            for (int i = 1; i <= n; i++)
            {
                escalera.Append(new string(' ', n - i));
                escalera.Append(new string('#', i));
                if (i < n) escalera.Append('\n');
            }
            return escalera.ToString();
        }
    }
}
