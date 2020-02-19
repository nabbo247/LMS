using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRS.CoursePlayer
{
    public class CurriculumGeneralBLL
    {
        public static List<CurriculumGeneral> GetUserCurriculum(Learner objLearner)
        {
            return CurriculumGeneralDAL.GetUserCurriculum(objLearner);
        }
    }
}
