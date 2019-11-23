namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuizScore")]
    public partial class tblQuizScore
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuizId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal Score { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime AttemptedDate { get; set; }
    }
}
