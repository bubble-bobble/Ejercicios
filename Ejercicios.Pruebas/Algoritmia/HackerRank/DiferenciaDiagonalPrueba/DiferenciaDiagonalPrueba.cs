using Ejercicios.Algoritmia.HackerRank.DiferenciaDiagonal;

namespace Ejercicios.Pruebas.Algoritmia.HackerRank.DiferenciaDiagonalPrueba
{
    public class DiferenciaDiagonalPrueba
    {
        private readonly DiferenciaDiagonal diferenciaDiagonal;
        private readonly List<List<int>> primeraMatriz;

        public DiferenciaDiagonalPrueba()
        {
            diferenciaDiagonal = new DiferenciaDiagonal();
            primeraMatriz =
            [
                [11, 2, 4],
                [4, 5, 6],
                [10, 8, -12],
            ];
        }

        [Test]
        public void PruebaDebeSerQuinceCuandoUsamosLaPrimeraMatriz()
        {
            Assert.That(diferenciaDiagonal.Calcular(primeraMatriz), Is.EqualTo(15));
        }
    }
}
