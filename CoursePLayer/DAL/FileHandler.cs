
using System;
using System.Collections.Generic;
using System.Net;
using System.IO;


using System.Configuration;


namespace HRS.CoursePlayer
{
    /// <summary>
    /// Common class for File related functions
    /// </summary>
    public class FileHandler
    {
        string strMessageId = "FILE_ERROR";
        ////CustomException expCustom;
        Stream streamFtp;
        FtpWebRequest ftpWebReq;
        public const string TEMP_ZIP_FOLDER_PATH = "TempForUnzip\\";
        public const string CSV_FOLDER_PATH = "CSV";
        public const string ARCHIVE_FOLDER_PATH = "ARCHIVE";
        public const string SITE_IMAGES_PATH = "images";
        public const string DEFAULT_LOGO_FILE_NAME = "DefaultLogo.jpg";

        public const string ASSET_FOLDER_PATH = "ASSET";
        public const string REFDOC_FOLDER_PATH = "REFDOC";
        public const string POLICY_FOLDER_PATH = "POLICY";
        public const string COURSE_FOLDER_PATH = "Courses";
        public const string CLIENTS_FOLDER_PATH = "Clients";
        public const string QUESTIONNAIRE_FOLDER_PATH = "QUESTIONNAIRE";
        public const string ASSESSMENT_FOLDER_PATH = "ASSESSMENT";
        public const string SCAN_FOLDER_PATH = "SCANCOPY";
        public const string Report_FOLDER_PATH = "Reports";
		public const string COURSE_TRANSLATE_FOLDER_PATH = "CourseTranslation";
        public const string CLASSROOM_TRAINING = "ClassroomTraining";
        public const string ATTENDENCE_FOLDER_PATH = "Attendence";
        public const string RESOURCE_FOLDER_PATH = "Resources";
		public const string USERPICS_PATH = "UserPics";
        public const string CKEDITOR_FOLDER_PATH = "CkEditorImages";
        public const string PRODUCTS_PATH = "Products";
        public const string USER_DATAXML_PATH = "UserDataXml";
        public const string FEEDBACK_FOLDER_PATH = "FeedbackImages";
        public const string DOCUMENT_FOLDER_PATH = "DocumentLib";
        public const string REFMATERIAL_FOLDER_PATH = "RefMaterial";
        public const string OFFLINE_COURSE_FOLDER_PATH = "OfflineCoursePlayerFiles";
        public const string VIRTUAL_TRAINING = "VirtualTraining";
        public const string FAQ_PATH = "FAQ";
        public const string ASSIGNMENTS_FOLDER_PATH = "ASSIGNMENTS";

        int iChunkSize = 131072; //128Kb
        int iMaxUploadSize = 0;
        System.Net.NetworkCredential ftpCredential = null;
        ////private Cluster entCluster;

        /// <summary>
        /// RootFtpPath
        /// </summary>
        public string RootFtpPath
        {
            get
            {
                return "root path ";
            }
            
        }




        /// <summary>
        /// FileHandler
        /// </summary>
        /// <param name="pClientId"></param>
        public FileHandler(string pClientId)
        { 
        }

        public FileHandler()
        { }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            ////entCluster = null;
        }

        /// <summary>
        /// Get Course Path
        /// </summary>
        /// <param name="pstrCourseId">Course ID</param>
        /// <returns>Complete Ftp Path ftp://***.***.**.**/ftproot/course/courseid </returns>
        public string GetCourseFTPPath(string pstrCoursePath)
        {
            return RootFtpPath + pstrCoursePath;
        }

        /// <summary>
        /// Upload file stream to specified folder 
        /// </summary>
        /// <param name="pstrFtpFolderpath">folder on FTP</param>
        /// <param name="pstrFileName">File Name</param>
        /// <param name="pbLocalFile">File stream</param>
        /// <returns>pysical access path</returns>
        public string Uploadfile(string pstrFtpFolderpath, string pstrFileName, byte[] pbLocalFile)
        {
            string strFullFileName = String.Empty;
            string strUploadFolderPath;
            string strFtpfullpath;
            long lFileSize;
            long lSentBytes = 0;
            iChunkSize = 131072;
            byte[] Buffer = new byte[iChunkSize];
            try
            {
                if (iMaxUploadSize == 0)
                {
                }
                if (ConvertSize(pbLocalFile.Length, FileSize.MegaBytes) > iMaxUploadSize)
                {
                }
                if (pstrFtpFolderpath != "" && !pstrFtpFolderpath.EndsWith("/"))
                {
                    pstrFtpFolderpath += "/";
                }
                strFtpfullpath = RootFtpPath + CheckForUnicode(pstrFtpFolderpath);
                pstrFileName = CheckForUnicode(pstrFileName);
                Uri urlFtp = new Uri(strFtpfullpath + pstrFileName);
                ftpWebReq = (FtpWebRequest)FtpWebRequest.Create(urlFtp);
                //userid and password for the ftp server to given 
                ////ftpCredential = GetNetworkCredential();
                if (ftpCredential != null)
                {
                    ftpWebReq.Credentials = ftpCredential;
                }
                ftpWebReq.Proxy = null;
                ftpWebReq.KeepAlive = true;
                ftpWebReq.UseBinary = true;
                ftpWebReq.Method = WebRequestMethods.Ftp.UploadFile;
                
                using (streamFtp = ftpWebReq.GetRequestStream())
                {
                    lFileSize = pbLocalFile.Length;
                    if (iChunkSize > lFileSize)
                    {
                        iChunkSize = Convert.ToInt32(lFileSize);
                    }
                    while (lSentBytes < lFileSize)
                    {
                        streamFtp.Write(pbLocalFile, Convert.ToInt32(lSentBytes), iChunkSize);
                        lSentBytes += iChunkSize;
                        if ((lFileSize - lSentBytes) < iChunkSize)
                        {
                            iChunkSize = Convert.ToInt32(lFileSize - lSentBytes);
                        }
                    }
                }
                
                pstrFtpFolderpath = pstrFtpFolderpath.Replace("//", "/");
                pstrFtpFolderpath = pstrFtpFolderpath.Replace("/", @"\");
                
            }
            
            catch (Exception expCommon)
            {
                
            }
            finally
            {
                if (streamFtp != null)
                {
                    //-- streamFtp.Flush(); and streamFtp = null; Newly added
                    streamFtp.Flush();
                    streamFtp.Close();
                    streamFtp = null;
                }
            }
            return pstrFileName;
        }

        /// <summary>
        /// Copy File from Source to destination
        /// </summary>
        /// <param name="pSource">Source Path</param>
        /// <param name="pDestination">Destination Path</param>
        /// <returns>Copied Path</returns>
        public string CopyFile(string pSource, string pDestination)
        {
            ////try
            ////{
            ////    string strContentFolderPath = RootSharedPath;
            ////    pSource = strContentFolderPath + pSource.Replace("/", @"\");
            ////    pDestination = strContentFolderPath + pDestination.Replace("/", @"\");
            ////    File.Copy(pSource, pDestination, true);
            ////}
            ////catch (Exception expCommon)
            ////{
            ////    ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Fatal, expCommon, true);
            ////    throw expCustom;
            ////}
            return pDestination;
        }

        /// <summary>
        /// Delete File
        /// </summary>
        /// <param name="strFtpfullpath">Full Path</param>
        /// <returns></returns>
        public bool DeleteFileOnServer(string strFtpfullpath)
        {
            return PerformFolderAction("", strFtpfullpath, WebRequestMethods.Ftp.DeleteFile);
        }

        /// <summary>
        /// Create folder on specified path
        /// </summary>
        /// <param name="strFtpFolderpath">folder path on ftp</param>
        /// <param name="sDirName">new folder name</param>
        /// <returns>true if success</returns>
        public bool CreateFolder(string strFtpFolderpath, string sDirName)
        {
            return PerformFolderAction(strFtpFolderpath, sDirName, WebRequestMethods.Ftp.MakeDirectory);
        }

        /// <summary>
        /// Copy folder Content to destination Folder
        /// </summary>
        /// <param name="pSource">Source Path</param>
        /// <param name="pDestination">Destination Folder Path</param>
        /// <returns>true if success</returns>
        public bool CopyFolderContent(string pSourceFolder, string pDestinationFolder)
        {
            ////try
            ////{
            ////    string strContentFolderPath = RootSharedPath; // EncryptionManager.Decrypt(ConfigurationManager.AppSettings[CONTENT_FOLDER_PATH]);
            ////    pSourceFolder = strContentFolderPath + pSourceFolder.Replace("/", @"\");
            ////    pDestinationFolder = strContentFolderPath + pDestinationFolder.Replace("/", @"\");

            ////    //Copy all the files
            ////    System.IO.FileInfo[] fiA = (new System.IO.DirectoryInfo(pSourceFolder).GetFiles());
            ////    foreach (System.IO.FileInfo fi in fiA)
            ////    {
            ////        fi.CopyTo(pDestinationFolder + "\\" + fi.Name);
            ////    }
            ////    //Recursively fill the child directories
            ////    System.IO.DirectoryInfo[] diA = (new System.IO.DirectoryInfo(pSourceFolder).GetDirectories());
            ////    foreach (System.IO.DirectoryInfo di in diA)
            ////    {
            ////        CopyFolder(new object[] { di.FullName, pDestinationFolder, false });
            ////    }
            ////}
            ////catch (Exception expCommon)
            ////{
            ////    ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Fatal, expCommon, false);
            ////    //throw expCustom;
            ////    return false;
            ////}
            return true;
        }

        /// <summary>
        /// Get Directories of Source folder
        /// </summary>
        /// <param name="pSourcePath">if blank get root structure</param>
        /// <returns></returns>
        public DirectoryInfo[] GetAllFolders(string pSourcePath)
        {
            DirectoryInfo[] dirInfo = null;
            
            return dirInfo;
        }

        /// <summary>
        /// Get Files of Source folder
        /// </summary>
        /// <param name="pSourcePath">if blank get root structure</param>
        /// <returns></returns>
        public FileInfo[] GetAllFiles(string pSourcePath, string pSearchPattern)
        {
            FileInfo[] dirInfo = null;
            
            return dirInfo;
        }

        /// <summary>
        /// Returns FTP path of given shared path
        /// </summary>
        /// <param name="pSharedPath"></param>
        /// <returns>Ftp Path</returns>
        public string GetFTPPath(string pSharedPath)
        {
            
            return pSharedPath;
        }

        /// <summary>
        /// Recursively Copies source folders and files to the destination folder.
        /// </summary>
        /// <param name="sourceFolderPath">The folder to be copied.</param>
        /// <param name="destinationFolderPath">The folder to where the folder to be copied will be copied.</param>
        /// <param name="overwrite">Overwrite existing files and folders that exist.</param>
        private void CopyFolder(object o)
        {
            string sourceFolderPath = "Source Not Found";
            string destinationFolderPath = "Destination Not Found";
            bool overwrite = false;
            sourceFolderPath = ((string)(((object[])o)[0]));
            destinationFolderPath = ((string)(((object[])o)[1]));
            overwrite = ((bool)(((object[])o)[2]));
            if (System.IO.Directory.Exists(sourceFolderPath))
            {
                if (System.IO.Directory.Exists(destinationFolderPath + "\\" + (new System.IO.DirectoryInfo(sourceFolderPath).Name)) && (!overwrite))
                    throw new System.Exception("Sorry, but the folder " + destinationFolderPath + " already exists.");
                else if (!System.IO.Directory.Exists(destinationFolderPath + "\\" + (new System.IO.DirectoryInfo(sourceFolderPath).Name)))
                    System.IO.Directory.CreateDirectory(destinationFolderPath + "\\" + (new System.IO.DirectoryInfo(sourceFolderPath).Name));

                //Copy all the files
                System.IO.FileInfo[] fiA = (new System.IO.DirectoryInfo(sourceFolderPath).GetFiles());
                foreach (System.IO.FileInfo fi in fiA)
                {
                    fi.CopyTo(destinationFolderPath + "\\" + (new System.IO.DirectoryInfo(sourceFolderPath).Name) + "\\" + fi.Name);
                }
                //Recursively fill the child directories
                System.IO.DirectoryInfo[] diA = (new System.IO.DirectoryInfo(sourceFolderPath).GetDirectories());
                foreach (System.IO.DirectoryInfo di in diA)
                {
                    CopyFolder(new object[] { di.FullName, destinationFolderPath + "\\" + (new System.IO.DirectoryInfo(sourceFolderPath).Name), overwrite });
                }
            }
        }

        /// <summary>
        /// Remove folder on specified path
        /// </summary>
        /// <param name="strFtpFolderpath">folder path on ftp</param>
        /// <param name="sDirName">folder name</param>
        /// <returns>true if success</returns>
        public bool RemoveFolder(string pFtpFolderpath)
        {
            
            return true;
        }

        /// <summary>
        /// Rename folder on specified path
        /// </summary>
        /// <param name="strFtpFolderpath">folder path on ftp</param>
        /// <param name="sDirName">new folder name</param>
        /// <returns>true if success</returns>
        private bool PerformFolderAction(string pFtpFolderpath, string pDirName, string pAction)
        {
            FtpWebResponse ftpWebResponse = null;
            Stream streamFtp = null;
            string strFtpfullpath;
            bool returnValue = false;
            string urlFtp;
            try
            {
                strFtpfullpath = RootFtpPath + CheckForUnicode(pFtpFolderpath);
                if (pAction != WebRequestMethods.Ftp.Rename)
                {
                    if (!strFtpfullpath.EndsWith("/") && pDirName.Length > 0 && !pDirName.StartsWith("/"))
                    {
                        pDirName = "/" + pDirName;
                    }
                    pDirName = CheckForUnicode(pDirName);
                    urlFtp = strFtpfullpath + pDirName;
                }
                else
                {
                    urlFtp = strFtpfullpath;
                }
                ftpWebReq = (FtpWebRequest)FtpWebRequest.Create(urlFtp);
                //userid and password for the ftp server to given 
                ////ftpCredential = GetNetworkCredential();
                if (ftpCredential != null)
                {
                    ftpWebReq.Credentials = ftpCredential;
                }
                ftpWebReq.Proxy = null;
                ftpWebReq.UseBinary = true;
                ftpWebReq.Method = pAction;
                if (pAction == WebRequestMethods.Ftp.Rename)
                {
                    ftpWebReq.RenameTo = pDirName;
                }
                ftpWebResponse = (FtpWebResponse)ftpWebReq.GetResponse();
                streamFtp = ftpWebResponse.GetResponseStream();
                returnValue = true;
            }
            catch (Exception expCommon)
            {
                ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe() + "--" +pFtpFolderpath + "#" + pDirName + "$" + pAction, ExceptionSeverityLevel.Fatal, expCommon, true);
                returnValue = false;
            }
            finally
            {
                if (ftpWebResponse != null)
                {
                    ftpWebResponse.Close();
                    ftpWebResponse = null;
                }
                if (streamFtp != null)
                {
                    streamFtp.Close();
                    streamFtp = null;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// Check For Special Characters 
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public static string CheckForUnicode(string pPath)
        {
            return System.Web.HttpUtility.UrlEncode(pPath).Replace("+", " ");
        }

        /// <summary>
        /// This funtion will unzip the zip uploaded files
        /// </summary>
        /// <param name="pstrFileName"></param>
        /// <returns></returns>
        public bool UnZipServerFiles(string pstrFileName, string pstrCourseId)
        {
            bool bIsReturn = false;
            
            return bIsReturn;
        }



        /// <summary>
        /// Check for invalid file extension, returns auto generated file name  
        /// </summary>
        /// <param name="pFileName">Original file name</param>
        /// <returns>auto generated file name</returns>
        public string ValidateFile(string pFileName)
        {
            string strFileName = String.Empty;
            if (!String.IsNullOrEmpty(pFileName) &&
                !pFileName.ToLower().EndsWith(".exe") &&
                !pFileName.ToLower().EndsWith(".dll"))
            {
                strFileName += IDGenerator.GetStringGUID();
                if (pFileName.LastIndexOf(".") > 0)
                {
                    strFileName += pFileName.Substring(pFileName.LastIndexOf(".") - 1);
                }
            }
            return strFileName;
        }

        /// <summary>
        /// Check if folder exist in folder
        /// </summary>
        /// <param name="strFtpFolderpath">send "" if on root</param>
        /// <param name="sDirName">directory to check</param>
        /// <returns>true if exists</returns>
        public bool IsFolderExist(string strFtpFolderpath, string sDirName)
        {
            FtpWebResponse ftpWebResponse = null;
            bool bretValue = false;
            string strFtpfullpath;
            Uri urlFtp;
            try
            {
                if (strFtpFolderpath.Length > 1 && (strFtpFolderpath.StartsWith("/")))
                {
                    strFtpFolderpath = strFtpFolderpath.Remove(0, 1);
                }
                strFtpfullpath = RootFtpPath + CheckForUnicode(strFtpFolderpath);
                
                if (sDirName.Length > 0 && !(sDirName.EndsWith("/")))
                {
                    sDirName += "/";
                }
                ///////

                if (sDirName.Length > 0 && !(sDirName.StartsWith("/")))
                {
                    sDirName = "/" + CheckForUnicode(sDirName);
                }
               
                urlFtp = new Uri(strFtpfullpath + sDirName);
                ftpWebReq = (FtpWebRequest)FtpWebRequest.Create(urlFtp);
                
                if (ftpCredential != null)
                {
                    ftpWebReq.Credentials = ftpCredential;
                }
                ftpWebReq.Proxy = null;
                ftpWebReq.UseBinary = true;
                ftpWebReq.Method = WebRequestMethods.Ftp.ListDirectory;
                try
                {
                    ftpWebResponse = (FtpWebResponse)ftpWebReq.GetResponse();
                }
                catch
                {
                     bretValue = false;
                }
                if (ftpWebResponse != null)
                {
                    try
                    {
                        ftpWebResponse.Close();
                        bretValue = true;
                    }
                    catch
                    {
                        bretValue = false;
                    }
                }
            }
            catch (Exception expCommon)
            {
                ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Fatal, expCommon, true);
                ////throw expCustom;
            }
            return bretValue;
        }

        /// <summary>
        /// Converts Byte Content Length to Type - MB,KB,GB depending upon the parameters supplied
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int ConvertSize(int pBytes, FileHandler.FileSize pType)
        {
            int CONVERSION_VALUE = 1024;
            double returnValue = 0;
            switch (pType)
            {
                case FileSize.Bytes:
                    return pBytes;                   
                case FileSize.KiloBytes:
                    try
                    {
                        returnValue = pBytes / CONVERSION_VALUE;
                    }
                    catch
                    {
                        returnValue = 0;
                    }
                    break;
                case FileSize.MegaBytes:
                    try
                    {
                        returnValue = (pBytes / CalculateSquare(CONVERSION_VALUE));
                    }
                    catch
                    {
                        returnValue = 0;
                    }
                    break;
                case FileSize.GigaBytes:
                    try
                    {
                        returnValue = (pBytes / CalculateCube(CONVERSION_VALUE));
                    }
                    catch
                    {
                        returnValue = 0;
                    }
                    break;
            }
            return Convert.ToInt32(returnValue);
        }

        /// <summary>

        /// Function to calculate the square of the provided number

        /// </summary>

        /// <param name="number">Int32 -> Number to be squared</param>

        /// <returns>Double -> THe provided number squared</returns>

        /// <remarks></remarks>
        private double CalculateSquare(Int32 number)
        {
            return Math.Pow(number, 2);
        }

        /// <summary>

        /// Function to calculate the cube of the provided number

        /// </summary>

        /// <param name="number">Int32 -> Number to be cubed</param>

        /// <returns>Double -> THe provided number cubed</returns>

        /// <remarks></remarks>
        private double CalculateCube(Int32 number)
        {
            return Math.Pow(number, 3);
        }

        /// <summary>
        /// Enum FileSize
        /// </summary>
        public enum FileSize
        {
            Bytes,
            KiloBytes,
            MegaBytes,
            GigaBytes
        }

        ////private static void AddToCache(Client pClient)
        ////{
        ////    if (LMSCache.IS_IN_USE)
        ////    {
        ////        if (!LMSCache.IsInCache(pClient.ID))
        ////        {
        ////            LMSCache.AddCacheItem(pClient.ID, pClient, pClient.ID);
        ////        }
        ////        //To add Feature List in Cache       
        ////        if (!LMSCache.IsInCache(pClient.ID + AdminFeatures.CACHE_SUFFIX))
        ////        {
        ////            AddFeaturesToCache(pClient.ID);
        ////        }
        ////        //To add Feature List in Cache       
        ////        if (!LMSCache.IsInCache(pClient.ID + SystemMessage.CACHE_SUFFIX))
        ////        {
        ////            AddMessagesToCache(pClient.ID);
        ////        }
        ////    }
        ////}

        /////// <summary>
        /////// Add Messages to Cache
        /////// </summary>
        /////// <param name="ClientId"></param>
        ////public static void AddMessagesToCache(string pClientId)
        ////{
        ////    SystemMessage entMessage = new SystemMessage();
        ////    SystemMessageAdaptor adaptorMessage = new SystemMessageAdaptor();
        ////    SystemMessageCache entCMessage;
        ////    List<SystemMessageCache> entListCMessage = new List<SystemMessageCache>();
        ////    entMessage.ClientId = pClientId;
        ////    try
        ////    {
        ////        List<SystemMessage> entListMessage = adaptorMessage.GetMessageList(entMessage);
        ////        foreach (SystemMessage message in entListMessage)
        ////        {
        ////            entCMessage = new SystemMessageCache();
        ////            entCMessage.ID = message.ID;
        ////            entCMessage.LanguageId = message.LanguageId;
        ////            entCMessage.MessageText = message.MessageText;
        ////            entListCMessage.Add(entCMessage);
        ////        }
        ////        if (LMSCache.IsInCache(pClientId + SystemMessage.CACHE_SUFFIX))
        ////        {
        ////            LMSCache.RemoveCacheItems(pClientId);
        ////        }
        ////        LMSCache.AddCacheItem(pClientId + SystemMessage.CACHE_SUFFIX, entListCMessage, pClientId);
        ////    }
        ////    catch (Exception expCommon)
        ////    {
        ////        throw new CustomException(Services.Messages.Common.ERROR, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Fatal, expCommon, true);
        ////    }
        ////}

        /////// <summary>
        /////// Add Features To Cache
        /////// </summary>
        /////// <param name="pClientId"></param>
        ////public static void AddFeaturesToCache(string pClientId)
        ////{
        ////    List<AdminFeatures> entListAdminFeature = null;
        ////    AdminFeatures entAdminFeature = new AdminFeatures();
        ////    entAdminFeature.ClientId = pClientId;
        ////    AdminFeaturesAdaptor adaptorAdminFeature = new AdminFeaturesAdaptor();
        ////    entListAdminFeature = adaptorAdminFeature.GetFeaturesList(entAdminFeature);
        ////    if (entListAdminFeature != null)
        ////    {
        ////        LMSCache.AddCacheItem(pClientId + AdminFeatures.CACHE_SUFFIX, entListAdminFeature, pClientId);
        ////    }
        ////}

        ////public static Client GetClient(string pClientId)
        ////{
        ////    Client entClient = null;
        ////    if (!String.IsNullOrEmpty(pClientId) && LMSCache.IsInCache(pClientId))
        ////    {
        ////        entClient = (Client)LMSCache.GetValue(pClientId);
        ////    }
        ////    if (entClient == null)
        ////    {
        ////        entClient = new ClientDAM().GetClientByID(new Client { ID = pClientId });
        ////        if (entClient != null && !String.IsNullOrEmpty(entClient.ID))
        ////        {
        ////            AddToCache(entClient);
        ////        }
        ////        else
        ////        {
        ////            throw new CustomException(BVLMS.Services.Messages.Client.INVALID_CLIENT_ID, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, null, true);
        ////        }
        ////    }
        ////    return entClient;
        ////}
    }
}