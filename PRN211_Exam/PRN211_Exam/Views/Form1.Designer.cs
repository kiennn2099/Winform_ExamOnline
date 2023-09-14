namespace PRN211_Exam
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
            tbExamCode = new TextBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbExamCode
            // 
            tbExamCode.Location = new Point(140, 47);
            tbExamCode.Name = "tbExamCode";
            tbExamCode.Size = new Size(343, 27);
            tbExamCode.TabIndex = 3;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(140, 105);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(343, 27);
            tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(140, 169);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(343, 27);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(140, 228);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(310, 228);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 8;
            label1.Text = "Exam Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 108);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 9;
            label2.Text = "UserName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 172);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 284);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(tbExamCode);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbExamCode;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}