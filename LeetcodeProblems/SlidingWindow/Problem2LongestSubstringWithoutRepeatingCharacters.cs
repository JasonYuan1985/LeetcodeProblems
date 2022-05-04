namespace LeetcodeProblems.SlidingWindow
{
    public class Problem2LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            //SlidingWindow
            string givenString = s;
            int maxLength = 0;
            int startIndex = 0;
            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < givenString.Length; i++)
            {
                if (characters.ContainsKey(givenString[i]))
                {
                    startIndex = Math.Max(characters[givenString[i]] + 1, startIndex);
                    characters[givenString[i]] = i;
                }
                else
                {
                    characters.Add(givenString[i], i);
                }

                maxLength = Math.Max(maxLength, i - startIndex + 1);
            }


            return maxLength;
        }

        //public int LengthOfLongestSubstring(string s)
        //{
        //    int maxLength = 0;
        //    string givenString = s;
        //    //HashSet<char> characters = new HashSet<char>();
        //    List<char> characters = new List<char>();

        //    for (int i = 0; i < givenString.Length; i++)
        //    {
        //        if (!characters.Contains(givenString[i]))
        //        {
        //            characters.Add(givenString[i]);
        //        }
        //        else
        //        {
        //            maxLength = Math.Max(maxLength, characters.Count);

        //            //Get the list after the repeating character
        //            characters = characters.Skip(characters.IndexOf(givenString[i]) + 1).ToList();
        //            characters.Add(givenString[i]);
        //        }
        //    }

        //    maxLength = Math.Max(maxLength, characters.Count);

        //    return maxLength;
        //}
    }
}
