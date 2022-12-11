using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Queue_DS
    {
        List<int> queue = new List<int>();
        
        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public void Enqueue(int value)
        {
            queue.Add(value);
        }

        public void Dequeue()
        {
            if (queue.Count > 0)
                queue.RemoveAt(0);
        }
        public string Size()
        {
            return queue.Count.ToString();
        }

        public void Sort()
        {
            queue.Sort();
        }
        public bool inQueue(int value)
        {
            return queue.Contains(value);
        }

        public string Print()
        {
            string dequeToPrint = "";
            for (int i = 0; i < queue.Count; ++i)
            {
                dequeToPrint += (queue[i].ToString() + " ");
            }
            return dequeToPrint;
        }
    }
}
