internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #4===\n");
        int n;

        Console.WriteLine("1-Hamburguesa\n");
        Console.WriteLine("2-Pizza\n");
        Console.WriteLine("3-Pollo Frito\n");
        Console.WriteLine("4-Ensalada\n");

        Console.WriteLine("Escriba su pedido del numero 1-4\n");
        n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine("Su pedido de hamburguesa esta siendo preparado...\n");
                break;
            case 2:
                Console.WriteLine("Su pedido de pizza esta siendo preparado...\n");
                break;
            case 3:
                Console.WriteLine("Su pedido de pollo frito esta siendo preparado...\n");
                break;
            case 4:
                Console.WriteLine("Su pedido de ensalada esta siendo preparado...\n");
                break;
        }

    }
}