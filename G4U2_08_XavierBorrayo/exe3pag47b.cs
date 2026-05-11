internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3pag47inc2===");

        Console.WriteLine("Ingrese un numero entero:\n");
        int n = int.Parse(Console.ReadLine());
        int d = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % 1 == 0)
            {
                d++;
            }
        }
        if (d == 2)
        {
            Console.WriteLine(n+"Es un numero primo.");
        }
        else
        {
            Console.WriteLine(n+"No es un numero primo");
        }
    }
}