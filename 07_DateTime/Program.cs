namespace _07_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.Year);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Hour);
            Console.WriteLine(dateTime.Minute);
            Console.WriteLine(dateTime.Second);

            Console.WriteLine(dateTime.DayOfYear);
            Console.WriteLine(dateTime.DayOfWeek);
            Console.WriteLine(dateTime.AddHours(5));
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToShortTimeString());
        }
    }
}
