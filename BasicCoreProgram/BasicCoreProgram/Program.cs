namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double sum = 0;
            Console.WriteLine("Calculate the Harmonic Series and their sum :\n");
            Console.WriteLine("-----------------");

            Console.WriteLine("Input the Number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write(" 1/{0} + ", i);
                sum += (double)1 / i;
            }
            Console.WriteLine("\nSum of series upto {0} terms : {1} \n", num, sum);
        }
    }
}