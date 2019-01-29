namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTenant")]
    public partial class tblTenant
    {
        [Key]
        public int tenantId { get; set; }

        [Required]
        [StringLength(50)]
        public string tenantName { get; set; }

        [Required]
        [StringLength(50)]
        public string tenantDomain { get; set; }

        [Column(TypeName = "date")]
        public DateTime? activationFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? activationTo { get; set; }

        public bool? isActive { get; set; }

        public int createdBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime createdOn { get; set; }

        public int? noOfUserAllowed { get; set; }
    }
}
