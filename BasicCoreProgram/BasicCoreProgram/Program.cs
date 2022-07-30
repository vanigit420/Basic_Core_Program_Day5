namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of times Flip The Coin : ");
            int FlipCoin = Convert.ToInt32(Console.ReadLine());
            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;
            int HeadPercentage;
            int TailPercentage;

            if (FlipCoin > 0)
            {
                for (int i = 1; i <= FlipCoin; i++)
                {
                    Random random = new Random();
                    int num = random.Next(0, 2);
                    if (num == 1)
                    {
                        HeadCount++;
                    }
                    else
                    {
                        TailCount++;
                    }
                    Console.WriteLine(num);
                }
                HeadPercentage = HeadCount * 100 / FlipCoin;
                TailPercentage = TailCount * 100 / FlipCoin;
                Console.WriteLine("HeadPercentage is : " + HeadPercentage);
                Console.WriteLine("TailPercentage is : " + TailPercentage);
            }
        }
    }
}