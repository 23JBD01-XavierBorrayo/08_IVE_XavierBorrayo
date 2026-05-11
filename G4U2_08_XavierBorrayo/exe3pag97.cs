internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("act3pag97inc1");
        int sumaTotal = 0;

        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("\nCuenta regresiva:");

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
                sumaTotal += i;
            }

            Console.WriteLine("etc.");
            Console.WriteLine("\nLa suma es."+sumaTotal);
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
    }
}