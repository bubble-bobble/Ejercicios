# Resuélveme primero

## Enunciado

Completa la función “**resuélveme primero**” para calcular la suma de dos enteros.

### Ejemplo

```
a = 7
b = 3
```

Retorna 10.

### Descripción de la función

Completa la función “**resuélveme primero**”, la cual recibe los siguiente parámetros:

- `int` a: el primer valor
- `int` b: el segundo valor

Retorna

- `int`: la suma de a más b

### Restricciones

1 ≤ a, b ≤ 1000

### Ejemplo de entrada

```
a = 2
b = 3
```

### Ejemplo de salida

```
5
```

### Explicación

```
2 + 3 = 5
```

## Resolución

- C#
    
    Algoritmo
    
    ```csharp
    namespace Ejercicios.Algoritmia.HackerRank.ResuelvemePrimero
    {
        public class ResuelvemePrimero
        {
            public int Sumar(int a, int b)
            {
                return a + b;
            }
        }
    }
    ```
    
    Prueba unitaria
    
    ```csharp
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
    ```