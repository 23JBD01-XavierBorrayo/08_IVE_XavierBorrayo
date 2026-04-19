internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===DIAS DE LA SEMANA!===\n");
        int n;
        
        Console.WriteLine("Digite un numero del 1-7: \n");
        n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Escriba un valor valido");
                break;
        }

    }
}