internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act4pag47inc1===");
        Console.WriteLine("Que tabla de multiplicar desea ver?\n");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabla del: "+num+":");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = num * i;
            Console.WriteLine(num+"x"+i+"="+resultado);
        }
        Console.WriteLine("-----------------------");
    }
}