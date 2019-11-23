namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuestion")]
    public partial class tblQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblQuestion()
        {
            tblQuestionOptions = new HashSet<tblQuestionOption>();
            tblResponses = new HashSet<tblRespons>();
        }

        [Key]
        public int QuestionId { get; set; }

        public int QuizId { get; set; }

        public int QuestionTypeId { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string QuestionText { get; set; }

        public virtual tblQuiz tblQuiz { get; set; }

        public virtual tblQuestionType tblQuestionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuestionOption> tblQuestionOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRespons> tblResponses { get; set; }
    }
}
