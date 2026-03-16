internal class Program
{
    private static void Main(string[] args)
    {
        //Entry
        int num;
        Console.Write("Give me whatever number");
        num = Convert.ToInt32(Console.ReadLine());

        //Exit
        if (num > 0)
        {
            Console.WriteLine("Im positive number");
        }
        else
        {
            Console.WriteLine("Im negative number");
        }
        Console.WriteLine("Negative and Positive Numbers");

    }
}