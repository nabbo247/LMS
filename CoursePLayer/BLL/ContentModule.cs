using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRS.CoursePlayer
{
  public  class ContentModuleBLL
  {
      public static List<Course> GetUserContentModule(CurriculumGeneral Curriculum)
      {
          return CourseDAL.GetUserContentModule(Curriculum);
      }

      public static Course GetUserContentModuleTracking(Course objCourse)
      {
          return CourseDAL.GetUserContentModuleTracking(objCourse);
      }

      public static List<Course> GetOtherCurriculumModule(Learner learner)
      {
          return CourseDAL.GetOtherCurriculumModule(learner);
      }

     

    }
}
