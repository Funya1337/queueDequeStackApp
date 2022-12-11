using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Stack_DS
    {
/*        Logs logs = new Logs();*/
        List<int> stack = new List<int>();

        public bool IsEmpty()
        {
            return (stack.Count == 0);
        }

        public void Push(int value)
        {
            stack.Add(value);
/*            logs.appendLog("stack", "push", value);*/
        }

        public void Pop()
        {
            if (stack.Count > 0)
                stack.RemoveAt(stack.Count - 1);
/*            logs.appendLog("stack", "pop", -1);*/
        }

        public void Sort()
        {
            stack.Sort();
/*            logs.appendLog("stack", "sort", -1);*/
        }

        public bool inStack(int value)
        {
/*            logs.appendLog("stack", "inStack", -1);*/
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
/*            logs.appendLog("stack", "top", -1);*/
            return stack[stack.Count - 1].ToString();
        }
    }
}
