namespace LMSBL.DBModels
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel;

    [Table("tblCourse")]
    public partial class tblCourse
    {
        public int ContentModuleId { get; set; }

        [DisplayName("Course Name")]
        [StringLength(100)]
        public string ContentModuleName { get; set; }

        [DisplayName("Course Description")]
        [StringLength(1000)]
        public string ContentModuleDescription { get; set; }

        [StringLength(400)]
        public string ContentModuleURL { get; set; }

        [DisplayName("Course Type")]
        [StringLength(100)]
        public string ContentModuleType { get; set; }
        
        public bool IsActive { get; set; }

        [DisplayName("Course Mastery Score")]
        public int? MasteryScore { get; set; }
        public int? Duration { get; set; }
        
        public int createdBy { get; set; }

        public DateTime createdOn { get; set; }

        public int tenantId { get; set; }

        public HttpPostedFileBase ZipFile { get; set; }


    }
}
