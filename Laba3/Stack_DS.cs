using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Stack_DS
    {
        List<int> stack = new List<int>();

        public bool IsEmpty()
        {
            return (stack.Count == 0);
        }

        public void Push(int value)
        {
            stack.Add(value);
        }

        public void Pop()
        {
            if (stack.Count > 0)
                stack.RemoveAt(stack.Count - 1);
        }

        public void Sort()
        {
            stack.Sort();
        }

        public bool inStack(int value)
        {
            return stack.Contains(value);
        }

        public string Print()
        {
            string stackToPrint = "";
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                stackToPrint += (stack[i].ToString() + " ");
            }
            return stackToPrint;
        }
        public string Top()
        {
            return stack[stack.Count - 1].ToString();
        }
    }
}
