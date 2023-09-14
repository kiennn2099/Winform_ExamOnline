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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }

        public Label lbExamName { get => label1; }
        public Label lbAnswerA { get => label2; }
        public Label lbAnswerB { get => label3; }
        public Label lbAnswerC { get => label4; }
        public Label lbAnswerD { get => label5; }
        public Label lbUserName { get => label6; }
        public Label lbQuestion { get => label7; }

        public Label lbTimer { get => label8; }
        public Button btnFinish { get => button1; }
        public Button btnNext1 { get => btnNext; }
        public Label lbNumberQuestion { get => label9; }
        public CheckBox cbxFinish { get => checkBox5; }



        public System.Windows.Forms.Timer tmTimer { get => timer1; }
    }


}
