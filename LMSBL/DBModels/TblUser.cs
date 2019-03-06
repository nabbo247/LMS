namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblUser")]
    public partial class TblUser
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string ContactNo { get; set; }

        public bool? IsActive { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedOn { get; set; }


        public int TenantId { get; set; }

        public int? RoleId { get; set; }

        public string  TenantName { get; set; }

        public string RoleName { get; set; }

        public List<TblUserRole> UserRoles { get; set; }

        public List<TblTenant> Tenants { get; set; }
    }
}
