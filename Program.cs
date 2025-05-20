/*Para los ejercicios 2 y 3, cree dos branchs en su repositorio, CalculadoraV1 y 
CalculadoraV2 
Ejercicio 2.  Ingrese al branch CalculadoraV1 y construya un programa que sea una 
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar, 
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego 
pida dos números y que devuelva el resultado de la operación seleccionada. Además 
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo. */



int opc = 0;
while (opc != 5)
{
    Console.Clear();
    Console.WriteLine("======================");
    Console.WriteLine("  1  -  SUMAR");
    Console.WriteLine("  2  -  RESTAR");
    Console.WriteLine("  3  -  MULTIPLICAR");
    Console.WriteLine("  4  -  DIVIDIR");
    Console.WriteLine("  5  -  SALIR"); // Por si el usuario hubiera cometido un error durante la pregunta
    Console.WriteLine("======================");

    opc = LeerEntero("Ingresá la opción");

    switch (opc)
    {
        case 1:
            RealizarSuma();
            break;
        case 2:
            RealizarResta();
            break;
        case 3:
            RealizarMultiplicacion();
            break;
        case 4:
            RealizarDivision();
            break;
        case 5:
            continue;
        default:
            PrintError();
            break;
    }

    if (!LeerBooleano("¿Realizar otra operacion?"))
    {
        opc = 5;
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("¡Nos vemos!");
Pausa();

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

static void RealizarSuma()
{
    double a = LeerDouble("Ingresa el valor A");
    double b = LeerDouble("Ingresa el valor B");

    Console.WriteLine("La suma es: " + (a + b));
    Pausa();
}

static void RealizarResta()
{
    double a = LeerDouble("Ingresa el valor A");
    double b = LeerDouble("Ingresa el valor B");

    Console.WriteLine("La resta es: " + (a - b));
    Pausa();
}

static void RealizarMultiplicacion()
{
    double a = LeerDouble("Ingresa el valor A");
    double b = LeerDouble("Ingresa el valor B");

    Console.WriteLine("La multiplicacion es: " + (a * b));
    Pausa();
}

static void RealizarDivision()
{
    double a = LeerDouble("Ingresa el valor A");
    double b = LeerDouble("Ingresa el valor B");
    if (b == 0)
    {
        PrintError("No se puede realizar una divicion por cero...");
        return;
    }
    Console.WriteLine("La division es: " + (a / b));
    Pausa();
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

static double LeerDouble(string texto = "Ingresá un número entero o decimal")
{
    double ret = 0;
    while (true)
    {
        Console.WriteLine(texto);
        Console.Write("> ");
        string s = Console.ReadLine();
        if (double.TryParse(s is null ? "" : s, out ret))
        {
            return ret;
        }
        PrintError("Error, no ingresaste un número válido...");
    }
}

static bool LeerBooleano(string pregunta = "")
{
    Console.Write(pregunta + "  [SI/YES/1 - NO/0]\n> ");

    string s = Console.ReadLine();
    if (s is null)
    {
        return false;
    }
    s = s.ToUpper();
    return s == "SI" || s == "S" || s == "Y" || s == "YES" || s == "1";
}



