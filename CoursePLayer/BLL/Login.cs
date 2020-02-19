using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HRS.CoursePlayer
{
    public class LoginBLL
    {
        public static Learner ValidateLearnerLogin(Learner objLearner)
        {
            return LearnerLoginDAL.ValidateLeanerLogin(objLearner);
        }
    }
}
