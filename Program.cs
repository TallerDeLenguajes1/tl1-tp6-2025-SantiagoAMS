int opc = -1;
while (opc != 0)
{
    Console.Clear();
    Console.WriteLine("======================");
    Console.WriteLine("  1  -  SUMAR");
    Console.WriteLine("  2  -  RESTAR");
    Console.WriteLine("  3  -  MULTIPLICAR");
    Console.WriteLine("  4  -  DIVIDIR");
    Console.WriteLine("  5  -  VALOR ABSOLUTO");
    Console.WriteLine("  6  -  CUADRADO");
    Console.WriteLine("  7  -  SENO");
    Console.WriteLine("  8  -  COSENO");
    Console.WriteLine("  9  -  PARTE ENTERA DE UN REAL");
    Console.WriteLine("  0  -  SALIR"); // Por si el usuario hubiera cometido un error durante la pregunta
    Console.WriteLine("======================");

    opc = LeerEntero("Ingresá la opción");

    switch (opc)
    {
        case 0:
            continue;
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
            ValorAbsoluto();
            break;
        case 6:
            Cuadrado();
            break;
        case 7:
            Seno();
            break;
        case 8:
            Coseno();
            break;
        case 9:
            EnteroDeFloat();
            break;
        default:
            PrintError();
            break;
    }
    Console.WriteLine("");
    MayorMenor();

    if (!LeerBooleano("¿Realizar otra operacion?"))
    {
        opc = 0;
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

    Console.WriteLine("La suma es: " + (a + b) + "\n");
}
static void RealizarResta()
{
    double a = LeerDouble("Ingresa el valor A");
    double b = LeerDouble("Ingresa el valor B");

    Console.WriteLine("La resta es: " + (a - b) + "\n");
}
static void RealizarMultiplicacion()
{
    double a = LeerDouble("Ingresa el valor A");
    double b = LeerDouble("Ingresa el valor B");

    Console.WriteLine("La multiplicacion es: " + (a * b) + "\n");
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
    Console.WriteLine("La division es: " + (a / b) + "\n");
}

//////////////////////////////////////////////////////////////////////////////////

static void ValorAbsoluto()
{
    double n = LeerDouble();

    if (n < 0)
    {
        n = -n;
    }
    Console.Write("El valor absoluto es: " + n + "\n");
}
static void Cuadrado()
{
    double n = LeerDouble();
    Console.WriteLine("El cuadrado es: " + (n * n));
}
static void Seno()
{
    double n = LeerDouble();
    Console.WriteLine("El seno es: " + Math.Sin(n));
}
static void Coseno()
{
    double n = LeerDouble();
    Console.WriteLine("El coseno es: " + Math.Cos(n));
}
static void EnteroDeFloat()
{
    double n = LeerDouble();
    int parteEntera = (int)n;
    Console.WriteLine("La parte entera es: " + parteEntera);
}
static void MayorMenor()
{
    double a = LeerDouble();
    double b = LeerDouble();

    double may = Math.Max(a, b);
    double min = Math.Min(a, b);

    Console.WriteLine("Maximo: " + may + "\nMinimo: " + min + "\n");

}
//////////////////////////////////////////////////////////////////////////////////

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
        if (s is null)
        {
            PrintError("Error, no ingresaste un número válido...");
            continue;
        }
        if (double.TryParse(s, out ret) || double.TryParse(s.Replace(",", "."), out ret) || double.TryParse(s.Replace(".", ","), out ret))
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



