namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblResetPassword")]
    public partial class TblResetPassword
    {  

        [DisplayName("Email Id")]
        [StringLength(50)]
        public string EmailId { get; set; }

        public string token { get; set; }


    }
}
