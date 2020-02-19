using System;
namespace HRS.CoursePlayer
{
   [Serializable] public class ObjectiveTracking
    {
        public string Identifier { get; set; }
        public int? RawScore { get; set; }
        public int? MinScore { get; set; }
        public int? MaxScore { get; set; }
        public string Status { get; set; }
    }
}
