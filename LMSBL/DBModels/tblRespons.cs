namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblResponses")]
    public partial class TblRespons
    {
        public int ResponseId { get; set; }

        public int QuestionId { get; set; }

        [StringLength(100)]
        public string OptionIds { get; set; }

        [Column(TypeName = "ntext")]
        public string QuestionFeedback { get; set; }

        
        public int UserId { get; set; }

        public int QuizId { get; set; }

        public DateTime DateCreated { get; set; }

        public int Attempt { get; set; }

        public virtual TblQuestion TblQuestion { get; set; }

        public virtual TblQuiz TblQuiz { get; set; }
    }
}
