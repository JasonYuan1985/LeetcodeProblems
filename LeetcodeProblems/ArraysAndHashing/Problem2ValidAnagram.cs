namespace LeetcodeProblems.ArraysAndHashing
{
    public class Problem2ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {

            //return new string(s.OrderBy(c => c).ToArray()) == new string(t.OrderBy(c => c).ToArray());

            if (s.Length != t.Length) return false;

            var sourceCharList = s.ToCharArray().ToList();
            sourceCharList.Sort();
            var targetCharList = t.ToCharArray().ToList();
            targetCharList.Sort();

            for (int i = 0; i < sourceCharList.Count; i++)
            {
                if (sourceCharList[i] != targetCharList[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
