namespace WinFormsApp3
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
            button2 = new Button();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(326, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 4;
            button1.Text = "Create threads";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(595, 22);
            button2.Name = "button2";
            button2.Size = new Size(33, 33);
            button2.TabIndex = 5;
            button2.Text = "■";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 31);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Threads number:";
            // 
            // button4
            // 
            button4.Location = new Point(673, 22);
            button4.Name = "button4";
            button4.Size = new Size(33, 33);
            button4.TabIndex = 7;
            button4.Text = "▶";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(634, 22);
            button3.Name = "button3";
            button3.Size = new Size(33, 33);
            button3.TabIndex = 6;
            button3.Text = "❚❚";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(152, 29);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(426, 22);
            button5.Name = "button5";
            button5.Size = new Size(94, 33);
            button5.TabIndex = 9;
            button5.Text = "Start";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button4;
        private Button button3;
        private NumericUpDown numericUpDown1;
        private Button button5;
    }
}
