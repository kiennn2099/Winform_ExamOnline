using System;
using System.Collections.Generic;

namespace PRN211_Exam.Models
{
    public partial class Exam
    {
        public Exam()
        {
            Questions = new HashSet<Question>();
            Results = new HashSet<Result>();
        }

        public string ExamId { get; set; } = null!;
        public string ExamName { get; set; } = null!;
        public DateTime TestDay { get; set; }
        public bool Status { get; set; }
        public int ExamTime { get; set; }
        public int NumberQuestion { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
