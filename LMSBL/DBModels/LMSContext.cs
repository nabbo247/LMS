namespace LMSBL.DBModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LMSContext : DbContext
    {
        public LMSContext()
            : base("name=LMSContext")
        {
        }

        public virtual DbSet<TblAssignmentAndTracking> TblAssignmentAndTrackings { get; set; }
        public virtual DbSet<tblCourse> TblCourses { get; set; }
        public virtual DbSet<TblNotificationTemplate> TblNotificationTemplates { get; set; }
        public virtual DbSet<TblStatus> TblStatus { get; set; }
        public virtual DbSet<TblTenant> tblTenants { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserRole> TblUserRoles { get; set; }
        public virtual DbSet<TblQuestion> tblQuestions { get; set; }
        public virtual DbSet<TblQuestionOption> tblQuestionOptions { get; set; }
        public virtual DbSet<TblQuestionType> tblQuestionTypes { get; set; }
        public virtual DbSet<TblQuiz> tblQuizs { get; set; }
        public virtual DbSet<TblRespons> tblResponses { get; set; }
        public virtual DbSet<TblQuizScore> tblQuizScores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblStatus>()
                .HasMany(e => e.TblAssignmentAndTrackings)
                .WithRequired(e => e.TblStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
