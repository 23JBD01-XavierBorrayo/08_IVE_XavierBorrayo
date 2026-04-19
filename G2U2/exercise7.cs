internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===EJERCICIO #7===\n");
        
        Console.WriteLine("Digite una vocal o numero: \n");
        char c = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Es una vocal\n");
                break;

            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Es un dígito\n");
                break;

            default:
                Console.WriteLine("No es vocal ni dígito\n");
                break;
        }
    }
}