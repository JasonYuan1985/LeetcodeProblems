namespace LeetcodeProblems.ArraysAndHashing
{
    public class Problem4GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();

            Dictionary<string, List<string>> tempCompareResult = new Dictionary<string, List<string>>();

            //create hashtable for each word
            foreach (string str in strs)
            {
                string sortString = GetSortString(str);

                //compare each hashtable if they are the same
                if (tempCompareResult.ContainsKey(sortString))
                {
                    //if same then insert the list to return dictionary
                    tempCompareResult[sortString].Add(str);
                }
                else
                {
                    tempCompareResult.Add(sortString, new List<string>() { str });
                }
            }

            foreach (var item in tempCompareResult)
            {
                result.Add(item.Value.ToArray());
            }

            return result;
        }

        private string GetSortString(string s)
        {
            var sourceCharList = s.ToCharArray().ToList();
            sourceCharList.Sort();

            return string.Join("", sourceCharList);
        }
    }
}
