internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #2===");
        int n1;
        int n2;
        int r;

        Console.WriteLine("Escriba su primer numero: \n");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba su segundo numero: \n");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1-Suma");
        Console.WriteLine("2-Resta");
        Console.WriteLine("3-Multi");
        Console.WriteLine("4-Division");


        Console.WriteLine("Escriba un numero del 1-4 para realizar la ecuacion: \n");
        r = Convert.ToInt32(Console.ReadLine());

        switch (r)
        {
            case 1:
                Console.WriteLine(n1 + n2);
                break;
            case 2:
                Console.WriteLine(n1 - n2);
                break;
            case 3:
                Console.WriteLine(n1 * n2);
                break;
            case 4:
                Console.WriteLine(n1 / n2);
                break;
        }


    }
}