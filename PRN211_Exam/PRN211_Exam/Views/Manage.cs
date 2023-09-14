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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        public Button btnViewSV { get => button1; }
        public Button btnViewListExam { get => button2; }
        public Button btnExit { get => button3; }
    }
}
