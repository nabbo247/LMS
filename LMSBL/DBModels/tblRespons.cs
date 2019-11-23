namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblResponses")]
    public partial class tblRespons
    {
        [Key]
        public int ResponseId { get; set; }

        public int QuestionId { get; set; }

        [Required]
        [StringLength(100)]
        public string OptionIds { get; set; }

        [Column(TypeName = "ntext")]
        public string QuestionFeedback { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UserId { get; set; }

        public int QuizId { get; set; }

        public virtual tblQuestion tblQuestion { get; set; }

        public virtual tblQuiz tblQuiz { get; set; }
    }
}
