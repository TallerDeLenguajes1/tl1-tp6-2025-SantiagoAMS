
Console.Write("Ingresa una cadena: \n> ");
string a = Console.ReadLine();
a = a is null ? "" : a;

Console.Write("Ingresa una segunda cadena: \n> ");
string b = Console.ReadLine();
b = b is null ? "" : b;

Console.WriteLine($"Combinada: \"{(a+b)}\"");



/*
Realizar los siguientes ejercicios  
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes 
tarea:  
● Obtener la longitud de la cadena y muestre por pantalla. 
● A partir de una segunda cadena ingresada por el usuario, concatene ambas 
cadenas distintas. 
● Extraer una subcadena de la cadena ingresada. 
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos 
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para 
la suma sería:  
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.  
Donde num1, num2 y resultados son los sumandos y el resultado de la operación 
respectivamente. 
Nota: Busque el comportamiento del Método ToString();  
● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por 
elemento en pantalla  
● Buscar la ocurrencia de una palabra determinada en la cadena ingresada 
● Convierta la cadena a mayúsculas y luego a minúsculas. 
● Ingrese una cadena separada por caracteres que usted determine y muestre por 
pantalla los resultados (Revisar el comportamiento de split()) 
● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación 
simple como cadena de caracteres  y que el sistema lo resuelva. Por ej. ingrese 
por pantalla “582+2” y que le devuelva la suma de 582  con 2 
Ejercicio 5. (optativo)  
Expresiones Regulares 
Busque en diferentes bibliografías que son y cómo funcionan las expresiones 
regulares.  
● ¿Funcionan únicamente en C#?  
● ¿En qué casos le parecen útiles? Enuncie al menos 3. 
● ¿Cómo se hace uso de estas en C#?



Resuelva las siguiente expresiones regulares
Construir un programa que permita identificar de forma sencilla si la cadena ingresada 
es una dirección web y otro que una cadena ingresada sea un mail válido.
*/