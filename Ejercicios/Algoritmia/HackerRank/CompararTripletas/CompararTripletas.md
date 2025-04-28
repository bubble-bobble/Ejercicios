# Comparar tripletas

## Enunciado

Alicia y Bob, cada uno ha creado un problema. Un revisor a calificado los dos problemas, otorgando puntos en una escala de 1 a 100 para tres categorías: claridad, originalidad, dificultad.

El puntaje para el problema de Alicia es `a=(a[0], a[1], a[2])`, y el puntaje para el problema de Bob es la tripleta `b=(b[0], b[1], b[2])`.

La tarea es calcular los puntos de comparación entre cada uno por categoría:

- Si `a[i] > b[i]`, Alicia obtiene 1 punto.
- Si `a[i] < b[i]`, Bob obtiene 1 punto.
- Si `a[i] = b[i]`, Nadie recibe puntos.

### Ejemplo

```
a = [1, 2, 3]
b = [3, 2, 1]
```

- Para los elementos 0, Bob obtiene un punto debido a que `a[0] < b[0]`
- Para los elementos 1, Nadie obtiene puntos debido a que `a[1] = b[1]`
- Para los elementos 2, Alicia obtiene un punto debido a que `a[2] > b[2]`

### Descripción de la función

Completa la función “Comparar tripletas”, la cual recibe los siguientes parámetros:

- `int a[3]`: Puntajes de Alicia
- `int b[3]`: Puntajes de Bob

Retorna

`int[2]`: El primer elemento es el puntaje de Alicia y el segundo es el de Bob

### Formato de entrada

La primera línea contiene 3 enteros separados por un espacio, `a[0]`, `a[1]`, y `a[2]`, son los respectivos valores de la tripleta a.

La segunda línea contiene 3 enteros separados por un espacio, `b[0]`, `b[1]`, y `b[2]`, son los respectivos valores de la tripleta b.

### Restricciones

1 ≤ a[i] ≤ 100

1 ≤ b[i] ≤ 100

### Ejemplo de entrada

```
5 6 7
3 6 10
```

### Ejemplo de salida

```
11
```

### Explicación

- a = (a[0], a[1], a[2]) = (5, 6, 7)
- b = (b[0], b[1], b[2]) = (3, 6, 10)

Ahora comparemos cada puntaje individualmente:

- a[0] > b[0], Alicia recibe 1 punto.
- a[1] = b[1], Nadie recibe puntos.
- a[2] < b[2], Bob recibe 1 punto.

Alicia obtuvo 1 punto y Bob obtuvo 1 punto, entonces retornamos un arreglo [1, 1].

## Resolución

- C#
    
    Algoritmo
    
    ```csharp
    using System.Collections.Generic;
    
    namespace Ejercicios.Algoritmia.HackerRank.CompararTripletas
    {
        public class CompararTripletas
        {
            public List<int> Comparar(List<int> a, List<int> b)
            {
                int alicePoints = 0;
                int bobPoints = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i])
                    {
                        alicePoints++;
                    }
                    if (b[i] > a[i])
                    {
                        bobPoints++;
                    }
                }
                return [alicePoints, bobPoints];
            }
        }
    }
    ```
    
    Prueba unitaria
    
    ```csharp
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
    ```