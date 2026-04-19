internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #5===\n");
        int r;

        Console.WriteLine("Escriba un numero de mes del 1-12\n");
        r = Convert.ToInt32(Console.ReadLine());

        switch (r)
        {
            case 1:
                Console.WriteLine("Enero - 31 dias\n");
                break;
            case 2:
                Console.WriteLine("Febrero - 28 dias\n");
                break;
            case 3:
                Console.WriteLine("Marzo - 31 dias\n");
                break;
            case 4:
                Console.WriteLine("Abril - 30 dias\n");
                break;
            case 5:
                Console.WriteLine("Mayo - 31 dias\n");
                break;
            case 6:
                Console.WriteLine("Junio - 30 dias\n");
                break;
            case 7:
                Console.WriteLine("Julio - 31 dias\n");
                break;
            case 8:
                Console.WriteLine("Agosto - 31 dias\n");
                break;
            case 9:
                Console.WriteLine("Septiembre - 30 dias\n");
                break;
            case 10:
                Console.WriteLine("Octubre - 31 dias\n");
                break;
            case 11:
                Console.WriteLine("Noviembre - 31 dias\n");
                break;
            case 12:
                Console.WriteLine("Diciembre - 31 dias\n");
                break;
        }
    }
}