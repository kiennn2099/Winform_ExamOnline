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
    public partial class ListExam : Form
    {
        public ListExam()
        {
            InitializeComponent();
        }
        public Button btnLoad { get => button1; }
        public DataGridView dgvListExam { get => dataGridView1; }
        public Button btnClose { get => button2; }

        public Button btnSearch { get => button3; }
        public TextBox txtSearch { get => textBox1; }


    }
}
