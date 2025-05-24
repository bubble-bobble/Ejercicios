# Escalera

## Enunciado

Detalle de la escalera, está es una escalera de tamaño **n** = 4.

```
   #
  ##
 ###
####
```

Su base y altura son iguales a **n**, está dibujado usando el símbolo **#** y **espacios**. **La última línea no esta precedida por ningún espacio.** Escribe un algoritmo es imprima una escalera de tamaño **n**.

### Descripción de la función

Completa la función “escalera” que recibe los siguientes parámetros:

- `int` **n**: un entero

Imprime la escalera descrita, la última línea no está precedida por espacios. Todas las líneas están alineadas hacia la derecha.

### Formato de entrada

Un entero, **n**, indica el tamaño de la escalera.

### Restricciones

0 < n ≤ 100

### Ejemplo de entrada

```
6
```

### Ejemplo de salida

```
     #
    ##
   ###
  ####
 #####
######
```

### Explicación

La escalera está alineada a la derecha, compuesto por el símbolo **#** y **espacios**, el alto y ancho son **n** = 6.

## Resolución

- C#
    
    Algoritmo
    
    ```csharp
    using System.Text;
    
    namespace Ejercicios.Algoritmia.HackerRank.Escalera
    {
        public class Escalera
        {
            public string Dibujar(int n)
            {
                StringBuilder escalera = new();
                for (int i = 1; i <= n; i++)
                {
                    escalera.Append(new string(' ', n - i));
                    escalera.Append(new string('#', i));
                    if (i < n) escalera.Append('\n');
                }
                return escalera.ToString();
            }
        }
    }
    
    ```
    
    Prueba unitaria
    
    ```csharp
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
    
    ```