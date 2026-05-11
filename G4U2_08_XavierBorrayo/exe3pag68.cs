internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3pag68inc1===");
        int i = 1, suma = 0, contadorPares = 0;

        do
        {
            int multiplo = i * 7;
            suma += multiplo;

            if (multiplo % 2 == 0) contadorPares++;

            i++;
        } while (i <= 20);

        Console.WriteLine("Suma total: "+suma);
        Console.WriteLine("Contadores pares: "+contadorPares);
    }
}