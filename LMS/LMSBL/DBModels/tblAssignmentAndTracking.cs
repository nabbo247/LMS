namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAssignmentAndTracking")]
    public partial class tblAssignmentAndTracking
    {
        [Key]
        public int trackingId { get; set; }

        public int courseId { get; set; }

        public int userId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? assignedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validTo { get; set; }

        public int statusId { get; set; }

        public int? createdBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdOn { get; set; }

        public bool? isActive { get; set; }

        public virtual tblStatus tblStatu { get; set; }
    }
}
