internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("WEEK DAYS:");

        int day;
        Console.WriteLine("Write a number of 1 to 7");
        day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("MONDAY");
                break;
            case 2:
                Console.WriteLine("THUESDAY");
                break;
            case 3:
                Console.WriteLine("WEDNESDAY");
                break;
            case 4:
                Console.WriteLine("THURSTDAY");
                break;
            case 5:
                Console.WriteLine("FRIDAY");
                break;
            case 6:
                Console.WriteLine("SATURDAY");
                break;
            case 7:
                Console.WriteLine("SUNDAY");
                break;
            default:
                Console.WriteLine("Write a value number of 1 to 7");
                break;
        }

    } 
}