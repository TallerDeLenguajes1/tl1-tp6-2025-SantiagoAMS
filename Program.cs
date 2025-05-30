﻿
using System.Data;

//string a = LeerString("Ingresa la cadena A");
//string b = LeerString("Ingresa la cadena B");

int resCalc = Calculadora();
Console.WriteLine($"Resultado: {resCalc}");
static void Longitud(string s)
{
    Console.WriteLine($"Longitud: {s.Length}");
    // Obtener la longitud de la cadena y muestre por pantalla. 
}

static void Concatenar(string s1, string s2)
{
    string concat = s1 + s2;
    Console.WriteLine($"Cadena concatenada: {concat}");
    // A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas. 
}
static void Subcadena(string s)
{
    // Extraer una subcadena de la cadena ingresada. 
}

static void _Subcadena(string s, int index)
{
    if (s.Length - 1 < index)
    {
        PrintError($"El indice {index} excede a la longitud de la cadena ({s.Length})");
        return;
    }
    string subs = s.Substring(index);
    Console.WriteLine($"Subcadena: {subs}");
}

static void CadenaForeach(string s)
{
    // Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla  
    Console.Write($"Dividiendo \"{s}\" en caracteres:\n\t --> ");
    foreach (char c in s)
    {
        Console.Write($"'{c}' ");
    }
}

static void Contiene(string s, string busqueda)
{
    // Buscar la ocurrencia de una palabra determinada en la cadena ingresada 
    Console.WriteLine($"La cadena \"{busqueda}\" {(s.Contains(busqueda) ? "SI" : "NO")} esta contenida en {s}");

}
static void MayMin(string s)
{
    Console.WriteLine($"Cadena original:      {s}");
    Console.WriteLine($"Cadena en mayusculas: {s.ToUpper()}");
    Console.WriteLine($"Cadena en minusculas: {s.ToLower()}");
    // Convierta la cadena a mayúsculas y luego a minúsculas. 
}
static void DividirSegunCaracter(string s, char c)
{
    string[] parts = s.Split(c);
    if (parts.Length < 0)
    {
        PrintError($"No se ha encontrado el caracter '{c}' en la cadena \"{s}\"");
        return;
    }
    int i = 0;

    Console.WriteLine($"Se han encontrado {parts.Length} ocurrencias del caracter {c}, imprimiendo la división: \n");
    foreach (string p in parts)
    {
        Console.Write(p);
        if (i < parts.Length - 1)
        {
            Console.Write(" | ");
        }
        i++;
    }
    // Ingrese una cadena separada por caracteres que usted determine y muestre por  pantalla los resultados (Revisar el comportamiento de split()) 
}
static int Calculadora()
{

    string ec = LeerString("Ingresa una operacion matematica con dos parametros (Ej \"5+7\" o \"4*4\")");
    int a = 0;
    int b = 0;
    char op = ' ';
    bool parsingFirst = true;
    bool valid = true;
    int i = -1;
    foreach (char c in ec)
    {
        i++;
        if (parsingFirst)
        {
            if (char.IsNumber(c))
            {
                a = a * 10 + int.Parse(c.ToString());
            }
            else if (EsOperando(c))
            {
                op = c;
                parsingFirst = false;
                
            }
            else
            {
                valid = false;
                break;
            }
        }
        else
        {
            if (char.IsNumber(c))
            {
                b = b * 10 + int.Parse(c.ToString());
            }
            else
            {
                valid = false;
                break;
            }
        }
        
    }
    if (ec[i] == op)// Si no se ingreso el caracter B
    {
        valid = false;
    }

    if (!valid)
    {
        throw new InvalidExpressionException("No se ha ingresado una operacion matemática válida");
    }
    return op switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' or 'x' => a * b,
        '/' => a / b,
        '^' => (int)Math.Pow(a, b),
        '%' => a % b,
        _ => 0,
    };
    /*Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación 
simple como cadena de caracteres  y que el sistema lo resuelva. Por ej. ingrese 
por pantalla “582+2” y que le devuelva la suma de 582  con 2 */
}

static bool EsOperando(char c)
{
    return c == '+' || c == '-' || c == '*' || c == 'x' || c == '/' || c == '^' || c == '%';
}

static string LeerString(string texto = "Ingresa una cadena")
{
    Console.Write($"\n{texto}\n> ");
    string ret = Console.ReadLine();
    return ret ?? "";
}

static int LeerEntero(string texto = "Ingresá un número entero")
{
    int ret = 0;
    while (true)
    {
        Console.WriteLine(texto);
        Console.Write("> ");
        string s = Console.ReadLine();
        if (int.TryParse(s is null ? "" : s, out ret))
        {
            return ret;
        }
        PrintError("Error, no ingresaste un número...");
    }
}
static void Pausa()
{
    ConsoleColor old = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Pulsa una tecla para continuar...");
    Console.ReadKey();
    Console.ForegroundColor = old;
}
static void PrintError(string text = "Opcion invalida...")
{
    ConsoleColor old = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ForegroundColor = old;
}

/*
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos 
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para 
la suma sería:  
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.  
Donde num1, num2 y resultados son los sumandos y el resultado de la operación 
respectivamente. 
Nota: Busque el comportamiento del Método ToString();  


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