using System;

namespace coins
{
    class Program
    {
        static int MakeChangeHelper(int total, int[] coins, int index)
        {
            int coin = coins[index];
            if (index == coins.Length - 1)
            {
                int remaining = total % coin;
                return remaining == 0 ? 1 : 0;
            }

            int ways = 0;
            for (int amount = 0; amount <= total; amount += coin)
            {
                ways += MakeChangeHelper(total - amount, coins, index + 1);
            }

            return ways;
        }

        static int MakeChange(int total, int[] coins)
        {
            return MakeChangeHelper(total, coins, 0);
        }

        static void Main(string[] args)
        {
            var coins = new[] {1, 5, 10, 25};
            var total = 5;

            Console.WriteLine($"There are {MakeChange(total, coins)} ways to make change for {total}");
        }
    }
}
