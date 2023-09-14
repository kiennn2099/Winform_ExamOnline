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
    public partial class SV : Form
    {
        public SV()
        {
            InitializeComponent();
        }
        public TextBox txtId { get => textBox1; }
        public TextBox txtName { get => textBox2; }

        public TextBox txtPassword { get => textBox3; }
        public TextBox txtRole { get => textBox4;}
    }
}
