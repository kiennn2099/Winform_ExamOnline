using System;
using System.Collections.Generic;

namespace PRN211_Exam.Models
{
    public partial class User
    {
        public User()
        {
            Results = new HashSet<Result>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Fullname { get; set; } = null!;

        public virtual ICollection<Result> Results { get; set; }
    }
}
