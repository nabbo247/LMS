namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblNotificationTemplate
    {
        [Key]
        public int templateId { get; set; }

        [Required]
        [StringLength(50)]
        public string templateName { get; set; }

        [Required]
        [StringLength(500)]
        public string templateSubject { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string templateDescription { get; set; }

        public bool? isActive { get; set; }

        public int? createdBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdOn { get; set; }

        public int? tenantId { get; set; }
    }
}
