namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblUser")]
    public partial class TblUser
    {
        public int UserId { get; set; }

        [DisplayName("First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [DisplayName("Email Id")]
        [StringLength(50)]
        public string EmailId { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [DisplayName("Date Of Birth")]
        [Column(TypeName = "date")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DOB { get; set; }

        [DisplayName("Contact No")]
        [StringLength(50)]
        public string ContactNo { get; set; }

        public bool? IsActive { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedOn { get; set; }


        public int TenantId { get; set; }

        public int? RoleId { get; set; }

        public string  TenantName { get; set; }

        [DisplayName("Role")]
        public string RoleName { get; set; }

        public List<TblUserRole> UserRoles { get; set; }

        public List<TblTenant> Tenants { get; set; }
    }
}
