namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors are : ");

            if (num >= 2)
            {
                for (int i = 2; i <= num; i++)
                {
                    while (num % i == 0)
                    {
                        Console.Write(i + " ");
                        num = num / i;
                    }
                }
            }
        }
    }
}