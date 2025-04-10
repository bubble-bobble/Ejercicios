using Ejercicios.Algoritmia.HackerRank.ResuelvemePrimero;

namespace Ejercicios.Pruebas.Algoritmia.HackerRank.ResuelvemePrimeroPrueba
{
    public class ResuelvemePrimeroTest
    {
        private readonly ResuelvemePrimero resuelvemePrimero;

        public ResuelvemePrimeroTest()
        {
            resuelvemePrimero = new ResuelvemePrimero();
        }

        [Test]
        public void PruebaDebeSerCincoCuandoLosNumerosSonDosYTres()
        {
            Assert.That(resuelvemePrimero.Sumar(2, 3), Is.EqualTo(5));
        }
    }
}
