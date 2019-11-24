namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblQuestionType")]
    public partial class TblQuestionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblQuestionType()
        {
            TblQuestions = new HashSet<TblQuestion>();
        }

        public int QuestionTypeID { get; set; }

        [StringLength(250)]
        public string QuestionTypeText { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblQuestion> TblQuestions { get; set; }
    }
}
