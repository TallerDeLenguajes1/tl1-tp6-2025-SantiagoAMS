
string a = LeerString("Ingresa la cadena A");
string b = LeerString("Ingresa la cadena B");



static void Longitud(string s)
{
    // Obtener la longitud de la cadena y muestre por pantalla. 
}

static void Concatenar(string s1, string s2)
{
    // A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas. 
}
static void Subcadena(string s, int index)
{
    // Extraer una subcadena de la cadena ingresada. 
}
static void CadenaForeach(string s)
{
    // Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla  
}

static void Contiene(string s, string busqueda)
{
    // Buscar la ocurrencia de una palabra determinada en la cadena ingresada 
}
static void MayMin(string s)
{
    // Convierta la cadena a mayúsculas y luego a minúsculas. 
}
static void DividirSegunCaracter(string s, char c)
{
    // Ingrese una cadena separada por caracteres que usted determine y muestre por  pantalla los resultados (Revisar el comportamiento de split()) 
}
static void Calculadora()
{
    /*Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación 
    simple como cadena de caracteres  y que el sistema lo resuelva. Por ej. ingrese 
    por pantalla “582+2” y que le devuelva la suma de 582  con 2 */
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