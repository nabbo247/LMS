namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblTenant")]
    public partial class TblTenant
    {
        [Key]
        public int TenantId { get; set; }

        [Required]
        [StringLength(50)]
        public string TenantName { get; set; }

        [Required]
        [StringLength(50)]
        public string TenantDomain { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ActivationFrom { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ActivationTo { get; set; }

        public bool? IsActive { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedOn { get; set; }

        public int? NoOfUserAllowed { get; set; }
    }
}
