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
        public virtual DbSet<TblCourse> TblCourses { get; set; }
        public virtual DbSet<TblNotificationTemplate> TblNotificationTemplates { get; set; }
        public virtual DbSet<TblStatus> TblStatus { get; set; }
        public virtual DbSet<TblTenant> tblTenants { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserRole> TblUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblStatus>()
                .HasMany(e => e.TblAssignmentAndTrackings)
                .WithRequired(e => e.TblStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
