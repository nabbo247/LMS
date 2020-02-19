using System;
//using System.Threading.Tasks;
using System.IO;
using System.Configuration;
namespace HRS.CoursePlayer
{
    public class clsErrorhandling
    {
        private FileStream objFile;
        private StreamWriter objWriter;
        private void CreateErrorFile(string strLogFileName)
        {
            if (objFile == null)
            {
                if (!Directory.Exists(ConfigurationManager.AppSettings["sAppRootPath"] + ConfigurationManager.AppSettings["storelogpath"]))
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["sAppRootPath"] + ConfigurationManager.AppSettings["storelogpath"]);
                objFile = new FileStream(String.Concat(ConfigurationManager.AppSettings["sAppRootPath"] + ConfigurationManager.AppSettings["storelogpath"], strLogFileName, "_", DateTime.Today.ToString("yyyyMMdd"), ".txt"), FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            }
            if (objWriter == null)
                objWriter = new StreamWriter(objFile);
        }

        public  void LogException(Exception exp)
        {
            try
            {
                CreateErrorFile("ExceptionLog");
                objWriter.WriteLine();
                objWriter.Write("DateTime :" + DateTime.Now.ToString());
                objWriter.Write("   Error :" + exp.Message);
                 objWriter.WriteLine();
                objWriter.Write("   Error :" + exp.StackTrace);
                objWriter.WriteLine();
                objWriter.Write("********************************************************************************");
                
            }
            finally
            {
                objWriter.Flush();
                objWriter.Close();
                objWriter = null;
                objFile.Close();
                objFile = null;                               
            }
        }
        public  void LogException(Exception exp,string ClassName, string MethodName)
        {
            try
            {
                CreateErrorFile("ExceptionLog");
                objWriter.WriteLine();
                objWriter.Write("DateTime :" + DateTime.Now.ToString());
                objWriter.Write("Class :" + ClassName);
                objWriter.Write("MethodName :" + ClassName);
                objWriter.Write("   Error :" + exp.Message);
                objWriter.WriteLine();
                objWriter.Write("   Error :" + exp.StackTrace);
                objWriter.WriteLine();
                objWriter.Write("********************************************************************************");
                
            }
            finally
            {
                objWriter.Flush();
                objWriter.Close();
                objWriter = null;
                objFile.Close();
                objFile = null;                               
            }
        }
        public  void WriteLog(string Message)
        {
            try
            {
                CreateErrorFile("ExceptionLog");
                objWriter.WriteLine();
                objWriter.Write("DateTime :" + DateTime.Now.ToString());
                objWriter.Write("   Error :" + Message);                
                objWriter.WriteLine();
                objWriter.Write("********************************************************************************");
                
            }
            finally
            {
                objWriter.Flush();
                objWriter.Close();
                objWriter = null;
                objFile.Close();
                objFile = null;                               
            }
        }
        public  void WriteLog(string Message,string ClassName, string MethodName)
        {
            try
            {
                CreateErrorFile("ExceptionLog");
                objWriter.WriteLine();
                objWriter.Write("DateTime :" + DateTime.Now.ToString());
                objWriter.Write("Class :" + ClassName);
                objWriter.Write("MethodName :" + ClassName);
                objWriter.Write("   Error :" + Message);               
                objWriter.WriteLine();
                objWriter.Write("********************************************************************************");
                
            }
            finally
            {
                objWriter.Flush();
                objWriter.Close();
                objWriter = null;
                objFile.Close();
                objFile = null;                               
            }
        }
    }
}
