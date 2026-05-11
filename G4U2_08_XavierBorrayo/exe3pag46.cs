internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3inc1pag46===");

        Console.Write("Ingresa un número entero mayor a 20: \n");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Impares entre 20 y " + x);
        for (int i = 20; i <= x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}