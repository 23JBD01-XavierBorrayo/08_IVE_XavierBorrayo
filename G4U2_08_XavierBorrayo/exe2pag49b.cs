internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act2pag49inc2===");
        Console.WriteLine("Ingrese numero limite:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Numeros pares entre 2 y " + x + ":");
        for (int i = 2; i < x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}