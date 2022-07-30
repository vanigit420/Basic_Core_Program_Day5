namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = dividend / divisor;
            int Remainder = dividend % divisor;

            Console.WriteLine("Dividend: {0}, Divisor: {1} ", dividend, divisor);
            Console.WriteLine("Quotient is : " + Quotient);
            Console.WriteLine("Remainder is : " + Remainder);
        }
    }
}