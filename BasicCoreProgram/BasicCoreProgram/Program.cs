namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter the Number : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Table of Power of Two : ");

            if (N !=0 && N <= 31)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("2^{0} : {1}", i, Math.Pow(2, i));
                }
            }
        }
    }
}