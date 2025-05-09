# Diferencia Diagonal

## Enunciado

Dada una matriz cuadrada, calcula la diferencia absoluta entre las sumas de sus diagonales. Por ejemplo:

```
1 2 3
4 5 6
9 8 9
```

- La diagonal de izquierda a derecha es **1 + 5 + 9 = 15**
- La diagonal de derecha a izquierda es **3 + 5 + 9 = 17**

La diferencia absoluta es **|15 - 17| = 2**

### Descripción de la función

Completa la función “Diferencia diagonal”, la cual recibe los siguientes parámetros:

- `int arr[n][m]`: arreglo de enteros 2D

Retorna

- `int`: la diferencia absoluta de las sumas de las diagonales

### Formato de entrada

La primera línea contiene un entero, **n**, representa el número de filas y columnas de la matriz `arr`.

Cada una de las siguiente n líneas, describen una fila, `arr[i]`, y consisten en n enteros separados por espacios `arr[i][j]`.

### Restricciones

-100 ≤ `arr[i][j]` ≤ 100

### Ejemplo de entrada

```
STDIN      Función
-----      --------
3          arr[][] tamaño n = 3, m = 3
11 2 4     arr = [[11, 2, 4], [4, 5, 6], [10, 8, -12]]
4 5 6
10 8 -12
```

### Ejemplo de salida

```
15
```

### Explicación

La primera diagonal es

```
11
  5
   -12
```

La suma es **11 + 5 - 12 = 4**

La segunda diagonal es:

```
    4
  5
10
```

La suma es **4 + 5 + 10 = 19**

Entonces, la diferencia absoluta es **|4 - 19| = 15**

## Resolución

- C#
    
    Algoritmo
    
    ```csharp
    using System;
    using System.Collections.Generic;
    
    namespace Ejercicios.Algoritmia.HackerRank.DiferenciaDiagonal
    {
        public class DiferenciaDiagonal
        {
            public int Calcular(List<List<int>> arr)
            {
                int diagonalLeftToRight = 0;
                int diagonalRightToLeft = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    diagonalLeftToRight += arr[i][i];
                    diagonalRightToLeft += arr[i][^(i + 1)];
                }
                return Math.Abs(diagonalLeftToRight - diagonalRightToLeft);
            }
        }
    }
    
    ```
    
    Prueba unitaria
    
    ```csharp
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
    
    ```