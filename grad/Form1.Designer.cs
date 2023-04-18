namespace grad
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
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 46);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 3;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(874, 583);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 23);
            button2.Name = "button2";
            button2.Size = new Size(207, 23);
            button2.TabIndex = 2;
            button2.Text = "Змоделювати лін залежність";
            button2.UseVisualStyleBackColor = true;
            button2.Click += generate_regression_click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "1 1";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(880, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 605);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 605);
            panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(880, 605);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 605);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
    }
}