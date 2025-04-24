using Ejercicios.Algoritmia.HackerRank.ResuelvemePrimero;

namespace Ejercicios.Pruebas.Algoritmia.HackerRank.ResuelvemePrimeroPrueba
{
    public class ResuelvemePrimeroPrueba
    {
        private readonly ResuelvemePrimero resuelvemePrimero;

        public ResuelvemePrimeroPrueba()
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
