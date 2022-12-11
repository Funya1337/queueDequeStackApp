using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        Stack_DS stack = new Stack_DS();
        Deque_DS deque = new Deque_DS();
        Queue_DS queue = new Queue_DS();
        public int addStackValue;
        public int addDequeValue;
        public int addQueueValue;
        public int elementToFind;
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            stack.Push(addStackValue);
            stackLabel.Text = stack.Print();
        }

        private void popBtn_Click(object sender, EventArgs e)
        {
            stack.Pop();
            stackLabel.Text = stack.Print();
        }

        private void stackValue_ValueChanged(object sender, EventArgs e)
        {
            addStackValue = int.Parse(stackValue.Value.ToString());
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.Top());
        }

        private void isEmptyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.IsEmpty().ToString());
        }

        private void dequeValue_ValueChanged(object sender, EventArgs e)
        {
            addDequeValue = int.Parse(dequeValue.Value.ToString());
        }

        private void AddFrontBtn_Click(object sender, EventArgs e)
        {
            deque.PushFront(addDequeValue);
            dequeLabel.Text = deque.Print();
        }

        private void AddBackBtn_Click(object sender, EventArgs e)
        {
            deque.PushBack(addDequeValue);
            dequeLabel.Text = deque.Print();
        }

        private void PopFrontBtn_Click(object sender, EventArgs e)
        {
            deque.PopFront();
            dequeLabel.Text = deque.Print();
        }

        private void PopBackBtn_Click(object sender, EventArgs e)
        {
            deque.PopBack();
            dequeLabel.Text = deque.Print();
        }

        private void dequeEmptyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deque.IsEmpty().ToString());
        }

        private void dequeSizeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deque.Size());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            addQueueValue = int.Parse(queueValue.Value.ToString());
        }

        private void enqueueBtn_Click(object sender, EventArgs e)
        {
            queue.Enqueue(addQueueValue);
            queueLabel.Text = queue.Print();
        }

        private void dequeueBtn_Click(object sender, EventArgs e)
        {
            queue.Dequeue();
            queueLabel.Text = queue.Print();
        }

        private void queueEmptyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.IsEmpty().ToString());
        }

        private void queueSizeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.Size());
        }

        private void sortStackBtn_Click(object sender, EventArgs e)
        {
            stack.Sort();
            stackLabel.Text = stack.Print();
        }

        private void sortDequeBtn_Click(object sender, EventArgs e)
        {
            deque.Sort();
            dequeLabel.Text = deque.Print();
        }

        private void sortQueueBtn_Click(object sender, EventArgs e)
        {
            queue.Sort();
            queueLabel.Text = queue.Print();
        }

        private void searchElementBox_ValueChanged(object sender, EventArgs e)
        {
            elementToFind = int.Parse(searchElementBox.Value.ToString());
        }

        private void findInStack_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.inStack(elementToFind).ToString());
        }

        private void findInDeque_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deque.inDeque(elementToFind).ToString());
        }

        private void findInQueue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.inQueue(elementToFind).ToString());
        }
    }
}
