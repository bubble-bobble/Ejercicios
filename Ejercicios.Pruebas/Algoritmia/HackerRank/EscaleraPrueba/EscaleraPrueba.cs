using Ejercicios.Algoritmia.HackerRank.Escalera;

namespace Ejercicios.Pruebas.Algoritmia.HackerRank.EscaleraPrueba
{
    public class EscaleraPrueba
    {
        private readonly Escalera escalera;

        public EscaleraPrueba()
        {
            escalera = new Escalera();
        }

        [Test]
        public void PruebaDebeDibujarEscaleraDeTresPorTres()
        {
            var resultado = escalera.Dibujar(3);
            Assert.That(resultado, Is.EqualTo("  #\n ##\n###"));
        }
    }
}
