internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #6\n");
        double a;
        double b;
        double c;
        double r;

        Console.WriteLine("Ingrese el lado A\n");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el lado B\n");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el lado C\n");
        c = Convert.ToDouble(Console.ReadLine());

        double s = a / c;
        double cc = b / c;
        double t = a / b;

        Console.WriteLine("1-Seno");
        Console.WriteLine("2-Coseno");
        Console.WriteLine("3-Tangente");

        Console.WriteLine("Escriba un numero del 1-3\n");
        r = Convert.ToDouble(Console.ReadLine());

        switch (r)
        {
            case 1:
                Console.WriteLine("El resultado es: \n"+s);
                break;
            case 2:
                Console.WriteLine("El resultado es: \n" + cc);
                break;
            case 3:
                Console.WriteLine("El resultado es: \n" + t);
                break;
                
        }
    }
}