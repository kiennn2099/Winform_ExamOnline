using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Exam.Views
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        public TextBox txtQuestionId { get => textBox1; }
        public TextBox txtExamId { get => textBox2; }
        public TextBox txtAswer1 { get => textBox3; }
        public RichTextBox rtbQuestion { get => richTextBox1; }
        public RichTextBox rtbAswerA { get => richTextBox5; }
        public RichTextBox rtbAswerB { get => richTextBox4; }
        public RichTextBox rtbAswerC { get => richTextBox3; }
        public RichTextBox rtbAswerD { get => richTextBox2; }
        public Button btnInsert { get => button1; }
        public Button btnEdit { get => button2; }
        public Button btnDelete { get => button3; }
        public Button btnClose { get => button4; }
    }
}
