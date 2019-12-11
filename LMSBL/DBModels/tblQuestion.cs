namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblQuestion")]
    public partial class TblQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblQuestion()
        {
            TblQuestionOptions = new HashSet<TblQuestionOption>();
            TblResponses = new HashSet<TblRespons>();
        }
        public int QuestionId { get; set; }

        public int QuizId { get; set; }

        public int QuestionTypeId { get; set; }

        [Column(TypeName = "ntext")]
        public string QuestionText { get; set; }

        [NotMapped]
        [Column(TypeName = "ntext")]
        public string QuestionFeedback { get; set; }

        public virtual TblQuiz TblQuiz { get; set; }

        public virtual TblQuestionType TblQuestionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblQuestionOption> TblQuestionOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblRespons> TblResponses { get; set; }
    }
}
