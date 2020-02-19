using System;

namespace HRS.CoursePlayer
{
    public abstract class Lesson : IComparable<Lesson>
    {
        public string Identifier { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }
        public int? MasteryScore { get; set; }
        public TimeSpan? MaxTimeAllowed { get; set; }
        public string TimeLimitAction { get; set; }

        public int CompareTo(Lesson other)
        {
            return SortOrder.CompareTo(other.SortOrder);
        }
    }
}
