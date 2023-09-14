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
    public partial class ExamDetail : Form
    {
        public ExamDetail()
        {
            InitializeComponent();
        }
        public TextBox txtExamCode { get => textBox1; }
        public TextBox txtExamName { get => textBox2; }
        public CheckBox chkStatus { get => checkBox1; }
        public MonthCalendar mcExamTime { get => monthCalendar1; }
        public Button btnInsert { get => button1; }
        public Button btnUpdate { get => button2; }
        public Button btnExit { get => button4; }
        public DataGridView dgvListQuestion { get => dataGridView1; }
        public TextBox txtExamTime { get => textBox3; }
        public TextBox txtNumberQuestion { get => textBox4; }
        public Button btnSaveToFile { get => button3; }

    }
}
