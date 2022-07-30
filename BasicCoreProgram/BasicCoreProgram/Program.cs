namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swap : num1 = " + num1 + " num2 = " + num2);

            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;

            Console.WriteLine("After Swap : num1 = " + num1 + " num2 = " + num2);
        }
    }
}