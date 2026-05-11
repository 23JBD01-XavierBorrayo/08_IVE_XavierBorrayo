internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3pag97inc2===");
        int acumuladorPrimos = 0;

        Console.WriteLine("Calculando la suma de números primos entre 1 y 50...");

        for (int i = 2; i <= 50; i++)
        {
            bool esPrimo = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                acumuladorPrimos += i;
                Console.WriteLine("Primo encontrado: "+i);
            }
        }

        Console.WriteLine($"\nLa suma total de los números primos es: "+acumuladorPrimos);
    }
}
