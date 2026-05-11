internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===act3pag54inc1===");
        Console.Write("Número 1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Número 2: ");
        int n2 = int.Parse(Console.ReadLine());

        int menor = Math.Min(n1, n2);
        int mayor = Math.Max(n1, n2);
        int suma = 0;
        int i = menor;

        do
        {
            suma += i;
            i++;
        } while (i <= mayor);

        Console.WriteLine("Suma total acumulada: "+suma);
    }
}