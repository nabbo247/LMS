namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUser")]
    public partial class tblUser
    {
        [Key]
        public int userId { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        [Required]
        [StringLength(50)]
        public string emailId { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string contactNo { get; set; }

        public bool? isActive { get; set; }

        public int createdBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdOn { get; set; }

        public int tenantId { get; set; }

        public int? roleId { get; set; }

        public virtual tblUserRole tblUserRole { get; set; }
    }
}
