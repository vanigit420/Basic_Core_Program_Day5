namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " num1 is greatest among three numbers");
                }
                else if (num3 > num2)
                {
                    Console.WriteLine(num3 + " num3 is greatest among three numbers");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2 + " num2 is greatest among three numbers");
            }
            else
            {
                Console.WriteLine("Numbers are Equals");
            }
        }
    }
}