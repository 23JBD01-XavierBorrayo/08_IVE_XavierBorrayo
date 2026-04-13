internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("RANKING TIER LIST:");

        Console.WriteLine("Write a Key (A, B, C, D, F): ");
        char key = Convert.ToChar(Convert.ToInt32(Console.ReadLine().ToUpper()));

        switch (key)
        {
            case 'A':
                Console.WriteLine("20 / 10 GOD");
                break;
            case 'B':
                Console.WriteLine("Good Try");
                break;
            case 'C':
                Console.WriteLine("NPC");
                break;
            case 'D':
                Console.WriteLine("Trash or Garbage");
                break;
            case 'F':
                Console.WriteLine("Get out!");
                break;
            default:
                Console.WriteLine("Only this NUMBRES (A, B, C, D, F)");
                break;
        }

    }
}