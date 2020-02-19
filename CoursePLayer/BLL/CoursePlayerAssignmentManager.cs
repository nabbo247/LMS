using System;



namespace HRS.CoursePlayer
{
    public interface ICoursePlayerAssignmentManager
    {
        ActivityAssignment GetAssignmentForLaunch(string clientId, string courseId, string learnerId,
                                                  LaunchSite courseLaunchSite);
        //ActivityAssignmentExt IsAlreadyCourseLaunchedMgr(string clientId, string tokenKey);
    }
    public class CoursePlayerAssignmentManager : ICoursePlayerAssignmentManager
    {
        private readonly ICourseAssignmentRepository _courseAssignmentRepository;
        private readonly IContentModuleRetriever _contentModuleRetriever;

        public CoursePlayerAssignmentManager(ICourseAssignmentRepository courseAssignmentRepository, IContentModuleRetriever contentModuleRetriever)
        {
            _courseAssignmentRepository = courseAssignmentRepository;
            _contentModuleRetriever = contentModuleRetriever;
        }
        public CoursePlayerAssignmentManager()
        {
           
        }
        public ActivityAssignment GetAssignmentForLaunch(string clientId, string courseId, string learnerId, LaunchSite courseLaunchSite)
        {
            var assignment = _courseAssignmentRepository.GetForCoursePlayer(clientId, courseId, learnerId);
            if (String.IsNullOrEmpty(assignment.ID) && courseLaunchSite == LaunchSite.Admin)
            {
                assignment = AddAdminAssignment(clientId, courseId, learnerId);
            }
            return assignment;
        }


        public ActivityAssignment GetAssignmentForLaunchNew(string courseId, string learnerId)
        {
            var assignment = _courseAssignmentRepository.GetForCoursePlayerNew(courseId, learnerId);
            
            return assignment;
        }
        //public ActivityAssignmentExt IsAlreadyCourseLaunchedMgr(string clientId,  string tokenKey)
        //{
        //    ActivityAssignmentExt oActivityAssignmentExt = new ActivityAssignmentExt();
        //    oActivityAssignmentExt = _courseAssignmentRepository.IsAlreadyCourseLaunched(clientId, tokenKey);

        //    return oActivityAssignmentExt;
        //}

        private ActivityAssignment AddAdminAssignment(string clientId, string courseId, string learnerId)
        {
            var entContentModule = _contentModuleRetriever.GetMetaData(clientId, courseId);
            var assignment = new ActivityAssignment
            {
                ID = courseId,
                UserID = learnerId,
                ClientId = clientId,
                CreatedById = learnerId,
                DateCreated = DateTime.UtcNow,
                ActivityTypeId = entContentModule.ContentModuleTypeId,
                ActivityName = entContentModule.ContentModuleEnglishName,
                IsAdminAssignment = true,
                IsForAdminPreview = true,
                CompletionConditionId = ActivityCompletionCondition.Mandatory,
                LastModifiedById = learnerId
            };
            assignment.ActivityType = (ActivityContentType)Enum.Parse(typeof(ActivityContentType), assignment.ActivityTypeId);

            assignment = _courseAssignmentRepository.AddActivityAssignment(assignment);
            assignment.ClientId = clientId;
            assignment.ActivityName = entContentModule.ContentModuleEnglishName;

            return assignment;
        }
    }
}
