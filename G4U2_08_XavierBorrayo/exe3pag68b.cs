internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3pag68inc2===");
        int i = 300, cuentaPrimos = 0;
        long sumaPares = 0;

        do
        {
            if (i % 2 == 0) sumaPares += i;

            int divisores = 0, j = 1;
            do
            {
                if (i % j == 0) divisores++;
                j++;
            } while (j <= i);

            if (divisores == 2) cuentaPrimos++;

            i--;
        } while (i >= 1);

        Console.WriteLine("Primos encontrados: "+cuentaPrimos);
        Console.WriteLine("Suma de los pares: "+sumaPares);
    }
}