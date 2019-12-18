namespace LMSBL.DBModels
{
    using System.Web.Mvc;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblQuiz")]
    public partial class TblQuiz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblQuiz()
        {
            TblQuestions = new HashSet<TblQuestion>();
            TblResponses = new HashSet<TblRespons>();
        }

        public int QuizId { get; set; }

        [DisplayName("Quiz Name")]
        [StringLength(500)]
        public string QuizName { get; set; }

        [DisplayName("Quiz Description")]
        [Column(TypeName = "ntext")]
        public string QuizDescription { get; set; }

        
        [AllowHtml]
        [NotMapped]
        public string hdnData { get; set; }

        [AllowHtml]
        [NotMapped]
        public string hdnResponseData { get; set; }

        [AllowHtml]
        [NotMapped]
        public string hdnEditData { get; set; }

        [NotMapped]
        public object[] questionObject { get; set; }

        public int TenantId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblQuestion> TblQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblRespons> TblResponses { get; set; }
    }

    public partial class QueOptions
    {
        public int QuestionId { get; set; }

        public string OptionsIds { get; set; }
    }
}
