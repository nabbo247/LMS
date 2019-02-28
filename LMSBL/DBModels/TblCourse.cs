namespace LMSBL.DBModels
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tblCourses")]
    public partial class TblCourse
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(50)]
        public string CourseName { get; set; }

        [StringLength(250)]
        public string CourseDetails { get; set; }

        [StringLength(50)]
        public string CourseCategory { get; set; }

        [StringLength(250)]
        public string CoursePath { get; set; }

        public bool? IsActive { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedOn { get; set; }

        public int TenantId { get; set; }

        public string TenantName { get; set; }

       
        public HttpPostedFileBase ZipFile { get; set; }

        public List<TblTenant> Tenants { get; set; }
    }
}
