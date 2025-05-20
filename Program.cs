/*Para los ejercicios 2 y 3, cree dos branchs en su repositorio, CalculadoraV1 y 
CalculadoraV2 
Ejercicio 2.  Ingrese al branch CalculadoraV1 y construya un programa que sea una 
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar, 
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego 
pida dos números y que devuelva el resultado de la operación seleccionada. Además 
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo. */

int opc = 0;
while (opc > 0)
{
    Console.WriteLine("======================");
    Console.WriteLine("  1  -  SUMAR");
    Console.WriteLine("  2  -  RESTAR");
    Console.WriteLine("  3  -  MULTIPLICAR");
    Console.WriteLine("  4  -  DIVIDIR");
    Console.WriteLine("  5  -  SALIR");
    Console.WriteLine("======================");
}