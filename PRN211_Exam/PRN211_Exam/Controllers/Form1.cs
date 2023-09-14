
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using PRN211_Exam.Models;
using PRN211_Exam.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace PRN211_Exam
{
    internal partial class Form1
    {
        private void DangKySuKien()
        {

            btnExit.Click += btnExit_Click;
            btnLogin.Click += btnLogin_Click;

            //form exam
            f2.tmTimer.Tick += TmTimer_Tick;
            //f2.btnFinish.Click += BtnFinish_Click;
            f2.btnNext1.Click += BtnNext1_Click;
            f2.cbxFinish.CheckedChanged += CbxFinish_CheckedChanged;
            f2.FormClosing += F2_FormClosing;
            


            //form manage
            f3.btnViewSV.Click += btnViewSV_Click;
            f3.btnViewListExam.Click += BtnViewListExam_Click;
            f3.btnExit.Click += BtnExit_Click1;

            //form listsv
            f4.btnLoad.Click += btnLoad_Click;
            f4.dgvListSV.CellClick += DgvListSV_CellClick;
            f4.btnClose.Click += BtnClose_Click1;
            f4.cbxRole.SelectedValueChanged += CbxRole_SelectedValueChanged;

            //form listexam
            f6.btnLoad.Click += BtnLoad_Click;
            f6.dgvListExam.CellClick += DgvListExam_CellClick;
            f6.btnClose.Click += BtnClose_Click;
            f6.btnSearch.Click += BtnSearch_Click;

            //form examdetail
            f7.btnInsert.Click += BtnInsert_Click;
            f7.btnUpdate.Click += BtnUpdate_Click;
            f7.btnExit.Click += BtnExit_Click;
            f7.dgvListQuestion.CellClick += DgvListQuestion_CellClick;
            f7.btnSaveToFile.Click += BtnSaveToFile_Click;

            //form question
            f8.btnClose.Click += BtnClose_Click2;
            f8.btnInsert.Click += BtnInsert_Click1;
            f8.btnEdit.Click += BtnEdit_Click;
            f8.btnDelete.Click += BtnDelete_Click;

        }
        //private int CalculateScore()
        //{
        //    PRN211_ExamContext con = new PRN211_ExamContext();
        //    int totalScore = 0;

        //    foreach (var result in con.Results )
        //    {
                
        //        var question = con.Questions.FirstOrDefault(q => q.QuestionId == result.QuestionId);
        //        if (question != null)
        //        {
        //            // So sánh câu trả lời đã chọn với đáp án đúng trong bảng Questions
        //            if (result.SelectedAnswer == question.CorrectAnswer)
        //            {
                        
        //                totalScore += 1;
                       
        //            }
        //        }
        //    }
            

        //    return totalScore;
        //}

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            addInfoToResult(randomQuestions);
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            PRN211_ExamContext con = new PRN211_ExamContext();
            int maxResultId = con.Results.Max(a => a.ResultId);
            var s = con.Results.FirstOrDefault(e => e.ResultId == maxResultId - number);
            if(s != null)
            {
                if (checkBox.Checked && checkBox.Name == "checkBox0")
                {
                    MessageBox.Show("a");
                    var c = con.Results.FirstOrDefault(x => x.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    var q = con.Questions.FirstOrDefault(d => d.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));                  
                    string selected = "A";
                    c.SelectedAnswer = selected;
                    con.Results.Update(c);
                    con.SaveChanges();
                    if (q != null)
                    {
                        if (c.SelectedAnswer == q.CorrectAnswer)
                        {
                            int mark = 1;
                            c.Mark = mark;
                        }
                        else
                        {
                            int mark = 0;
                            c.Mark = mark;
                        }
                        con.Results.Update(c);
                        con.SaveChanges();
                    }
                    
                }
                else if (checkBox.Checked && checkBox.Name == "checkBox1")
                {
                    var c = con.Results.FirstOrDefault(x => x.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    var q = con.Questions.FirstOrDefault(d => d.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    string selected = "B";
                    c.SelectedAnswer = selected;
                    con.Results.Update(c);
                    con.SaveChanges();
                    if (q != null)
                    {
                        if (c.SelectedAnswer == q.CorrectAnswer)
                        {
                            int mark = 1;
                            c.Mark = mark;
                        }
                        else
                        {
                            int mark = 0;
                            c.Mark = mark;
                        }
                        con.Results.Update(c);
                        con.SaveChanges();
                    }
                }
                else if (checkBox.Checked && checkBox.Name == "checkBox2")
                {
                    var c = con.Results.FirstOrDefault(x => x.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    var q = con.Questions.FirstOrDefault(d => d.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    string selected = "C";
                    c.SelectedAnswer = selected;
                    con.Results.Update(c);
                    con.SaveChanges();
                    if (q != null)
                    {
                        if (c.SelectedAnswer == q.CorrectAnswer)
                        {
                            int mark = 1;
                            c.Mark = mark;
                        }
                        else
                        {
                            int mark = 0;
                            c.Mark = mark;
                        }
                        con.Results.Update(c);
                        con.SaveChanges();
                    }
                }
                else if (checkBox.Checked && checkBox.Name == "checkBox3")
                {
                    ;
                    var c = con.Results.FirstOrDefault(x => x.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    var q = con.Questions.FirstOrDefault(d => d.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    string selected = "D";
                    c.SelectedAnswer = selected;
                    con.Results.Update(c);
                    con.SaveChanges();
                    if (q != null)
                    {
                        if (c.SelectedAnswer == q.CorrectAnswer)
                        {
                            int mark = 1;
                            c.Mark = mark;
                        }
                        else
                        {
                            int mark = 0;
                            c.Mark = mark;
                        }
                        con.Results.Update(c);
                        con.SaveChanges();
                    }
                }
                else
                {                   
                    var c = con.Results.FirstOrDefault(x => x.QuestionId == Convert.ToInt32(f2.lbNumberQuestion.Text));
                    string selected = null;
                    int mark = 0;
                    c.Mark = mark;
                    c.SelectedAnswer = selected;
                    con.Results.Update(c);
                    con.SaveChanges();
                }
            }
            

        }       

        private void F2_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DateTime now = DateTime.Now;
            PRN211_ExamContext con = new PRN211_ExamContext();
            //var d = con.Results.Update(x => x.)
        }

        private void BtnSaveToFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (!string.IsNullOrEmpty(filePath))
                {
                    if (f7.dgvListQuestion.Rows.Count > 0)
                    {
                        List<string> questionLines = new List<string>();
                        foreach (DataGridViewRow row in f7.dgvListQuestion.Rows)
                        {

                            if (!row.IsNewRow)
                            {
                                string madethi = row.Cells[0].Value.ToString();
                                string macauhoi = row.Cells[1].Value.ToString();
                                string cauhoi = row.Cells[2].Value.ToString();
                                string cautraloia = row.Cells[3].Value.ToString();
                                string cautraloib = row.Cells[4].Value.ToString();
                                string cautraloic = row.Cells[5].Value.ToString();
                                string cautraloid = row.Cells[6].Value.ToString();
                                string cautraloidung = row.Cells[3].Value.ToString();
                                string questionLine = $"{madethi} | {macauhoi} | {cauhoi} | {cautraloia} | " +
                                    $"{cautraloib} | {cautraloic} | {cautraloid} | {cautraloidung}";
                                questionLines.Add(questionLine);
                            }
                        }
                        File.WriteAllLines(filePath, questionLines.ToArray());

                        MessageBox.Show("Save to file completed.");
                    }
                    else
                    {
                        MessageBox.Show("Notification");
                    }
                }

            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            string id = f8.txtExamId.Text;
            int qid = int.Parse(f8.txtQuestionId.Text);
            PRN211_ExamContext con = new PRN211_ExamContext();
            var q = con.Questions.FirstOrDefault(a => a.QuestionId == qid);
            if (q != null)
            {
                con.Questions.Remove(q);
                con.SaveChanges();
                MessageBox.Show("ban da xoa question");
                LoadQuestion(id);
            }
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            string id = f8.txtExamId.Text;
            PRN211_ExamContext con = new PRN211_ExamContext();
            int qid = int.Parse(f8.txtQuestionId.Text);
            var q = con.Questions.Find(qid);
            if (q != null)
            {
                //int questionId = int.Parse(f8.txtQuestionId.Text);
                string question = f8.rtbQuestion.Text;
                string answer1 = f8.txtAswer1.Text;
                string answerA = f8.rtbAswerA.Text;
                string answerB = f8.rtbAswerB.Text;
                string answerC = f8.rtbAswerC.Text;
                string answerD = f8.rtbAswerD.Text;
                //q.QuestionId = questionId;
                q.ExamId = id;
                q.Question1 = question;
                q.CorrectAnswer = answer1;
                q.AnswerA = answerA;
                q.AnswerB = answerB;
                q.AnswerC = answerC;
                q.AnswerD = answerD;
                con.Questions.Update(q);
                con.SaveChanges();
                LoadQuestion(id);


            }
            else
            {
                MessageBox.Show("id question k ton tai");
            }

        }

        private void BtnInsert_Click1(object? sender, EventArgs e)
        {
            string id = f8.txtExamId.Text;
            PRN211_ExamContext con = new PRN211_ExamContext();
            int qid = int.Parse(f8.txtQuestionId.Text);
            var q = con.Questions.Find(qid);
            if (q == null)
            {
                int questionId = int.Parse(f8.txtQuestionId.Text);
                string question = f8.rtbQuestion.Text;
                string answer1 = f8.txtAswer1.Text;
                string answerA = f8.rtbAswerA.Text;
                string answerB = f8.rtbAswerB.Text;
                string answerC = f8.rtbAswerC.Text;
                string answerD = f8.rtbAswerD.Text;
                int maxQuestionId = con.Questions.Max(a => a.QuestionId);
                int newQuestionId = maxQuestionId + 1;
                Question qe = new Question()
                {
                    QuestionId = newQuestionId,
                    ExamId = id,
                    Question1 = question,
                    CorrectAnswer = answer1,
                    AnswerA = answerA,
                    AnswerB = answerB,
                    AnswerC = answerC,
                    AnswerD = answerD

                };

                con.Questions.Add(qe);
                con.SaveChanges();
                LoadQuestion(id);


            }
            else
            {
                MessageBox.Show("id question da ton tai");
            }
        }

        private void BtnClose_Click2(object? sender, EventArgs e)
        {
            f8.Hide();
        }

        private void DgvListQuestion_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            //string s = f6.dgvListExam[0, n].Value.ToString();
            if (n >= 0)
            {
                PRN211_ExamContext con = new PRN211_ExamContext();
                f8.txtExamId.Text = f7.dgvListQuestion[0, n].Value.ToString();
                f8.txtQuestionId.Text = f7.dgvListQuestion[1, n].Value.ToString();
                f8.rtbQuestion.Text = f7.dgvListQuestion[2, n].Value.ToString();
                f8.rtbAswerA.Text = f7.dgvListQuestion[3, n].Value.ToString();
                f8.rtbAswerB.Text = f7.dgvListQuestion[4, n].Value.ToString();
                f8.rtbAswerC.Text = f7.dgvListQuestion[5, n].Value.ToString();
                f8.rtbAswerD.Text = f7.dgvListQuestion[6, n].Value.ToString();
                f8.txtAswer1.Text = f7.dgvListQuestion[7, n].Value.ToString();
                f8.Show();

            }
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            f7.Close();
        }



        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            string id = f7.txtExamCode.Text;
            PRN211_ExamContext con = new PRN211_ExamContext();
            var x = con.Exams.Find(id);
            if (x != null)
            {
                string examId = f7.txtExamCode.Text;
                string examName = f7.txtExamName.Text;
                Boolean status = f7.chkStatus.Checked;
                DateTime date = f7.mcExamTime.SelectionStart;
                string examTime = f7.txtExamTime.Text;
                string numberQuestion = f7.txtNumberQuestion.Text;
                x.ExamId = examId;
                x.ExamName = examName;
                x.Status = status;
                x.TestDay = date;
                x.ExamTime = int.Parse(examTime);
                x.NumberQuestion = int.Parse(numberQuestion);
                con.Exams.Update(x);
                con.SaveChanges();
                LoadExam();
            }
            else
            {
                MessageBox.Show("khong doi duoc examcode");
            }

        }
        private void BtnInsert_Click(object? sender, EventArgs e)
        {
            string id = f7.txtExamCode.Text;
            PRN211_ExamContext con = new PRN211_ExamContext();
            var x = con.Exams.Find(id);
            if (x == null)
            {
                string examId = f7.txtExamCode.Text;
                string examName = f7.txtExamName.Text;
                Boolean status = f7.chkStatus.Checked;
                DateTime date = f7.mcExamTime.SelectionStart;
                string examTime = f7.txtExamCode.Text;
                string numberQuestion = f7.txtNumberQuestion.Text;
                Models.Exam ex = new Models.Exam()
                {
                    ExamId = examId,
                    ExamName = examName,
                    Status = status,
                    TestDay = date,
                    ExamTime = int.Parse(examTime),
                    NumberQuestion = int.Parse(numberQuestion)


                };
                con.Exams.Add(ex);
                con.SaveChanges();
                LoadExam();
            }
            else
            {
                MessageBox.Show("ExamCode đã tồn tại");
            }
        }

        public void LoadQuestion(string s)
        {
            PRN211_ExamContext con = new PRN211_ExamContext();
            var q = from Question in con.Questions
                    where Question.ExamId == s
                    select new
                    {
                        MaDeThi = Question.ExamId,
                        MaCauHoi = Question.QuestionId,
                        CauHoi = Question.Question1,
                        CauTraLoiA = Question.AnswerA,
                        CauTraLoiB = Question.AnswerB,
                        CauTraLoiC = Question.AnswerC,
                        CauTraLoiD = Question.AnswerD,
                        CauTraLoiDung = Question.CorrectAnswer

                    };


            f7.dgvListQuestion.DataSource = q.ToList();
        }
        // click show detail Exam
        private void DgvListExam_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            string s = f6.dgvListExam[0, n].Value.ToString();
            if (n >= 0)
            {
                PRN211_ExamContext con = new PRN211_ExamContext();
                f7.txtExamCode.Text = f6.dgvListExam[0, n].Value.ToString();
                f7.txtExamName.Text = f6.dgvListExam[1, n].Value.ToString();
                f7.mcExamTime.SetDate((DateTime)f6.dgvListExam[2, n].Value);
                f7.chkStatus.Checked = f6.dgvListExam[3, n].Value.ToString() == "Open";
                f7.txtExamTime.Text = f6.dgvListExam[4, n].Value.ToString();
                f7.txtNumberQuestion.Text = f6.dgvListExam[5, n].Value.ToString();
                LoadQuestion(s);
                f7.Show();

            }
        }
        private void BtnClose_Click(object? sender, EventArgs e)
        {
            f6.Hide();
        }
        private void BtnExit_Click1(object? sender, EventArgs e)
        {
            MessageBox.Show("ban co muon thoat");
            Application.Exit();
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            LoadExam(f6.txtSearch.Text);
        }
        private void BtnViewListExam_Click(object? sender, EventArgs e)
        {
            f6.Show();
        }

        //search by name
        public void LoadExam(string s)
        {
            PRN211_ExamContext con = new PRN211_ExamContext();
            var ex = from x in con.Exams where x.ExamName.Contains(s) select (new { MaDeThi = x.ExamId, TenDeThi = x.ExamName, NgayThi = x.TestDay, TrangThai = x.Status ? "Open" : "Close", ThoiGianThi = x.ExamTime, SoCauHoi = x.NumberQuestion });
            f6.dgvListExam.DataSource = ex.ToList();
        }


        public void LoadExam()
        {
            PRN211_ExamContext con = new PRN211_ExamContext();
            var ex = con.Exams.Select(x => new { MaDeThi = x.ExamId, TenDeThi = x.ExamName, NgayThi = x.TestDay, TrangThai = x.Status ? "Open" : "Close", ThoiGianThi = x.ExamTime, SoCauHoi = x.NumberQuestion });
            f6.dgvListExam.DataSource = ex.ToList();
        }
        // Load list exam
        private void BtnLoad_Click(object? sender, EventArgs e)
        {
            LoadExam();
        }
        //click show sv
        private void DgvListSV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n >= 0)
            {
                PRN211_ExamContext con = new PRN211_ExamContext();
                f5.txtId.Text = f4.dgvListSV[1, n].Value.ToString();
                f5.txtName.Text = f4.dgvListSV[2, n].Value.ToString();
                f5.txtPassword.Text = f4.dgvListSV[3, n].Value.ToString();
                f5.txtRole.Text = f4.dgvListSV[4, n].Value.ToString();
                f5.Show();

            }
        }
        private void BtnClose_Click1(object? sender, EventArgs e)
        {
            f4.Close();
        }

        private void LoadSV()
        {
            PRN211_ExamContext con = new PRN211_ExamContext();
            var sv = con.Users.Select(x => new { Id = x.UserId, MaSV = x.Username, TenSV = x.Fullname, Password1 = x.Password, Role1 = x.Role == "SV" ? "Sinh Vien" : "Khao Thi" });
            f4.cbxRole.DataSource = con.Users.Select(x => x.Role).ToList();
            f4.dgvListSV.DataSource = sv.ToList();
        }

        //filer khi role = s
        private void LoadSV(string s)
        {
            PRN211_ExamContext con = new PRN211_ExamContext();
            var sv = from x in con.Users where x.Role == s select (new { Id = x.UserId, MaSV = x.Username, TenSV = x.Fullname, Password1 = x.Password, Role1 = x.Role == "SV" ? "Sinh Vien" : "Khao Thi" });
            f4.dgvListSV.DataSource = sv.ToList();
        }
        private void btnLoad_Click(object? sender, EventArgs e)
        {
            LoadSV();
        }

        private void btnViewSV_Click(object? sender, EventArgs e)
        {
            f4.Show();
        }
        private void CbxRole_SelectedValueChanged(object? sender, EventArgs e)
        {
            LoadSV(f4.cbxRole.SelectedItem.ToString());
        }

        public string GetRole(string username)
        {
            PRN211_ExamContext con = new PRN211_ExamContext();
            var u = con.Users.FirstOrDefault(u => u.Username == username);
            if (u != null)
            {
                return u.Role;
            }
            return null;
        }



        private int count;
        private void TmTimer_Tick(object? sender, EventArgs e)
        {

            count--;
            int min = count / 60;
            int secon = count % 60;

            f2.lbTimer.Text = string.Format("{0:00}:{1:00}", min, secon);
            if (count == 0)
            {
                f2.tmTimer.Stop();
                MessageBox.Show("da het gio");
                f2.Close();

            }
        }

        
        private void CbxFinish_CheckedChanged(object? sender, EventArgs e)
        {
            Boolean c = f2.cbxFinish.Checked;
            if (c == true)
            {
                f2.btnFinish.Click += BtnFinish_Click;
            }
            else
            {
                f2.btnFinish.Click -= BtnFinish_Click;
            }
        }
        private void BtnFinish_Click(object? sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            string examcode = tbExamCode.Text;
            PRN211_ExamContext con = new PRN211_ExamContext();
            var u = con.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (u != null)
            {

                string role = GetRole(username);
                switch (role)
                {
                    case "SV":
                        var ex = con.Exams.FirstOrDefault(ex => ex.ExamId == examcode && ex.Status == true);
                        if (ex != null)
                        {
                            var t = (from Exams in con.Exams
                                     where Exams.ExamId == ex.ExamId
                                     select Exams.ExamTime).FirstOrDefault();
                            if (t != null)
                            {
                                count = (int)t;
                            }

                            f2.Show();
                            
                            f2.lbExamName.Text = tbExamCode.Text;
                            f2.lbUserName.Text = tbUserName.Text;
                            
                            //dem nguoc thoi gian lam bai test

                            f2.tmTimer.Start();
                            
                            //tao button theo so luong cau hoi
                            var n = (from Exams in con.Exams
                                     where Exams.ExamId == ex.ExamId
                                     select Exams.NumberQuestion).FirstOrDefault();
                            if (n != null)
                            {
                                int number = (int)n;
                                for (int i = 0; i < number; i++)
                                {
                                    if (i < 4)
                                    {
                                        System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                                        checkBox.AutoSize = true;
                                        checkBox.Location = new Point(43, i * 50 + 124);
                                        checkBox.Name = $"checkBox{i}";
                                        checkBox.Size = new Size(41, 24);
                                        checkBox.Text = ((char)('A' + i)).ToString();
                                        checkBox.UseVisualStyleBackColor = true;
                                        checkBox.CheckedChanged += CheckBox_CheckedChanged;
                                        
                                        f2.Controls.Add(checkBox);
                                    }
                                                                       
                                    if (i < 31)
                                    {
                                        Button button = new Button();
                                        button.Text = (i + 1).ToString();
                                        button.Size = new Size(35, 29);
                                        button.Location = new Point(i * 35 + 43, 444);
                                        button.Click += Button_Click;
                                        f2.Controls.Add(button);


                                    }
                                    else
                                    {
                                        Button button = new Button();
                                        button.Text = (i + 1).ToString();
                                        button.Size = new Size(35, 29);
                                        button.Location = new Point((i - 31) * 35 + 43, 479);
                                        button.Click += Button_Click;
                                        f2.Controls.Add(button);
                                    }
                                }


                            }
                            LoadRandomQuestions();
                            if (randomQuestions.Count > 0)
                            {
                                DisplayQuestion(randomQuestions[currentIndex]);
                            }
                            
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("exam code sai");
                        }
                        break;
                    case "KT":
                        f3.Show();
                        this.Hide();
                        break;
                }

            }

            else
            {
                MessageBox.Show("tai khoan sai");
            }
        }

        private List<Question> randomQuestions = new List<Question>();
        private void LoadRandomQuestions()
        {
            if (randomQuestions.Count == 0)
            {
                PRN211_ExamContext con = new PRN211_ExamContext();
                var randomQuestionsQuery = (from Question in con.Questions
                                            where Question.ExamId == tbExamCode.Text
                                            orderby Guid.NewGuid()
                                            select new
                                            {
                                                CauHoi = Question.Question1,
                                                CauTraLoiA = Question.AnswerA,
                                                CauTraLoiB = Question.AnswerB,
                                                CauTraLoiC = Question.AnswerC,
                                                CauTraLoiD = Question.AnswerD,
                                                MaCauHoi = Question.QuestionId
                                            }).ToList();

                randomQuestions = randomQuestionsQuery.Select(q => new Question
                {
                    Question1 = q.CauHoi,
                    AnswerA = q.CauTraLoiA,
                    AnswerB = q.CauTraLoiB,
                    AnswerC = q.CauTraLoiC,
                    AnswerD = q.CauTraLoiD,
                    QuestionId = q.MaCauHoi
                }).ToList();
            }
        }
        private void addInfoToResult(List<Question> answeredQuestions)
        {
            PRN211_ExamContext con = new PRN211_ExamContext();
            var u = con.Users.FirstOrDefault(x => x.Username == f2.lbUserName.Text);
            int userid = u.UserId;
            string examid = f2.lbExamName.Text;
            //int mark = CalculateScore();
            //int questionid = Convert.ToInt32(f2.lbNumberQuestion.Text);
            int resultid = con.Results.Max(x => x.ResultId);
            int maxresultid = resultid + 1;
            foreach (Question question in answeredQuestions)
            {               
                Result r = new Result()
                {
                    ResultId = maxresultid,
                    UserId = userid,
                    ExamId = examid,
                    //Mark = mark,
                    QuestionId = question.QuestionId,                   
                };
                con.Results.Add(r);
                maxresultid++;
            }

            con.SaveChanges();

        }
        private void DisplayQuestion(Question question)
        {
            f2.lbQuestion.Text = question.Question1;
            f2.lbAnswerA.Text = question.AnswerA;
            f2.lbAnswerB.Text = question.AnswerB;
            f2.lbAnswerC.Text = question.AnswerC;
            f2.lbAnswerD.Text = question.AnswerD;
            f2.lbNumberQuestion.Text = question.QuestionId.ToString();
        }
        private int number;
        private int currentIndex = 0;
        private System.Windows.Forms.CheckBox checkBox;
        private void Button_Click(object? sender, EventArgs e)
        {            

            Button clickedButton = (Button)sender;
            int buttonIndex = int.Parse(clickedButton.Text) - 1;
            currentIndex = 0;
            if (buttonIndex >= 0 && buttonIndex < randomQuestions.Count)
            {
                currentIndex = buttonIndex;
                DisplayQuestion(randomQuestions[currentIndex]);
            }
            

        }       

        private void BtnNext1_Click(object? sender, EventArgs e)
        {
            

        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("ban co muon thoat");
            Application.Exit();
        }

    }
}
