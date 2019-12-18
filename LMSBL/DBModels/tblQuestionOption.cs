namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblQuestionOption")]
    public partial class TblQuestionOption
    {
        public int OptionId { get; set; }

        public int QuestionId { get; set; }

        public string OptionText { get; set; }

        public bool? CorrectOption { get; set; }

        public string OptionFeedback { get; set; }

        [NotMapped]
        public bool SelectedAnswer { get; set; }

        public virtual TblQuestion TblQuestion { get; set; }
    }
}
