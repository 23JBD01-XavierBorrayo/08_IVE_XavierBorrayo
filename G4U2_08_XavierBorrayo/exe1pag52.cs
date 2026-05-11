internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===INCISO 1 PAG 52===");
        int cm = 200;
        int au = 0;
        int d;

        do
        {
            d = cm - au;
            Console.WriteLine("Lugares disponibles: \n"+d);

            Console.WriteLine("Presione una tecla...");
            Console.ReadKey();
            Console.Clear();

            au++;
        } while (au < cm);
        Console.WriteLine("Se han llenado los espacios...");
    }
}