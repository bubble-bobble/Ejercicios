# Gran suma

## Enunciado

Necitas calcular la suma de los elementos en un arreglo, considerando que algunos enteros pueden ser muy grandes.

### Descripción de la función

Completa la función “Gran suma”, la cual recibe los siguientes parámetros:

- `int ar[n]`: un arreglo de enteros

Retorna

- `long`: la suma de los elementos del arreglo

### Formato de entrada

La primera línea consiste en un entero **n**, las siguientes líneas contienen n enteros separados por un espacio.

### Formato de salida

Retorna un entero la suma de los elementos en el arreglo

### Restricciones

1 ≤ **n** ≤ 10

0 ≤ **ar[i]** ≤ 10^10

### Ejemplo de entrada

```
Entrada                                                 Función
-----                                                   --------
5                                                       ar[] tamaño n = 5
1000000001 1000000002 1000000003 1000000004 1000000005  ar[...]
```

### Ejemplo de salida

```
5000000015
```

## Resolución

- C#
    
    Algoritmo
    
    ```csharp
    using System.Collections.Generic;
    
    namespace Ejercicios.Algoritmia.HackerRank.GranSuma
    {
        public class GranSuma
        {
            public long Sumar(List<long> ar)
            {
                long result = 0;
                for (int i = 0; i < ar.Count; i++)
                {
                    result += ar[i];
                }
                return result;
            }
        }
    }
    
    ```
    
    Prueba unitaria
    
    ```csharp
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
    
    ```