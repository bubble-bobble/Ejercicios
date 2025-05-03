using Ejercicios.Algoritmia.HackerRank.GranSuma;

namespace Ejercicios.Pruebas.Algoritmia.HackerRank.GranSumaPrueba
{
    public class GranSumaPrueba
    {
        private readonly GranSuma granSuma;
        private readonly List<long> primerArreglo = [1_000_000_001, 1_000_000_002,
                1_000_000_003, 1_000_000_004, 1_000_000_005];
        private readonly long primerResultadoEsperado = 5_000_000_015;

        public GranSumaPrueba()
        {
            granSuma = new GranSuma();
        }

        [Test]
        public void PruebaDebeSerIgualAlPrimerResultadoEsperadoCuandoUsamosElPrimerArreglo()
        {
            Assert.That(granSuma.Sumar(primerArreglo), Is.EqualTo(primerResultadoEsperado));
        }
    }
}
