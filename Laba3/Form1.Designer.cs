
namespace Laba3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.popBtn = new System.Windows.Forms.Button();
            this.topBtn = new System.Windows.Forms.Button();
            this.stackLabel = new System.Windows.Forms.Label();
            this.stackValue = new System.Windows.Forms.NumericUpDown();
            this.isEmptyBtn = new System.Windows.Forms.Button();
            this.StackTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dequeEmptyBtn = new System.Windows.Forms.Button();
            this.dequeValue = new System.Windows.Forms.NumericUpDown();
            this.dequeLabel = new System.Windows.Forms.Label();
            this.dequeSizeBtn = new System.Windows.Forms.Button();
            this.PopFrontBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddFrontBtn = new System.Windows.Forms.Button();
            this.AddBackBtn = new System.Windows.Forms.Button();
            this.PopBackBtn = new System.Windows.Forms.Button();
            this.dequeueBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.queueEmptyBtn = new System.Windows.Forms.Button();
            this.queueValue = new System.Windows.Forms.NumericUpDown();
            this.queueLabel = new System.Windows.Forms.Label();
            this.queueSizeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.enqueueBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.sortStackBtn = new System.Windows.Forms.Button();
            this.sortDequeBtn = new System.Windows.Forms.Button();
            this.sortQueueBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.findInStack = new System.Windows.Forms.Button();
            this.findInDeque = new System.Windows.Forms.Button();
            this.findInQueue = new System.Windows.Forms.Button();
            this.searchElementBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stackValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dequeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchElementBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(43, 85);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "STACK:";
            // 
            // popBtn
            // 
            this.popBtn.Location = new System.Drawing.Point(43, 114);
            this.popBtn.Name = "popBtn";
            this.popBtn.Size = new System.Drawing.Size(75, 23);
            this.popBtn.TabIndex = 2;
            this.popBtn.Text = "Pop";
            this.popBtn.UseVisualStyleBackColor = true;
            this.popBtn.Click += new System.EventHandler(this.popBtn_Click);
            // 
            // topBtn
            // 
            this.topBtn.Location = new System.Drawing.Point(43, 172);
            this.topBtn.Name = "topBtn";
            this.topBtn.Size = new System.Drawing.Size(75, 23);
            this.topBtn.TabIndex = 3;
            this.topBtn.Text = "Top";
            this.topBtn.UseVisualStyleBackColor = true;
            this.topBtn.Click += new System.EventHandler(this.topBtn_Click);
            // 
            // stackLabel
            // 
            this.stackLabel.AutoSize = true;
            this.stackLabel.Location = new System.Drawing.Point(122, 215);
            this.stackLabel.Name = "stackLabel";
            this.stackLabel.Size = new System.Drawing.Size(41, 15);
            this.stackLabel.TabIndex = 4;
            this.stackLabel.Text = "Empty";
            // 
            // stackValue
            // 
            this.stackValue.Location = new System.Drawing.Point(43, 56);
            this.stackValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stackValue.Name = "stackValue";
            this.stackValue.Size = new System.Drawing.Size(120, 23);
            this.stackValue.TabIndex = 6;
            this.stackValue.ValueChanged += new System.EventHandler(this.stackValue_ValueChanged);
            // 
            // isEmptyBtn
            // 
            this.isEmptyBtn.Location = new System.Drawing.Point(43, 143);
            this.isEmptyBtn.Name = "isEmptyBtn";
            this.isEmptyBtn.Size = new System.Drawing.Size(75, 23);
            this.isEmptyBtn.TabIndex = 7;
            this.isEmptyBtn.Text = "IsEmpty";
            this.isEmptyBtn.UseVisualStyleBackColor = true;
            this.isEmptyBtn.Click += new System.EventHandler(this.isEmptyBtn_Click);
            // 
            // StackTitle
            // 
            this.StackTitle.AutoSize = true;
            this.StackTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StackTitle.Location = new System.Drawing.Point(43, 9);
            this.StackTitle.Name = "StackTitle";
            this.StackTitle.Size = new System.Drawing.Size(73, 32);
            this.StackTitle.TabIndex = 8;
            this.StackTitle.Text = "Stack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(324, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Deque";
            // 
            // dequeEmptyBtn
            // 
            this.dequeEmptyBtn.Location = new System.Drawing.Point(324, 201);
            this.dequeEmptyBtn.Name = "dequeEmptyBtn";
            this.dequeEmptyBtn.Size = new System.Drawing.Size(75, 23);
            this.dequeEmptyBtn.TabIndex = 15;
            this.dequeEmptyBtn.Text = "IsEmpty";
            this.dequeEmptyBtn.UseVisualStyleBackColor = true;
            this.dequeEmptyBtn.Click += new System.EventHandler(this.dequeEmptyBtn_Click);
            // 
            // dequeValue
            // 
            this.dequeValue.Location = new System.Drawing.Point(324, 56);
            this.dequeValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dequeValue.Name = "dequeValue";
            this.dequeValue.Size = new System.Drawing.Size(120, 23);
            this.dequeValue.TabIndex = 14;
            this.dequeValue.ValueChanged += new System.EventHandler(this.dequeValue_ValueChanged);
            // 
            // dequeLabel
            // 
            this.dequeLabel.AutoSize = true;
            this.dequeLabel.Location = new System.Drawing.Point(403, 273);
            this.dequeLabel.Name = "dequeLabel";
            this.dequeLabel.Size = new System.Drawing.Size(41, 15);
            this.dequeLabel.TabIndex = 13;
            this.dequeLabel.Text = "Empty";
            // 
            // dequeSizeBtn
            // 
            this.dequeSizeBtn.Location = new System.Drawing.Point(324, 230);
            this.dequeSizeBtn.Name = "dequeSizeBtn";
            this.dequeSizeBtn.Size = new System.Drawing.Size(75, 23);
            this.dequeSizeBtn.TabIndex = 12;
            this.dequeSizeBtn.Text = "Size";
            this.dequeSizeBtn.UseVisualStyleBackColor = true;
            this.dequeSizeBtn.Click += new System.EventHandler(this.dequeSizeBtn_Click);
            // 
            // PopFrontBtn
            // 
            this.PopFrontBtn.Location = new System.Drawing.Point(324, 143);
            this.PopFrontBtn.Name = "PopFrontBtn";
            this.PopFrontBtn.Size = new System.Drawing.Size(75, 23);
            this.PopFrontBtn.TabIndex = 11;
            this.PopFrontBtn.Text = "PopFront";
            this.PopFrontBtn.UseVisualStyleBackColor = true;
            this.PopFrontBtn.Click += new System.EventHandler(this.PopFrontBtn_Click);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DEQUE:";
            // 
            // AddFrontBtn
            // 
            this.AddFrontBtn.Location = new System.Drawing.Point(324, 85);
            this.AddFrontBtn.Name = "AddFrontBtn";
            this.AddFrontBtn.Size = new System.Drawing.Size(75, 23);
            this.AddFrontBtn.TabIndex = 9;
            this.AddFrontBtn.Text = "AddFront";
            this.AddFrontBtn.UseVisualStyleBackColor = true;
            this.AddFrontBtn.Click += new System.EventHandler(this.AddFrontBtn_Click);
            // 
            // AddBackBtn
            // 
            this.AddBackBtn.Location = new System.Drawing.Point(324, 114);
            this.AddBackBtn.Name = "AddBackBtn";
            this.AddBackBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBackBtn.TabIndex = 17;
            this.AddBackBtn.Text = "AddBack";
            this.AddBackBtn.UseVisualStyleBackColor = true;
            this.AddBackBtn.Click += new System.EventHandler(this.AddBackBtn_Click);
            // 
            // PopBackBtn
            // 
            this.PopBackBtn.Location = new System.Drawing.Point(322, 172);
            this.PopBackBtn.Name = "PopBackBtn";
            this.PopBackBtn.Size = new System.Drawing.Size(75, 23);
            this.PopBackBtn.TabIndex = 18;
            this.PopBackBtn.Text = "PopBack";
            this.PopBackBtn.UseVisualStyleBackColor = true;
            this.PopBackBtn.Click += new System.EventHandler(this.PopBackBtn_Click);
            // 
            // dequeueBtn
            // 
            this.dequeueBtn.Location = new System.Drawing.Point(580, 114);
            this.dequeueBtn.Name = "dequeueBtn";
            this.dequeueBtn.Size = new System.Drawing.Size(75, 23);
            this.dequeueBtn.TabIndex = 27;
            this.dequeueBtn.Text = "Dequeue";
            this.dequeueBtn.UseVisualStyleBackColor = true;
            this.dequeueBtn.Click += new System.EventHandler(this.dequeueBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(580, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Queue";
            // 
            // queueEmptyBtn
            // 
            this.queueEmptyBtn.Location = new System.Drawing.Point(580, 143);
            this.queueEmptyBtn.Name = "queueEmptyBtn";
            this.queueEmptyBtn.Size = new System.Drawing.Size(75, 23);
            this.queueEmptyBtn.TabIndex = 25;
            this.queueEmptyBtn.Text = "IsEmpty";
            this.queueEmptyBtn.UseVisualStyleBackColor = true;
            this.queueEmptyBtn.Click += new System.EventHandler(this.queueEmptyBtn_Click);
            // 
            // queueValue
            // 
            this.queueValue.Location = new System.Drawing.Point(580, 56);
            this.queueValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.queueValue.Name = "queueValue";
            this.queueValue.Size = new System.Drawing.Size(120, 23);
            this.queueValue.TabIndex = 24;
            this.queueValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Location = new System.Drawing.Point(659, 215);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(41, 15);
            this.queueLabel.TabIndex = 23;
            this.queueLabel.Text = "Empty";
            // 
            // queueSizeBtn
            // 
            this.queueSizeBtn.Location = new System.Drawing.Point(580, 172);
            this.queueSizeBtn.Name = "queueSizeBtn";
            this.queueSizeBtn.Size = new System.Drawing.Size(75, 23);
            this.queueSizeBtn.TabIndex = 22;
            this.queueSizeBtn.Text = "Size";
            this.queueSizeBtn.UseVisualStyleBackColor = true;
            this.queueSizeBtn.Click += new System.EventHandler(this.queueSizeBtn_Click);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "QUEUE:";
            // 
            // enqueueBtn
            // 
            this.enqueueBtn.Location = new System.Drawing.Point(580, 85);
            this.enqueueBtn.Name = "enqueueBtn";
            this.enqueueBtn.Size = new System.Drawing.Size(75, 23);
            this.enqueueBtn.TabIndex = 19;
            this.enqueueBtn.Text = "Enqueue";
            this.enqueueBtn.UseVisualStyleBackColor = true;
            this.enqueueBtn.Click += new System.EventHandler(this.enqueueBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(683, 395);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(105, 43);
            this.logBtn.TabIndex = 28;
            this.logBtn.Text = "SHOW LOGS";
            this.logBtn.UseVisualStyleBackColor = true;
            // 
            // sortStackBtn
            // 
            this.sortStackBtn.Location = new System.Drawing.Point(124, 85);
            this.sortStackBtn.Name = "sortStackBtn";
            this.sortStackBtn.Size = new System.Drawing.Size(75, 23);
            this.sortStackBtn.TabIndex = 29;
            this.sortStackBtn.Text = "SortStack";
            this.sortStackBtn.UseVisualStyleBackColor = true;
            this.sortStackBtn.Click += new System.EventHandler(this.sortStackBtn_Click);
            // 
            // sortDequeBtn
            // 
            this.sortDequeBtn.Location = new System.Drawing.Point(405, 85);
            this.sortDequeBtn.Name = "sortDequeBtn";
            this.sortDequeBtn.Size = new System.Drawing.Size(75, 23);
            this.sortDequeBtn.TabIndex = 30;
            this.sortDequeBtn.Text = "SortDeque";
            this.sortDequeBtn.UseVisualStyleBackColor = true;
            this.sortDequeBtn.Click += new System.EventHandler(this.sortDequeBtn_Click);
            // 
            // sortQueueBtn
            // 
            this.sortQueueBtn.Location = new System.Drawing.Point(661, 85);
            this.sortQueueBtn.Name = "sortQueueBtn";
            this.sortQueueBtn.Size = new System.Drawing.Size(75, 23);
            this.sortQueueBtn.TabIndex = 31;
            this.sortQueueBtn.Text = "SortQueue";
            this.sortQueueBtn.UseVisualStyleBackColor = true;
            this.sortQueueBtn.Click += new System.EventHandler(this.sortQueueBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Type element you want to find:";
            // 
            // findInStack
            // 
            this.findInStack.Location = new System.Drawing.Point(43, 395);
            this.findInStack.Name = "findInStack";
            this.findInStack.Size = new System.Drawing.Size(75, 23);
            this.findInStack.TabIndex = 34;
            this.findInStack.Text = "inStack";
            this.findInStack.UseVisualStyleBackColor = true;
            this.findInStack.Click += new System.EventHandler(this.findInStack_Click);
            // 
            // findInDeque
            // 
            this.findInDeque.Location = new System.Drawing.Point(124, 395);
            this.findInDeque.Name = "findInDeque";
            this.findInDeque.Size = new System.Drawing.Size(75, 23);
            this.findInDeque.TabIndex = 35;
            this.findInDeque.Text = "inDeque";
            this.findInDeque.UseVisualStyleBackColor = true;
            this.findInDeque.Click += new System.EventHandler(this.findInDeque_Click);
            // 
            // findInQueue
            // 
            this.findInQueue.Location = new System.Drawing.Point(43, 424);
            this.findInQueue.Name = "findInQueue";
            this.findInQueue.Size = new System.Drawing.Size(75, 23);
            this.findInQueue.TabIndex = 36;
            this.findInQueue.Text = "inQueue";
            this.findInQueue.UseVisualStyleBackColor = true;
            this.findInQueue.Click += new System.EventHandler(this.findInQueue_Click);
            // 
            // searchElementBox
            // 
            this.searchElementBox.Location = new System.Drawing.Point(43, 366);
            this.searchElementBox.Name = "searchElementBox";
            this.searchElementBox.Size = new System.Drawing.Size(120, 23);
            this.searchElementBox.TabIndex = 37;
            this.searchElementBox.ValueChanged += new System.EventHandler(this.searchElementBox_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 38;
            this.button1.Text = "WRITE LOGS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchElementBox);
            this.Controls.Add(this.findInQueue);
            this.Controls.Add(this.findInDeque);
            this.Controls.Add(this.findInStack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sortQueueBtn);
            this.Controls.Add(this.sortDequeBtn);
            this.Controls.Add(this.sortStackBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.dequeueBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queueEmptyBtn);
            this.Controls.Add(this.queueValue);
            this.Controls.Add(this.queueLabel);
            this.Controls.Add(this.queueSizeBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enqueueBtn);
            this.Controls.Add(this.PopBackBtn);
            this.Controls.Add(this.AddBackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dequeEmptyBtn);
            this.Controls.Add(this.dequeValue);
            this.Controls.Add(this.dequeLabel);
            this.Controls.Add(this.dequeSizeBtn);
            this.Controls.Add(this.PopFrontBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddFrontBtn);
            this.Controls.Add(this.StackTitle);
            this.Controls.Add(this.isEmptyBtn);
            this.Controls.Add(this.stackValue);
            this.Controls.Add(this.stackLabel);
            this.Controls.Add(this.topBtn);
            this.Controls.Add(this.popBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "DataStructures";
            ((System.ComponentModel.ISupportInitialize)(this.stackValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dequeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchElementBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button popBtn;
        private System.Windows.Forms.Button topBtn;
        private System.Windows.Forms.Label stackLabel;
        private System.Windows.Forms.NumericUpDown stackValue;
        private System.Windows.Forms.Button isEmptyBtn;
        private System.Windows.Forms.Label StackTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dequeEmptyBtn;
        private System.Windows.Forms.NumericUpDown dequeValue;
        private System.Windows.Forms.Label dequeLabel;
        private System.Windows.Forms.Button dequeSizeBtn;
        private System.Windows.Forms.Button PopFrontBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddFrontBtn;
        private System.Windows.Forms.Button AddBackBtn;
        private System.Windows.Forms.Button PopBackBtn;
        private System.Windows.Forms.Button dequeueBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button queueEmptyBtn;
        private System.Windows.Forms.NumericUpDown queueValue;
        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.Button queueSizeBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button enqueueBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button sortStackBtn;
        private System.Windows.Forms.Button sortDequeBtn;
        private System.Windows.Forms.Button sortQueueBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findInStack;
        private System.Windows.Forms.Button findInDeque;
        private System.Windows.Forms.Button findInQueue;
        private System.Windows.Forms.NumericUpDown searchElementBox;
        private System.Windows.Forms.Button button1;
    }
}

