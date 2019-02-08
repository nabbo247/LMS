namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAssignmentAndTracking")]
    public partial class TblAssignmentAndTracking
    {
        [Key]
        public int TrackingId { get; set; }

        public int CourseId { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AssignedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ValidFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ValidTo { get; set; }

        public int StatusId { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedOn { get; set; }

        public bool? IsActive { get; set; }

        public virtual TblStatus TblStatus { get; set; }
    }
}
