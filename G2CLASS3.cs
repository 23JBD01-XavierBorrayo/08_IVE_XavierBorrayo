internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu AMERICAN RESTAURANT:");
        int menu;
        menu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 -> Hamburguesa");
        Console.WriteLine("2 -> Pizza");
        Console.WriteLine("3 -> Pollo Frito");
        Console.WriteLine("4 -> Ensalada");

        

        switch (menu)
        {
            case 1:
                Console.WriteLine("Hamburguesa 50$");
                break;
            case 2:
                Console.WriteLine("Pizza 35$");
                break;
            case 3:
                Console.WriteLine("Pollo frito 40$");
                break;
            case 4:
                Console.WriteLine("Ensalada 20$");
                break;
            default:
                Console.WriteLine("Unicamente (1, 2, 3 y 4)");
                break;
        }

    }
}