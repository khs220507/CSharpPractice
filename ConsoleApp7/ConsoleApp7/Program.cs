enum Days
{
    Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
}

class Program
{
    static void Main(string[] args)
    {
        Days today = Days.Sunday;
        Console.WriteLine(today);
    }
}