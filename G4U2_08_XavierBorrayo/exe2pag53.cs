internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act2pag53inc1===");
        int f = 1;
        int i = 1;
        int n;
        Console.WriteLine("Ingrese un numero:\n");
        n = int.Parse(Console.ReadLine());

        do
        {
            f *= i;
            i += 1;
        } while (i <= n);
        Console.WriteLine("Factorial:"+f);

    }
}