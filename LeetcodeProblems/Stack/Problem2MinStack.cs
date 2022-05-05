namespace LeetcodeProblems.Stack
{
    public class MinStack
    {
        List<int> simulationStack;
        Dictionary<int, int> minValueDictionary;
        int currentIndex = -1;
        int minValue = 0;
        public MinStack()
        {
            minValue = 0;
            currentIndex = -1;
            simulationStack = new List<int>();
            minValueDictionary = new Dictionary<int, int>();
        }

        public void Push(int val)
        {
            currentIndex++;
            simulationStack.Add(val);
            minValue = currentIndex == 0 ? val : Math.Min(minValue, val);
            minValueDictionary.Add(currentIndex, minValue);
        }

        public void Pop()
        {
            if (currentIndex < 0)
            {
                return;
            }
            else
            {
                simulationStack.RemoveAt(currentIndex);
                minValueDictionary.Remove(currentIndex);
                currentIndex--;
                minValue = GetMin();
            }
        }

        public int Top()
        {
            if (simulationStack.Count == 0)
            {
                return 0;
            }
            else
            {
                return simulationStack[currentIndex];
            }
        }

        public int GetMin()
        {
            if (minValueDictionary.Count == 0)
            {
                return 0;
            }
            else
            {
                return minValueDictionary[currentIndex];
            }
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
