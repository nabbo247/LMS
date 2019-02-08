namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TblNotificationTemplate
    {
        [Key]
        public int TemplateId { get; set; }

        [Required]
        [StringLength(50)]
        public string TemplateName { get; set; }

        [Required]
        [StringLength(500)]
        public string TemplateSubject { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string TemplateDescription { get; set; }

        public bool? IsActive { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedOn { get; set; }

        public int? TenantId { get; set; }
    }
}
