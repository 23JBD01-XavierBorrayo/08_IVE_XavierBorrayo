internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #8===");

        int opcion, cantidad;
        double precio = 0, total;

        Console.WriteLine("Seleccione sector:");
        Console.WriteLine("1. Palco (Q300)");
        Console.WriteLine("2. Tribuna (Q100 - Q125)");
        Console.WriteLine("3. Preferencia (Q50 - Q75)");
        Console.WriteLine("4. Generales (Q30 - Q50)");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                precio = 300;
                break;
            case 2:
                precio = 100;
                break;
            case 3:
                precio = 50;
                break;
            case 4:
                precio = 30;
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        Console.Write("Cantidad de entradas: ");
        cantidad = int.Parse(Console.ReadLine());

        total = precio * cantidad;

        Console.WriteLine("Total a pagar: Q" + total);
    }
}