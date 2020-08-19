using System;
using System.Collections.Generic;

namespace stock_buy_sell
{
    class Program
    {
        static void MaxBuySell(int[] price)
        {
            var mins = new List<int>(); // The local mins
            var maxs = new List<int>(); // The local maxs
            var i = 0;
            while (i < price.Length - 1)
            {
                // Iterate through the list to find the local minimum
                while (i < price.Length - 1 && price[i] >= price[i + 1]) i++;

                if (i == price.Length - 1) break;

                // Add the min to the local minimums array
                mins.Add(price[i]);
                var buyDate = i++;

                // Iterate through the list to find the local maximum
                while (i < price.Length - 1 && price[i] <= price[i + 1]) i++;
                maxs.Add(price[i]);
                var sellDate = i++;

                Console.WriteLine($"Buy on day: {buyDate} and Sell on day: {sellDate}");
            }
            var profit = 0;
            for (var j = 0; j < mins.Count; j++)
            {
                profit += maxs[j] - mins[j];
            }

            Console.WriteLine($"Total profit {profit}");
        }

        static void Main(string[] args)
        {
            var arr = new []{100, 180, 260, 310, 40, 535, 695};
            MaxBuySell(arr);
        }
    }
}
