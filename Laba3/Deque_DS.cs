using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Deque_DS
    {
        List<int> deque = new List<int>();

        public bool IsEmpty()
        {
            return deque.Count == 0;
        }

        public void PushBack(int value)
        {
            deque.Add(value);
        }

        public void PushFront(int value)
        {
            deque.Insert(0, value);
        }

        public void PopFront()
        {
            if (deque.Count > 0)
                deque.RemoveAt(0);
        }

        public void PopBack()
        {
            if (deque.Count > 0)
                deque.RemoveAt(deque.Count - 1);
        }

        public string Size()
        {
            return deque.Count.ToString();
        }

        public void Sort()
        {
            deque.Sort();
        }

        public bool inDeque(int value)
        {
            return deque.Contains(value);
        }

        public string Print()
        {
            string dequeToPrint = "";
            for (int i = 0; i < deque.Count; ++i)
            {
                dequeToPrint += (deque[i].ToString() + " ");
            }
            return dequeToPrint;
        }

    }
}
