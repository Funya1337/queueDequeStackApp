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
        Logs logs = new Logs();
        Stack_DS stack = new Stack_DS();
        Deque_DS deque = new Deque_DS();
        Queue_DS queue = new Queue_DS();
        public int addStackValue;
        public int addDequeValue;
        public int addQueueValue;
        public int elementToFind;
        public const string fromStack = "stack";
        public const string fromDeque = "deque";
        public const string fromQueue = "queue";
        public string[] logMethods = { "add", "pop", "isEmpty", "top", "sort", "addFront", "addBack", "popFront", "popBack", "size", "enqueue", "dequeue", "find" };
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            stack.Push(addStackValue);
            stackLabel.Text = stack.Print();
            logs.appendLog(fromStack, logMethods[0]);
        }

        private void popBtn_Click(object sender, EventArgs e)
        {
            stack.Pop();
            stackLabel.Text = stack.Print();
            logs.appendLog(fromStack, logMethods[1]);
        }

        private void stackValue_ValueChanged(object sender, EventArgs e)
        {
            addStackValue = int.Parse(stackValue.Value.ToString());
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.Top());
            logs.appendLog(fromStack, logMethods[3]);
        }

        private void isEmptyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.IsEmpty().ToString());
            logs.appendLog(fromStack, logMethods[2]);
        }

        private void dequeValue_ValueChanged(object sender, EventArgs e)
        {
            addDequeValue = int.Parse(dequeValue.Value.ToString());
        }

        private void AddFrontBtn_Click(object sender, EventArgs e)
        {
            deque.PushFront(addDequeValue);
            dequeLabel.Text = deque.Print();
            logs.appendLog(fromDeque, logMethods[5]);
        }

        private void AddBackBtn_Click(object sender, EventArgs e)
        {
            deque.PushBack(addDequeValue);
            dequeLabel.Text = deque.Print();
            logs.appendLog(fromDeque, logMethods[6]);
        }

        private void PopFrontBtn_Click(object sender, EventArgs e)
        {
            deque.PopFront();
            dequeLabel.Text = deque.Print();
            logs.appendLog(fromDeque, logMethods[7]);
        }

        private void PopBackBtn_Click(object sender, EventArgs e)
        {
            deque.PopBack();
            dequeLabel.Text = deque.Print();
            logs.appendLog(fromDeque, logMethods[8]);
        }

        private void dequeEmptyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deque.IsEmpty().ToString());
            logs.appendLog(fromDeque, logMethods[2]);
        }

        private void dequeSizeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deque.Size());
            logs.appendLog(fromDeque, logMethods[9]);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            addQueueValue = int.Parse(queueValue.Value.ToString());
        }

        private void enqueueBtn_Click(object sender, EventArgs e)
        {
            queue.Enqueue(addQueueValue);
            queueLabel.Text = queue.Print();
            logs.appendLog(fromQueue, logMethods[10]);
        }

        private void dequeueBtn_Click(object sender, EventArgs e)
        {
            queue.Dequeue();
            queueLabel.Text = queue.Print();
            logs.appendLog(fromQueue, logMethods[11]);
        }

        private void queueEmptyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.IsEmpty().ToString());
            logs.appendLog(fromQueue, logMethods[2]);
        }

        private void queueSizeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.Size());
            logs.appendLog(fromQueue, logMethods[9]);
        }

        private void sortStackBtn_Click(object sender, EventArgs e)
        {
            stack.Sort();
            stackLabel.Text = stack.Print();
            logs.appendLog(fromStack, logMethods[4]);
        }

        private void sortDequeBtn_Click(object sender, EventArgs e)
        {
            deque.Sort();
            dequeLabel.Text = deque.Print();
            logs.appendLog(fromDeque, logMethods[4]);
        }

        private void sortQueueBtn_Click(object sender, EventArgs e)
        {
            queue.Sort();
            queueLabel.Text = queue.Print();
            logs.appendLog(fromQueue, logMethods[4]);
        }

        private void searchElementBox_ValueChanged(object sender, EventArgs e)
        {
            elementToFind = int.Parse(searchElementBox.Value.ToString());
        }

        private void findInStack_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.inStack(elementToFind).ToString());
            logs.appendLog(fromStack, logMethods[12]);
        }

        private void findInDeque_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deque.inDeque(elementToFind).ToString());
            logs.appendLog(fromDeque, logMethods[12]);
        }

        private void findInQueue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.inQueue(elementToFind).ToString());
            logs.appendLog(fromQueue, logMethods[12]);
        }

        private void writeLogsBtn_Click(object sender, EventArgs e)
        {
            logs.writeLogsInFile();
            MessageBox.Show("Succesfully write logs!");
        }

        private void showLogsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(Environment.NewLine, logs.getLogsArray()));
        }

        private void clearfileBtn_Click(object sender, EventArgs e)
        {
            logs.clearLogs();
            MessageBox.Show("Succesfully clear logs!");
        }
    }
}
