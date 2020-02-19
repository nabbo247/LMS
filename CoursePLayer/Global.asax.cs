using System;
using System.Configuration;
using System.Web;
using AutoMapper;
using Autofac;
using Autofac.Integration.Web;


using HRS.CoursePlayer;



namespace CoursePlayer
{
    public class Global : System.Web.HttpApplication, IContainerProviderAccessor
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			ExceptionManager.SetErrorStoreType = (ExceptionManager.ErrorStoreType)Enum.Parse(typeof(ExceptionManager.ErrorStoreType), ConfigurationManager.AppSettings["ErrorStoreType"], true);
			LogManager.SetLogStoreType = (LogManager.LogStoreType)Enum.Parse(typeof(LogManager.LogStoreType), ConfigurationManager.AppSettings["LogStoreType"], true);

			
            SetupIoCContainer();
		    SetupAutoMapper();
		}

        private void SetupAutoMapper()
        {
            //Mapper.CreateMap<AiccParams, LessonTracking>().ForMember(l => l.SessionTime, opt=>opt.MapFrom(a=>a.Time.Time)).ForAllMembers(
            //    opt => opt.Condition(src => !src.IsSourceValueNull));
            //Mapper.CreateMap<LessonTracking, AiccParams>().ForMember(a => a.Time, opt => opt.MapFrom(l => new AiccTime(l.TotalTime)));
        }

        protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{
			//Exception ex = Server.GetLastError();
			//if (ex != null)
			//{
			//    CustomException customEx = new CustomException("Unhandled exception caught in CoursePlayer global", CustomException.WhoCallsMe(), ExceptionSeverityLevel.Fatal, ex, true);
			//    Context.ClearError();
			//    Server.ClearError();
			//    Response.Redirect("displayError.aspx");
			//}
		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}

        private static IContainerProvider _containerProvider;
        public IContainerProvider ContainerProvider
        {
            get
            {
                return _containerProvider;
            }
        }

        private void SetupIoCContainer()
        {
            var builder = new ContainerBuilder();

            builder.Register(c => _containerProvider.ApplicationContainer);

            builder.Register(t=> new HttpContextCacheProvider(HttpContext.Current.Cache)).As<ICacheProvider>();
            builder.RegisterType<ContentModuleAdaptor>().As<IContentModuleRepository>();
            builder.RegisterType<CourseConfigurationAdaptor>().As<ICourseConfigurationRepository>();
            builder.RegisterType<FilesystemContentModuleRetriever>().As<IContentModuleRetriever>();
            builder.Register(t=> GetTrackingManager()).As<IContentModuleTrackingRepository>();
            builder.RegisterType<ContentModuleTrackingAdaptor>().As<IContentModuleTrackingAdaptor>();
            builder.RegisterType<CourseTrackingUpdater>().As <ICourseTrackingUpdater>();
            builder.RegisterType<ContentModuleTracker>().As<IContentModuleTrackingManager>();
            builder.RegisterType<ContentModuleSessionManager>().As<IContentModuleSessionRepository>();
            builder.RegisterType<ActivityAssignmentAdaptor>().As<ICourseAssignmentRepository>();
            builder.RegisterType<CoursePlayerAssignmentManager>().As<ICoursePlayerAssignmentManager>();

            _containerProvider = new ContainerProvider(builder.Build());
        }

        private ContentModuleTrackingManager GetTrackingManager()
        {
            bool IsStoreToContentServer = true;
            //~if (CourseTracking.IsStoreToContentServer())
            if (IsStoreToContentServer)
                //return new FilesystemContentModuleTrackingManager(CourseTracking.UserDataXmlPath);
                return new FilesystemContentModuleTrackingManager(System.Configuration.ConfigurationManager.AppSettings["sAppRootPath"].ToString() + System.Configuration.ConfigurationManager.AppSettings["UserDataXmlPath"].ToString());
            
            return new ContentModuleTrackingManager();
        }
	}
}
