using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRS.CoursePlayer
{
    public class TrackingBLL
    {
        public static void ManageTracking(Tracking track)
        {
            TrackingDAL.ManageTracking(track);
        }
    }
}
