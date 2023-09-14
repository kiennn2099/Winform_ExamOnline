using PRN211_Exam.Views;
using System.Security.Cryptography;
using System.Text;

namespace PRN211_Exam
{
    internal partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f2 = new Exam();
            f3 = new Manage();
            f4 = new ListSV();
            f5 = new SV();
            f6 = new ListExam();
            f7 = new ExamDetail();
            f8 = new Questions();
            DangKySuKien();
        }
        Exam f2;
        Manage f3;
        ListSV f4;
        SV f5;
        ListExam f6;
        ExamDetail f7;
        Questions f8;
    }
}