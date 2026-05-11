internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3pag54inc2===");
        int suma = 0;
        int num;

        do
        {
            Console.Write("Ingresa un número (9 para terminar): ");
            num = int.Parse(Console.ReadLine());

            if (num != 9)
            {
                suma += num;
            }
        } while (num != 9);

        Console.WriteLine("La suma de todos es:"+suma);
    }
}
}