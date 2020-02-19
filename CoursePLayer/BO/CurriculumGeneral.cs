using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRS.CoursePlayer
{
    public class CurriculumGeneral
    {

        public string CurriculumId { get; set; }
        public string CurriculumName { get; set; }
        public string CurriculumDescription { get; set; }
        public string CreateDate { get; set; }
        public string LastmodifiedDate { get; set; }
        public string CurriculumTrackId { get; set; }
        public string CompletionStatus { get; set; }
        public string DateOfStart { get; set; }
        public string DateOfCompletion { get; set; }
        public string LearnerId { get; set; }
        public string EnableSequencing { get; set; }
    }
}
