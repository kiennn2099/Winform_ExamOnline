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
    public partial class ListSV : Form
    {
        public ListSV()
        {
            InitializeComponent();
        }

        public Button btnLoad { get => button2; }
        public DataGridView dgvListSV { get => dataGridView1; }
        public Button btnClose { get => button3; }
        public ComboBox cbxRole { get => comboBox1; }



    }
}
