using System;
using System.Collections.Generic;

namespace HRS.CoursePlayer
{
   [Serializable] public class CourseSection : IComparable<CourseSection>
    {
        public string Identifier { get; set; }
        public string Title { get; set; }
        public Dictionary<string, Lesson> Lessons { get; set; }
        public int SortOrder { get; set; }

        public int CompareTo(CourseSection other)
        {
            return SortOrder.CompareTo(other.SortOrder);
        }
    }
}
