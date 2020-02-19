using System;
using System.IO;



namespace HRS.CoursePlayer
{
    public class FilesystemContentModuleTrackingManager : ContentModuleTrackingManager
    {
        private readonly string _userDataPath;
        public FilesystemContentModuleTrackingManager(string userDataPath)
        {
            _userDataPath = userDataPath;
        }

        public override ContentModuleTracking GetUserDataXml(ContentModuleTracking pEntContModTracking)
        {
            var entContModTrackingReturn = base.GetUserDataXml(pEntContModTracking);
            var trackingDirectory = String.Format("{0}\\{1}", _userDataPath, entContModTrackingReturn.ContentModuleId);
            if (!Directory.Exists(trackingDirectory)) Directory.CreateDirectory(trackingDirectory);
            var trackingFile = trackingDirectory + @"\" + entContModTrackingReturn.UserID + "_" + entContModTrackingReturn.ContentModuleId + "_UserDataXML.xml";
            if (File.Exists(trackingFile))
                entContModTrackingReturn.UserDataXML = File.ReadAllText(trackingFile);
            return entContModTrackingReturn;
        }

        public override ContentModuleTrackingAdaptor.ContentModuleTrackingUpdateResult EditTracking(ContentModuleTracking trackingToSave)
        {
            if (!String.IsNullOrEmpty(trackingToSave.UserDataXML))
            {
                var trackingDirectory = String.Format("{0}\\{1}", _userDataPath, trackingToSave.ContentModuleId);
                if (!Directory.Exists(trackingDirectory)) Directory.CreateDirectory(trackingDirectory);
                var trackingFile = trackingDirectory + @"\" + trackingToSave.UserID + "_" + trackingToSave.ContentModuleId + "_UserDataXML.xml";
                File.WriteAllText(trackingFile, trackingToSave.UserDataXML);

                //trackingToSave.UserDataXML = string.Empty;
            }
            return base.EditTracking(trackingToSave);
        }
    }
}
