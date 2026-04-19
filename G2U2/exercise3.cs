
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #3===\n");
        
        Console.WriteLine("Escriba una letra de la A-F \n");
        char l = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (l)
        {
            case 'A':
                Console.WriteLine("Excelente");
                break;
            case 'B':
                Console.WriteLine("Bueno");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("Fraca");
                break;
            case 'F':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Inserte una letra valida: ");
                    break;
        }
    }
}