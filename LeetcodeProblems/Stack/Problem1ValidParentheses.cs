namespace LeetcodeProblems.Stack
{
    public class Problem1ValidParentheses
    {
        //public bool IsValid(string s)
        //{
        //    Stack<char> bracketsStack = new Stack<char>();

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        //check char, if (,{,[, then enqueue
        //        if (s[i] == '(')
        //        {
        //            bracketsStack.Push(')');
        //        }
        //        else if (s[i] == '{')
        //        {
        //            bracketsStack.Push('}');
        //        }
        //        else if (s[i] == '[')
        //        {
        //            bracketsStack.Push(']');
        //        }
        //        else if (bracketsStack.Count > 0 && bracketsStack.Peek() == s[i])
        //        {
        //            //other if found ),},] then dequeue 
        //            bracketsStack.Pop();
        //        }
        //        else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
        //        {
        //            return false;
        //        }
        //    }

        //    return bracketsStack.Count == 0;
        //}

        public bool IsValid(string s)
        {
            Stack<char> blah = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    blah.Push(c);
                    continue;
                }

                switch (c)
                {
                    case ')':
                        if (blah.Count == 0 || blah.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (blah.Count == 0 || blah.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (blah.Count == 0 || blah.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            }
            return blah.Count == 0;
        }
    }
}
