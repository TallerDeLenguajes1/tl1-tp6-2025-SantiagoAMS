
namespace proyectos
{
    public class Invertir
    {
        public static void RealizarInversion()
        {
            Console.WriteLine("Ingresa el numero a invertir:");
            string? s = Console.ReadLine();

            int n = 0;
            int.TryParse(s is null ? "" : s, out n);

            if (n <= 0)
            {
                Console.WriteLine("El texto ingresado no es un numero...");
                return;
            }

            string ret = "";
            int dig = 0;

            while (n > 0)
            {
                dig = n % 10;
                n = n / 10;
                ret = ret + dig;
            }

            Console.WriteLine("Numero ingresado: " + s);
            Console.WriteLine("Numero invertido: " + ret);
        }
    }

}



