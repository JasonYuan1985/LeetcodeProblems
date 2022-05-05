using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeProblems.Stack.Tests
{
    [TestClass()]
    public class MinStackTests
    {
        [TestMethod()]
        public void MinStack_Example1()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.AreEqual(-3, minStack.GetMin()); // return -3
            minStack.Pop();
            Assert.AreEqual(0, minStack.Top()); // return 0
            Assert.AreEqual(-2, minStack.GetMin()); // return -2
        }

        [TestMethod()]
        public void MinStack_Example2()
        {
            //["MinStack","push","push","push","push","getMin","pop","getMin","pop","getMin","pop","getMin"]
            //[[],[2],[0],[3],[0],[],[],[],[],[],[],[]]
            MinStack minStack = new MinStack();
            minStack.Push(2);
            minStack.Push(0);
            minStack.Push(3);
            minStack.Push(0);
            Assert.AreEqual(0, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(0, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(0, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(2, minStack.GetMin());
        }

        [TestMethod()]
        public void MinStack_Example3()
        {
            //["MinStack","push","push","push","top","pop","getMin","pop","getMin","pop","push","top","getMin","push","top","getMin","pop","getMin"]
            //[[],[2147483646],[2147483646],[2147483647],[],[],[],[],[],[],[2147483647],[],[],[-2147483648],[],[],[],[]]
            MinStack minStack = new MinStack();
            minStack.Push(2147483646);
            minStack.Push(2147483646);
            minStack.Push(2147483647);
            minStack.Top();
            minStack.Pop();
            Assert.AreEqual(2147483646, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(2147483646, minStack.GetMin());
            minStack.Pop();
            minStack.Push(2147483647);
            minStack.Top();
            Assert.AreEqual(2147483647, minStack.GetMin());
            minStack.Push(-2147483648);
            minStack.Top();
            Assert.AreEqual(-2147483648, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(2147483647, minStack.GetMin());
        }

        [TestMethod()]
        public void MinStack_Example4()
        {
            //["MinStack","push","push","getMin","getMin","push","getMin","getMin","top","getMin","pop","push","push","getMin","push","pop","top","getMin","pop"]
            //[[],[-10],[14],[],[],[-20],[],[],[],[],[],[10],[-7],[],[-7],[],[],[],[]]
            MinStack minStack = new MinStack();
            minStack.Push(-10);
            minStack.Push(14);
            Assert.AreEqual(-10, minStack.GetMin());
            Assert.AreEqual(-10, minStack.GetMin());
            minStack.Push(-20);
            Assert.AreEqual(-20, minStack.GetMin());
            Assert.AreEqual(-20, minStack.GetMin());
            Assert.AreEqual(-20, minStack.Top());
            Assert.AreEqual(-20, minStack.GetMin());
            minStack.Pop();
            minStack.Push(10);
            minStack.Push(-7);
            Assert.AreEqual(-10, minStack.GetMin());
            minStack.Push(-7);
            minStack.Pop();
            Assert.AreEqual(-7, minStack.Top());
            Assert.AreEqual(-10, minStack.GetMin());
            minStack.Pop();
        }
    }
}