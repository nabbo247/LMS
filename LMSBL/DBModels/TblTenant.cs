namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Tenant Name")]
        public string TenantName { get; set; }

       
        [Required]
        [StringLength(50)]
        [DisplayName("Tenant Domain")]
        public string TenantDomain { get; set; }


        [Required]
        public string DomainUrl { get; set; }


        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Activation From")]
        public DateTime? ActivationFrom { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Activation To")]
        public DateTime? ActivationTo { get; set; }

        public bool? IsActive { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("No Of User Allowed")]
        public int? NoOfUserAllowed { get; set; }
    }
}
