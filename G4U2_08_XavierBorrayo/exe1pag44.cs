internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act1pag44inc1===");
        double pm;
        double pt = 0;
        Console.WriteLine("Objetivo: LLegar a 1kg de manzanas...\n");

        while (pt < 1)
        {
            Console.WriteLine("Suba su manzana a la bascula...");
            Console.WriteLine("Ingrese el peso de la manzana en kg...\n");
            pm = double.Parse(Console.ReadLine());

            pt += pm;
            if (pt < 1)
            {
                Console.WriteLine("Peso Actual"+pm+"kg Aun falta para el kg\n");
            }
        }
        Console.WriteLine("Felicidades! ha completado su objetivo...\n");


    }
}