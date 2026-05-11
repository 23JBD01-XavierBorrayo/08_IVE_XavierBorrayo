internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act1pag48inc1===");
        const int ts = 8;

        Console.WriteLine("Bienvenido a la barberia gentlemen: ");
        for (int i = 1; i <= ts; i++)
        {
            Console.WriteLine("\n sellos actuales: {0} de {1}", i, ts);
            Console.WriteLine("Presione cualquier tecla para registar el sello:");
            Console.ReadKey();

            Console.WriteLine(">> sellos #{0} registrado correctamente");
        }
        Console.WriteLine("\n ********************************");
        Console.WriteLine("CORTE GRATIS W!");
        Console.WriteLine("MAUU, te ganaste una pepis");
        Console.WriteLine("***********************************");
    }
}