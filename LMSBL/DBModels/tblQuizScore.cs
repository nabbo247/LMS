namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblQuizScore")]
    public partial class TblQuizScore
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuizId { get; set; }

        [Column(Order = 1)]
        [StringLength(100)]
        public string UserId { get; set; }

        [Column(Order = 2, TypeName = "numeric")]
        public decimal Score { get; set; }

        [Column(Order = 3)]
        public DateTime AttemptedDate { get; set; }

        public string completedTime { get; set; }
    }
}
