using Ejercicios.Algoritmia.HackerRank.CompararTripletas;

namespace Ejercicios.Pruebas.Algoritmia.HackerRank.CompararTripletasPrueba
{
    public class CompararTripletasPrueba
    {
        private readonly CompararTripletas compararTripletas;
        private readonly List<int> primerArreglo;
        private readonly List<int> segundoArreglo;
        private static readonly int[] resultadoEsperado = [1, 1];

        public CompararTripletasPrueba()
        {
            compararTripletas = new CompararTripletas();
            primerArreglo = [5, 6, 7];
            segundoArreglo = [3, 6, 10];
        }

        [Test]
        public void PruebaDebeSerUnoYUnoCuandoUsamosLosPrimerosDosArreglos()
        {
            Assert.That(compararTripletas.Comparar(primerArreglo, segundoArreglo), Is.EqualTo(resultadoEsperado));
        }
    }
}
