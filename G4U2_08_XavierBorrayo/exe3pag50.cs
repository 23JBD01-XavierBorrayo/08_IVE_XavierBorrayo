internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3pag50inc1===");
        int s = 0;

        Console.WriteLine("Buscando numeros primos entre 1 y 22...");

        for (int i = 1; i <= 22; i++)
        {
            int d = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    d++;
                }
            }
            if (d == 2)
            {
                Console.WriteLine("Número primo detectado:"+i);
                s += i;
            }
        }
        Console.WriteLine("La suma total de primos es: " + s);
    }
}