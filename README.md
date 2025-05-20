[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

## ¿String es una tipo por valor o un tipo por referencia? 
Una variable de la clase String es un puntero a una cadena.
Fuente: *String.cs* 
    Parameters:
        //   value:
        //     A **pointer** to a null-terminated array of Unicode characters.

## ¿Qué secuencias de escape tiene el tipo string? 
Las secuencias de escape son:
    \n  Salto de linea 
    \t  Tabulacion vertical
    \r  Retorno de carro
    \\  Barra invertida
    \'  Comilla simple
    \"  Comilla doble
    \0  Marca final de caracter
    \a  Alerta
    \b  Borrado
    \f  Salto de pagina
    \v  Tabulacion horizonal
Y hay otras que generan caracteres unicode:
    \uxxxx          Secuencia de escape con valor hexadecimal
    \xn[n][n][n]    Identico al anterior, pero con tamaño variable
    \Uxxxxxxxx      Permite modificar la forma del texto

Fuente: https://github.com/dotnet/csharplang/discussions/7394#discussion-5447347



## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Si se utiliza **$** como prefijo, se podra embemer variables dentro de un string si se envuelve su nombre entre llaves {}
Ejemplo
```cs
double pi = 3.14;
Console.WriteLine($"El valor de PI es {pi}");
```
`Salida: "El valor de PI es 3.14"`
Lo cual es util si vamos a mostrar muchas variables en un solo string, ademas permite darle un mejor formato.


En cambio, si se utiliza **@** como prefijo, se interpretara cada caracter de escape como si fuera texto (quitandole su funcion).
Ejemplo
```cs
double pi = 3.14;
double e = 2.71;
Console.WriteLine(@"\n\tEl valor de PI es " + pi + @"\n\tEl valor de E es "+e);
```
`Salida: "\n\tEl valor de PI es 3,14\n\tEl valor de E es 2,71"`