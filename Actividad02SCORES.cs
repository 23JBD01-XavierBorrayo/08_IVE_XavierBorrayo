internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite una nota: ");
        int nota = Convert.ToInt32 (Console.ReadLine());

        if (nota >= 0 && nota < 60)
            Console.WriteLine("Deficiente");
        if (nota >= 60 && nota < 70) 
            Console.WriteLine("Regular");
        if (nota >= 70 && nota < 80) 
            Console.WriteLine("GOOD");
        if (nota >= 80 && nota < 90) 
            Console.WriteLine("AMAZING");
        if (nota >= 90 && nota < 100) 
            Console.WriteLine("EXCELSIOR");
    }
}