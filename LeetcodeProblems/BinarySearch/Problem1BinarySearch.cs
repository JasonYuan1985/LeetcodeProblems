namespace LeetcodeProblems.BinarySearch
{
    public class Problem1BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;

            int not_Found_Index = -1;
            int result = not_Found_Index;

            int searchIndex = nums.Length / 2;
            int startIndex = 0;
            int endIndex = nums.Length - 1;

            if (nums[startIndex] == target) return startIndex;

            if (nums[endIndex] == target) return endIndex;

            while (searchIndex > startIndex && searchIndex < endIndex)
            {
                if (nums[searchIndex] == target)
                {
                    result = searchIndex;
                    break;
                }
                else if (nums[searchIndex] > target)
                {
                    endIndex = searchIndex;
                    if (searchIndex < 2) break;
                    searchIndex = startIndex + (endIndex - startIndex) / 2;
                }
                else
                {
                    if ((endIndex - searchIndex) < 2) break;
                    startIndex = searchIndex;
                    searchIndex = searchIndex + (endIndex - searchIndex) / 2;
                }
            }

            return result;
        }
    }
}
