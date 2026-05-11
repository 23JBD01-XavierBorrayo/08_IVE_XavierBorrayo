internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act2pag97inc1===");
        int n;
        Console.WriteLine("Inserte un numero: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 2;i < n; i++)
        {
            Console.WriteLine(i * n);

        }
    }
}