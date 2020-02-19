using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRS.CoursePlayer
{
   public class Course : BaseEntity
   {
       public string ActivityId { get; set; }
       public string LearnerId { get; set; }
       public string CurriculumId { get; set; }
       public string ContentModuleName { get; set; }
       public string ContentModuleDescription { get; set; }
       public string ContentTrackId { get; set; }
       public string CompletionStatus { get; set; }
       public string DateOfCompletion { get; set; }
       public string DateOfStart { get; set; }
       public string NoOfPagesCompleted { get; set; }
       public string percentCompleted { get; set; }
       public string TotalNoOfPages { get; set; }
       public string Score { get; set; }
       public string PassFailStatus { get; set; }
       public string IsHTML5 { get; set; }
       public string DisplayOrder { get; set; }
    }
}
