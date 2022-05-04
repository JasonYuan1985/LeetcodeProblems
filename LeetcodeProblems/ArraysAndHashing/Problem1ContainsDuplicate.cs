namespace LeetcodeProblems.ArraysAndHashing
{
    public class Problem1ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashSet1 = new HashSet<int>();
            bool result = false;

            foreach (int number in nums)
            {
                if (hashSet1.Contains(number))
                {
                    result = true;
                    break;
                }
                else
                {
                    hashSet1.Add(number);
                }
            }

            return result;
        }
    }
}
