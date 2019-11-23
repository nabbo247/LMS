namespace LMSBL.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuestionOption")]
    public partial class tblQuestionOption
    {
        [Key]
        public int OptionId { get; set; }

        public int QuestionId { get; set; }

        [Required]
        public string OptionText { get; set; }

        public bool? CorrectOption { get; set; }

        public virtual tblQuestion tblQuestion { get; set; }
    }
}
