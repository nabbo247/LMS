namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCourses")]
    public partial class tblCourse
    {
        [Key]
        public int courseId { get; set; }

        [Required]
        [StringLength(50)]
        public string courseName { get; set; }

        [StringLength(250)]
        public string courseDetails { get; set; }

        [StringLength(50)]
        public string courseCategory { get; set; }

        [StringLength(250)]
        public string coursePath { get; set; }

        public bool? isActive { get; set; }

        public int? createdBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdOn { get; set; }

        public int tenantId { get; set; }
    }
}
