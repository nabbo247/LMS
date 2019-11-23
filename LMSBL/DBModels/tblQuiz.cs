namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuiz")]
    public partial class tblQuiz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblQuiz()
        {
            tblQuestions = new HashSet<tblQuestion>();
            tblResponses = new HashSet<tblRespons>();
        }

        [Key]
        public int QuizId { get; set; }

        [Required]
        [StringLength(500)]
        public string QuizName { get; set; }

        [Column(TypeName = "ntext")]
        public string QuizDescription { get; set; }

        public int TenantId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuestion> tblQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRespons> tblResponses { get; set; }
    }
}
