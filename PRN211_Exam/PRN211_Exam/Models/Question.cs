using System;
using System.Collections.Generic;

namespace PRN211_Exam.Models
{
    public partial class Question
    {
        public Question()
        {
            Results = new HashSet<Result>();
        }

        public int QuestionId { get; set; }
        public string ExamId { get; set; } = null!;
        public string Question1 { get; set; } = null!;
        public string AnswerA { get; set; } = null!;
        public string AnswerB { get; set; } = null!;
        public string AnswerC { get; set; } = null!;
        public string AnswerD { get; set; } = null!;
        public string CorrectAnswer { get; set; } = null!;

        public virtual Exam Exam { get; set; } = null!;
        public virtual ICollection<Result> Results { get; set; }
    }
}
