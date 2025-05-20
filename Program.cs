/*Para los ejercicios 2 y 3, cree dos branchs en su repositorio, CalculadoraV1 y 
CalculadoraV2 
Ejercicio 2.  Ingrese al branch CalculadoraV1 y construya un programa que sea una 
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar, 
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego 
pida dos números y que devuelva el resultado de la operación seleccionada. Además 
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo. */

int opc = 0;
int a = 0, b = 0;
while (opc > 0)
{
    Console.Clear();
    Console.WriteLine("======================");
    Console.WriteLine("  1  -  SUMAR");
    Console.WriteLine("  2  -  RESTAR");
    Console.WriteLine("  3  -  MULTIPLICAR");
    Console.WriteLine("  4  -  DIVIDIR");
    Console.WriteLine("  5  -  SALIR");
    Console.WriteLine("======================");

    Console.WriteLine("Ingresa una opción");
    Console.Write("> ");
    string s = Console.ReadLine();
    if (s is null)
    {
        PrintError();
        continue;
    }
    int.TryParse(s, out opc);

    if (opc <= 0)
    {
        PrintError("Ingresá un número...");
        continue;
    }

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
            opc = -1;
            break;
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.ReadKey();

static void PrintError(string text = "Opcion invalida...")
{
    ConsoleColor old = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ForegroundColor = old;
    Console.ReadKey();
}

static void RealizarSuma()
{

}

static void RealizarResta()
{

}

static void RealizarMultiplicacion()
{

}

static void RealizarDivision()
{

}