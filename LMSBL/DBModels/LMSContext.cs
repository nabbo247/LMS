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

        public virtual DbSet<TblAssignmentAndTracking> tblAssignmentAndTrackings { get; set; }
        public virtual DbSet<TblCourse> tblCourses { get; set; }
        public virtual DbSet<TblNotificationTemplate> tblNotificationTemplates { get; set; }
        public virtual DbSet<TblStatus> tblStatus { get; set; }
        public virtual DbSet<TblTenant> tblTenants { get; set; }
        public virtual DbSet<TblUser> tblUsers { get; set; }
        public virtual DbSet<TblUserRole> tblUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblStatus>()
                .HasMany(e => e.TblAssignmentAndTrackings)
                .WithRequired(e => e.TblStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
