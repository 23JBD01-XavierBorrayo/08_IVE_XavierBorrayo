internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act2pag67inc1===");
        int i = 1, suma = 0, contadorPrimos = 0;
        do
        {
            int divisores = 0, j = 1;
            do
            {
                if (i % j == 0) divisores++;
                j++;
            } while (j <= i);

            if (divisores == 2)
            {
                Console.WriteLine("Primo: "+i);
                suma += i;
                contadorPrimos++;
            }
            i++;
        } while (i <= 100);

        Console.WriteLine("Suma total: "+suma);
    }
}