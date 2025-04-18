using Ejercicios.Algoritmia.HackerRank.SimpleSumaArreglo;

namespace Ejercicios.Pruebas.Algoritmia.HackerRank.SimpleSumaArregloPrueba
{
    public class SimpleSumaArregloPrueba
    {
        private readonly SimpleSumaArreglo simpleSumaArreglo;
        private readonly List<int> primerArreglo;

        public SimpleSumaArregloPrueba()
        {
            simpleSumaArreglo = new SimpleSumaArreglo();
            primerArreglo = [1, 2, 3, 4, 10, 11];
        }

        [Test]
        public void PruebaDebeSerCincoCuandoUsamosElPrimerArreglo()
        {
            Assert.That(simpleSumaArreglo.Sumar(primerArreglo), Is.EqualTo(31));
        }
    }
}
