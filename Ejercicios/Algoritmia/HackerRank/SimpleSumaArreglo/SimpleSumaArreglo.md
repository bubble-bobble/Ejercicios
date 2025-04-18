# Simple suma arreglo

## Enunciado

Dado un arreglo de enteros, encuentra la suma de sus elementos.

Por ejemplo, si el arreglo **ar = [1, 2 , 3], 1 + 2 + 3 = 6**, entonces retorna 6.

### Descripción de la función

Completa la función “**Simple suma arreglo**”, la cual recibe los siguientes parámetros:

- **ar[n]**: un arreglo de enteros

Retorna

- `int`: la suma de los elementos del arreglo

### Formato de entrada

La primera línea contiene un entero, **n**, denota el tamaño del arreglo. La segunda línea contiene n enteros separados por un espacio representando los elementos de un arreglo.

### Restricciones

a < **n, ar[i]** ≤ 1000

### Ejemplo de entrada

```
STDIN         Función
-----         --------
6             ar[] tamaño n = 6
1 2 3 4 10 11 ar = [1, 2, 3, 4, 10, 11]
```

### Ejemplo de salida

```
31
```

### Explicación

Emprime la suma de los elementos del arreglo: **1 + 2 + 3 + 4 + 10 + 11 = 31**

## Resolución

- C#
    
    Algoritmo
    
    ```csharp
    using System.Collections.Generic;
    
    namespace Ejercicios.Algoritmia.HackerRank.SimpleSumaArreglo
    {
        public class SimpleSumaArreglo
        {
            public int Sumar(List<int> ar)
            {
                int suma = 0;
                for (int i = 0; i < ar.Count; i++)
                {
                    suma += ar[i];
                }
                return suma;
            }
        }
    }
    ```
    
    Prueba unitaria
    
    ```csharp
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
    
    ```