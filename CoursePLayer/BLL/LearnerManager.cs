
using System.Collections.Generic;


using System.Data;


namespace HRS.CoursePlayer
{
    /// <summary>
    /// class LearnerManager
    /// </summary>
    public class LearnerManager : IManager<Learner,Learner.Method,Learner.ListMethod>  
    {

        private const string PREFERRED_DATE_FORMAT = "PreferredDateFormat";
        private const string PREFERRED_TIME_FORMAT = "PreferredTimeFormat";
        /// <summary>
        /// Default constructor
        /// </summary>
        public LearnerManager()
        {
        }

        /// <summary>
        /// Used for add,update,Delete,Get,Checklogin transactions.
        /// </summary>
        /// <param name="pEntLearner"></param>
        /// <param name="pMethod"></param>
        /// <returns>Learner object information</returns>
        public Learner Execute(Learner pEntLearner, Learner.Method pMethod)
        {
            Learner entLearner = null;
            LearnerDAM adaptorLearner = new LearnerDAM();

            switch (pMethod)
            {
                
                case Learner.Method.Get:
                    entLearner = adaptorLearner.GetUserByID(pEntLearner);
                    break;
                case Learner.Method.GetUser_CoursePlayer:
                    entLearner = adaptorLearner.GetUserByID_CoursePlayer(pEntLearner);
                    break;
                
                default:
                    entLearner = null;
                    break;
            }
            return entLearner;
        }

        /// <summary>
        /// Returns list of users  
        /// </summary>
        /// <param name="pEntLearner"></param>
        /// <param name="pMethod"></param>
        /// <returns>List of Learner objects</returns>
        public List<Learner> Execute(Learner pEntLearner, Learner.ListMethod pMethod)
        {
            List<Learner> entListLearner = null;
            //LearnerDAM adaptorLearner = new LearnerDAM();
            switch (pMethod)
            {
                //case Learner.ListMethod.DynamicUserList:
                //    entListLearner = adaptorLearner.GetDynamicUserList(pEntLearner);
                //    break;
                //case Learner.ListMethod.OneTimeUserList:
                //    entListLearner = adaptorLearner.GetOneTimeUserList(pEntLearner);
                //    break;
                //case Learner.ListMethod.GetBulkImport:
                //    entListLearner = adaptorLearner.GetBulkImport(pEntLearner);
                //    break;
                //case Learner.ListMethod.GetAllForAssessmentCourse:
                //    entListLearner = adaptorLearner.GetLearnersForAssessmentCourse(pEntLearner);
                //    break;
                default:
                    entListLearner = null;
                    break;
            }
            return entListLearner;
        }

        /// <summary>
        /// For Bulk Add/Update
        /// </summary>
        /// <param name="pEntListBase">List Of users</param>
        /// <param name="pMethod">ListMethod</param>
        /// <returns>Updated List of Learner objects</returns>
        public List<Learner> Execute(List<Learner> pEntListBase, Learner.ListMethod pMethod)
        {
            List<Learner> entListLearner = null;
            //LearnerDAM adaptorLearner = new LearnerDAM();
            if (pEntListBase.Count > 0)
            {
                switch (pMethod)
                {
                    //case Learner.ListMethod.DeleteAll:
                        
                    //        entListLearner = adaptorLearner.DeleteSelectedUser(pEntListBase);
                        
                    //    break;
                    //case Learner.ListMethod.BulkActivateDeactivate:
                    //    entListLearner = adaptorLearner.BulkActivateDeactivate(pEntListBase);
                    //    break;
                    //case Learner.ListMethod.BulkChangeId:
                    //    entListLearner = adaptorLearner.BulkChangeId(pEntListBase);
                    //    break;
                    default:
                        break;
                }
            }
            return entListLearner;
        }

       
        /// <summary>
        /// Returns Dataset as per method
        /// </summary>
        /// <typeparam name="Learner"></typeparam>
        /// <param name="pEntBase">Learner object</param>
        /// <param name="pMethod">Learner.ListMethod</param>
        /// <returns>DataSet</returns>
        public DataSet ExecuteDataSet(Learner pEntBase, Learner.ListMethod pMethod)
        {
            DataSet dataSet = null;
            List<Learner> listLearner = Execute(pEntBase,pMethod);
            Converter dsConverter = new Converter();
            dataSet = dsConverter.ConvertToDataSet<Learner>(listLearner);
            return dataSet;

        }
    }
}
