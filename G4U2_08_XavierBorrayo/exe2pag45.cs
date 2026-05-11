internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act2pag45inc1===");
        int mt = 0;
        int mg;
        Console.WriteLine("NIVEL 5 BLOQUEADO");

        while (mt < 350)
        {
            Console.WriteLine("Tienes: " + mt + " Monedas, sigue jugando para ganar mas!");
            Console.WriteLine("Cuantas monedas ganaste ahora?");

            if (int.TryParse(Console.ReadLine(), out mg))
            {
                mt += mg;
            }
            else
            {
                Console.WriteLine("Porfavor ingrese un numero valido...");
            }
        }
        Console.WriteLine("Desbloqueaste el nv5");
    }
}