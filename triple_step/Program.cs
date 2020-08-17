using System;

namespace triple_step
{
    class Program
    {
        static int countWaysMemo(int n, int[] memo)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (memo[n] > -1)
            {
                return memo[n];
            }
            else
            {
                memo[n] = countWaysMemo(n - 1, memo) + countWaysMemo(n - 2, memo) + countWaysMemo(n - 3, memo);
                return memo[n];
             }
        }

        static int countWays(int n)
        {
            int[] memo = new int[n + 1];
            Array.Fill(memo, -1);
            return countWaysMemo(n, memo);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of ways to go up the steps: " + countWays(10));
        }
    }
}
