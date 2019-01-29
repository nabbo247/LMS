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

        public virtual DbSet<tblAssignmentAndTracking> tblAssignmentAndTrackings { get; set; }
        public virtual DbSet<tblCourse> tblCourses { get; set; }
        public virtual DbSet<tblNotificationTemplate> tblNotificationTemplates { get; set; }
        public virtual DbSet<tblStatus> tblStatus { get; set; }
        public virtual DbSet<tblTenant> tblTenants { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblStatus>()
                .HasMany(e => e.tblAssignmentAndTrackings)
                .WithRequired(e => e.tblStatu)
                .WillCascadeOnDelete(false);
        }
    }
}
