internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act2pag67inc2===");
        int numBillete = 1, contador100 = 0, suma100 = 0;

        do
        {
            Console.Write("Ingrese denominación del billete: "+numBillete);
            int denominacion = int.Parse(Console.ReadLine());

            if (denominacion == 100)
            {
                contador100++;
                suma100 += 100;
            }
            numBillete++;
        } while (numBillete <= 1000);

        Console.WriteLine("Billetes de 100: "+contador100);
        Console.WriteLine("Suma total: "+suma100);
    }
}