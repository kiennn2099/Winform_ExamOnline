using System;
using System.Collections.Generic;

namespace PRN211_Exam.Models
{
    public partial class Result
    {
        public int ResultId { get; set; }
        public int UserId { get; set; }
        public string ExamId { get; set; } = null!;
        public int Mark { get; set; }
        public string? SelectedAnswer { get; set; }
        public int? QuestionId { get; set; }
        public DateTime? DateTest { get; set; }

        public virtual Exam Exam { get; set; } = null!;
        public virtual Question? Question { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
