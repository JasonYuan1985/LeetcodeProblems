using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.SlidingWindow
{
    public class Problem1BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyDay = 0;
            int sellDay = 0;
            int buyDayValue = prices[buyDay];

            for (int i= 1;i<prices.Length;i++)
            {
                if(prices[i] < buyDayValue)
                {
                    buyDayValue = prices[i];
                }

                sellDay = i;

                maxProfit = Math.Max(maxProfit, prices[sellDay] - buyDayValue);
            }

            return maxProfit;
        }
    }
}
