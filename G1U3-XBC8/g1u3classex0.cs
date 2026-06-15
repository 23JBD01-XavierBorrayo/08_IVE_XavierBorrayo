internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("_-_-LECC2ACT2INC1-_-_");
        Console.WriteLine("Xavier Borrayo / Clave 8");

        int[] People_age = new int[7];
        int cp = 0;

        for (int i = 1; i < People_age.Length; i++)
        {
            Console.WriteLine("Write your age " + i + ": ");
            People_age[i] = Convert.ToInt32(Console.ReadLine());
            if (People_age[i] >= 18) ;
            cp++;

        }
        Console.Clear();
        Console.WriteLine("Las edades ingresadas son :");
        for (int i = 0; i < People_age.Length; i++)
        {
            Console.WriteLine(People_age[i] + ": ");
        }
        Console.WriteLine("La cantidad de personas mayores de edad son: " + cp);
    }
}