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
        public int TenantId { get; set; }

        [StringLength(50)]
        [DisplayName("Client Name")]
        public string TenantName { get; set; }

       
        [StringLength(50)]
        [DisplayName("Client Domain")]
        public string TenantDomain { get; set; }

        [DisplayName("Upload Logo")]
        public string Logo { get; set; }



        public string DomainUrl { get; set; }


        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Activation From")]
        public DateTime? ActivationFrom { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
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
