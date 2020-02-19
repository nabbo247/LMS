using System;
using System.Collections.Generic;

namespace HRS.CoursePlayer
{
   [Serializable] public class AuTracking : LessonTracking
    {
        public AuTracking()
        {
            TotalTime = new TimeSpan(0);
            Objectives = new List<ObjectiveTracking>();
        }
    }
}
