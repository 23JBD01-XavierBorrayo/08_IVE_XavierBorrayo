internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act2pag53inc3===");
        Console.Write("Número 1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Número 2: ");
        int n2 = int.Parse(Console.ReadLine());

        int menor = Math.Min(n1, n2);
        int mayor = Math.Max(n1, n2);

        Console.WriteLine("Multiplos de 4 entre: "+menor+" y "+mayor);
        for (int i = menor; i <= mayor; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}