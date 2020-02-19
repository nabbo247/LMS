
using System.Collections.Generic;


using System.Data;

namespace HRS.CoursePlayer
{
    /// <summary>
    /// class ContentModuleManager
    /// </summary>
    public class ContentModuleManager : IManager<ContentModule,ContentModule.Method,ContentModule.ListMethod>  
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ContentModuleManager()
        { 

        }

        /// <summary>
        /// Use for Bulk add action.    
        /// </summary>
        /// <param name="pEntListContModule"></param>
        /// <param name="pMethod"></param>
        /// <returns>List of ContentModule objects</returns>
        public List<ContentModule> Execute(List<ContentModule> pEntListContModule, ContentModule.ListMethod pMethod)
        {
            List<ContentModule> entListContModuleReturn = new List<ContentModule>();
            ContentModuleAdaptor adaptorContModule = new ContentModuleAdaptor();
            switch (pMethod)
            {
                //case ContentModule.ListMethod.AddAll:
                //    entListContModuleReturn = adaptorContModule.AddAllModules(pEntListContModule); 
                //    break;
                //case ContentModule.ListMethod.UpdateAll:
                //    entListContModuleReturn = adaptorContModule.AddAllModules(pEntListContModule);
                //    break;
                case ContentModule.ListMethod.BulkDelete:
                    entListContModuleReturn = adaptorContModule.BulkDelete(pEntListContModule);
                    break;
                default:
                    entListContModuleReturn = null;
                    break;
            }
            return entListContModuleReturn;
        }

        /// <summary>
        /// Use for FindByname,Read,Add,Update,Delete transactions
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <param name="pMethod"></param>
        /// <returns>ContentModule object</returns>
        public ContentModule Execute(ContentModule pEntContModule, ContentModule.Method pMethod)
        {
            ContentModule entContModuleReturn = null;
            ContentModuleAdaptor adaptorContModule = new ContentModuleAdaptor();

            switch (pMethod)
            {
                case ContentModule.Method.FindByName:
                    entContModuleReturn = adaptorContModule.FindContentModuleByName(pEntContModule);
                    break;
                case ContentModule.Method.GetByIDLearner:
                    entContModuleReturn = adaptorContModule.GetContentModuleByID_Learner(pEntContModule);
                    break;
                case ContentModule.Method.GetByIDCoursePlayer:
                    entContModuleReturn = adaptorContModule.GetContentModuleByID_CoursePlayer(pEntContModule);
                    break;
                case ContentModule.Method.GetContentModuleURL:
                    entContModuleReturn = adaptorContModule.GetContentModuleURL(pEntContModule);
                    break;
                case ContentModule.Method.Get:
                    entContModuleReturn = adaptorContModule.GetContentModuleByID(pEntContModule);
                    break;
                case ContentModule.Method.Add:
                    entContModuleReturn = adaptorContModule.AddContentModule(pEntContModule);
                    break;
                case ContentModule.Method.Update:
                    entContModuleReturn = adaptorContModule.EditContentModule(pEntContModule);
                    break;
                default:
                    entContModuleReturn = null;
                    break;
            }
            return entContModuleReturn;
        }

        /// <summary>
        /// Used for finding ContentModule List ByName+Type and Get all ContentModuleList
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <param name="pMethod"></param>
        /// <returns>List of ContentModule objects</returns>
        public List<ContentModule> Execute(ContentModule pEntContModule, ContentModule.ListMethod pMethod)
        {
            List<ContentModule> entListContModule = new List<ContentModule>(); 
            ContentModuleAdaptor adaptorContModule = new ContentModuleAdaptor();
            switch (pMethod)
            {
                case ContentModule.ListMethod.GetContentModuleList:
                    entListContModule = adaptorContModule.GetContentModuleList(pEntContModule);
                    break;
                case ContentModule.ListMethod.GetContentModuleListAdminHome:
                    entListContModule = adaptorContModule.GetContentModuleListAdminHome(pEntContModule);
                    break;
                case ContentModule.ListMethod.GetAllAssessmentContentModules:
                    entListContModule = adaptorContModule.GetAssessmentContentModuleList(pEntContModule);
                    break;
                case ContentModule.ListMethod.GetAllUserAssessContentModules:
                    entListContModule = adaptorContModule.GetUserAssessmentContentModuleList(pEntContModule);
                    break;
                case ContentModule.ListMethod.GetContentModuleListNotCompleted:
                    entListContModule = adaptorContModule.GetContentModuleListNotCompletedList(pEntContModule);
                    break;
                    
                default:
                    break;
            }
            return entListContModule;
        }

        
        /// <summary>
        /// Returns Dataset as per method
        /// </summary>
        /// <typeparam name="ContentModule"></typeparam>
        /// <param name="pEntBase">ContentModule object</param>
        /// <param name="pMethod">ContentModule.ListMethod</param>
        /// <returns>DataSet</returns>
        public DataSet ExecuteDataSet(ContentModule pEntBase, ContentModule.ListMethod pMethod)
        {
            DataSet dataSet = null;
            List<ContentModule> listContentModule = Execute(pEntBase,pMethod);
            Converter dsConverter = new Converter();
            dataSet = dsConverter.ConvertToDataSet<ContentModule>(listContentModule);
            return dataSet;

        }          
    }
}
