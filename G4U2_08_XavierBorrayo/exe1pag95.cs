internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act1pag95inc1===");
        int i = 1, suma = 0, contadorPares = 0;

        while (i <= 20)
        {
            int multiplo = i * 7;
            suma += multiplo;

            if (multiplo % 2 == 0)
            {
                contadorPares++;
            }
            i++;
        }

        Console.WriteLine("Suma de los 20 multiplos: "+suma);
        Console.WriteLine("Cantidad de pares: "+contadorPares);
    }
}