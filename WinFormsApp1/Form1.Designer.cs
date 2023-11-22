namespace WinFormsApp1
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
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            txtName = new TextBox();
            txtPrice = new TextBox();
            button3 = new Button();
            textBox1 = new TextBox();
            txtUpdateName = new TextBox();
            txtUpdatePrice = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 318);
            button1.Name = "button1";
            button1.Size = new Size(280, 49);
            button1.TabIndex = 0;
            button1.Text = "LİST";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 284);
            listBox1.TabIndex = 1;
            listBox1.Click += listBox1_Click;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(316, 104);
            button2.Name = "button2";
            button2.Size = new Size(189, 29);
            button2.TabIndex = 2;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(316, 12);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(189, 27);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(316, 57);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(189, 27);
            txtPrice.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(529, 104);
            button3.Name = "button3";
            button3.Size = new Size(190, 29);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 57);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Delete Id";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 6;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(316, 174);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(189, 27);
            txtUpdateName.TabIndex = 7;
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.Location = new Point(316, 216);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.Size = new Size(189, 27);
            txtUpdatePrice.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(316, 267);
            button4.Name = "button4";
            button4.Size = new Size(189, 29);
            button4.TabIndex = 9;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(txtUpdatePrice);
            Controls.Add(txtUpdateName);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button button3;
        private TextBox textBox1;
        private TextBox txtUpdateName;
        private TextBox txtUpdatePrice;
        private Button button4;
    }
}
