namespace LeetcodeProblems.TwoPointers
{
    public class Problem2TwoSumIIInputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int startIndex = 0;
            int endIndex = numbers.Length - 1;
            while (startIndex < endIndex)
            {
                int startValue = numbers[startIndex];
                int endValue = numbers[endIndex];

                if (startValue + endValue > target)
                {
                    endIndex--;
                    continue;
                }
                else if (startValue + endValue < target)
                {
                    startIndex++;
                    continue;
                }
                else
                {
                    return new int[2] { startIndex + 1, endIndex + 1 };
                }
            }

            return new int[0];
        }
    }
}
