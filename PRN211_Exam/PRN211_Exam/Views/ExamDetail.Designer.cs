namespace PRN211_Exam.Views
{
    partial class ExamDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            checkBox1 = new CheckBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(474, 394);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(441, 409);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 5;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 409);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 6;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(687, 409);
            button4.Name = "button4";
            button4.Size = new Size(101, 29);
            button4.TabIndex = 8;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 9;
            label1.Text = "Exam Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 53);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 10;
            label2.Text = "Exam Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 92);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 205);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 12;
            label4.Text = "Test Day";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(26, 234);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(104, 92);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Open/Close";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 125);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 15;
            label5.Text = "Exam Time";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 27);
            textBox3.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 169);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 17;
            label6.Text = "numberQuestions";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(562, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "SaveToFile";
            button3.UseVisualStyleBackColor = true;
            // 
            // ExamDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "ExamDetail";
            Text = "ExamDetail";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Button button3;
    }
}