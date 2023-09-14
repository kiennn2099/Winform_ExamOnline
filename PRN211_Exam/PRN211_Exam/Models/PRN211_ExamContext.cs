using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRN211_Exam.Models
{
    public partial class PRN211_ExamContext : DbContext
    {
        public PRN211_ExamContext()
        {
        }

        public PRN211_ExamContext(DbContextOptions<PRN211_ExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =.; database = PRN211_Exam;uid=sa;pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(e => e.ExamId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("examId");

                entity.Property(e => e.ExamName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("examName");

                entity.Property(e => e.ExamTime).HasColumnName("examTime");

                entity.Property(e => e.NumberQuestion).HasColumnName("numberQuestion");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TestDay)
                    .HasColumnType("datetime")
                    .HasColumnName("testDay");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QuestionId)
                    .ValueGeneratedNever()
                    .HasColumnName("questionId");

                entity.Property(e => e.AnswerA).HasColumnName("answerA");

                entity.Property(e => e.AnswerB).HasColumnName("answerB");

                entity.Property(e => e.AnswerC).HasColumnName("answerC");

                entity.Property(e => e.AnswerD).HasColumnName("answerD");

                entity.Property(e => e.CorrectAnswer).HasMaxLength(255);

                entity.Property(e => e.ExamId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("examId");

                entity.Property(e => e.Question1)
                    .IsUnicode(false)
                    .HasColumnName("question");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Questions__examI__286302EC");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.ResultId)
                    .ValueGeneratedNever()
                    .HasColumnName("resultId");

                entity.Property(e => e.DateTest)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTest");

                entity.Property(e => e.ExamId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("examId");

                entity.Property(e => e.Mark).HasColumnName("mark");

                entity.Property(e => e.QuestionId).HasColumnName("questionId");

                entity.Property(e => e.SelectedAnswer).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Results__examId__2F10007B");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_ConstraintName");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Results__mark__2E1BDC42");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
