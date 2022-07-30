namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Four Digit Number Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} year is Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} year is not Leap Year", year);
            }
            Console.ReadLine();
        }
    }
}