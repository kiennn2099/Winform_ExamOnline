namespace PRN211_Exam.Views
{
    partial class SV
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 54);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 119);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(232, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 57);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Ma SV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 122);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Ten SV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 194);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 191);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(200, 263);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 266);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "Role:";
            // 
            // SV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "SV";
            Text = "SV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
    }
}