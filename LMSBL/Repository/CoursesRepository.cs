using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Web;
using LMSBL.Common;
using LMSBL.DBModels;

namespace LMSBL.Repository
{
    public class CoursesRepository
    {
        DataRepository db = new DataRepository();
        Exceptions newException = new Exceptions();
        public string UploadFile(HttpPostedFileBase zip, string CourseName)
        {
            try
            {
                var path = ConfigurationManager.AppSettings["DestinationPath"].ToString();
                byte[] data;
                string FileName = "";
                if (zip != null)
                {
                    using (Stream inputStream = zip.InputStream)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            inputStream.CopyTo(ms);
                            data = ms.ToArray();
                        }
                        FileName = CourseName + "." + zip.FileName.Split('.')[1];
                        System.IO.File.WriteAllBytes(Path.Combine(path, FileName), data);
                        ZipArchive archive = ZipFile.OpenRead(Path.Combine(path, FileName));
                        if (Directory.Exists(path + "\\" + CourseName))
                        {
                            Directory.Delete(path + "\\" + CourseName, true);
                        }
                        archive.ExtractToDirectory(path + "\\" + CourseName);

                    }
                    return Path.Combine(path, FileName);
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }


        }

        public List<tblCourse> GetCourseById(int CourseId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@ContentModuleId", SqlDbType.Int, CourseId);
                DataSet ds = db.FillData("sp_CourseGetById");
                List<tblCourse> coursesDetails = ds.Tables[0].AsEnumerable().Select(dr => new tblCourse
                {
                    ContentModuleId = Convert.ToInt32(dr["ContentModuleId"]),
                    ContentModuleName = Convert.ToString(dr["ContentModuleName"]),
                    ContentModuleDescription = Convert.ToString(dr["ContentModuleDescription"]),
                    ContentModuleURL = Convert.ToString(dr["ContentModuleURL"]),
                    ContentModuleType = Convert.ToString(dr["ContentModuleType"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    MasteryScore = dr["MasteryScore"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MasteryScore"]),
                    createdBy = Convert.ToInt32(dr["createdBy"]),
                    createdOn = Convert.ToDateTime(dr["createdOn"]),
                    tenantId = Convert.ToInt32(dr["tenantId"]),
                    Duration = dr["Duration"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Duration"])
                    //Duration = Convert.ToInt32(dr["Duration"])


                }).ToList();
                return coursesDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }

        public List<tblCourse> GetAllCourses(int TenantId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, TenantId);
                DataSet ds = db.FillData("sp_CoursesGet");
                List<tblCourse> coursesDetails = ds.Tables[0].AsEnumerable().Select(dr => new tblCourse
                {
                    ContentModuleId = Convert.ToInt32(dr["ContentModuleId"]),
                    ContentModuleName = Convert.ToString(dr["ContentModuleName"]),
                    ContentModuleDescription = Convert.ToString(dr["ContentModuleDescription"]),
                    ContentModuleURL = Convert.ToString(dr["ContentModuleURL"]),
                    ContentModuleType = Convert.ToString(dr["ContentModuleType"]),
                    IsActive = Convert.ToBoolean(dr["IsActive"]),
                    MasteryScore = dr["MasteryScore"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MasteryScore"]),
                    createdBy = Convert.ToInt32(dr["createdBy"]),
                    createdOn = Convert.ToDateTime(dr["createdOn"]),
                    tenantId = Convert.ToInt32(dr["tenantId"]),
                    //Duration = dr["Duration"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Duration"])
                    Duration = Convert.ToInt32(Convert.ToString(dr["Duration"]))

                }).ToList();
                return coursesDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }

        public int AddCourse(tblCourse obj)
        {
            int status = 0;
            int ContentModuleId = 0;
            try
            {
                db.parameters.Clear();
                var path = ConfigurationManager.AppSettings["DestinationPath"].ToString();
                db.AddParameter("@ContentModuleName", SqlDbType.Text, obj.ContentModuleName);
                db.AddParameter("@ContentModuleDescription", SqlDbType.Text, obj.ContentModuleDescription);
                db.AddParameter("@ContentModuleType", SqlDbType.Text, obj.ContentModuleType);
                db.AddParameter("@ContentModuleURL", SqlDbType.Text, path);
                db.AddParameter("@MasteryScore", SqlDbType.Int, obj.MasteryScore);
                db.AddParameter("@Duration", SqlDbType.Int, obj.Duration);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.createdBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.tenantId);
                db.AddParameter("@ContentModuleId", SqlDbType.Int, ParameterDirection.Output);
                status = db.ExecuteQuery("sp_CourseAdd");
                if (Convert.ToInt32(db.parameters[8].Value) > 0)
                {
                    ContentModuleId = Convert.ToInt32(db.parameters[8].Value);
                    string returnPath = UploadFile(obj.ZipFile, Convert.ToString(ContentModuleId));
                }

                if (ContentModuleId > 0)
                {
                    status = ContentModuleId;
                }
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                //throw ex;
                status = -2;
            }
            return status;
        }

        public int EditCourse(tblCourse obj)
        {
            int status = 0;
            try
            {
                string returnPath = string.Empty;
                if (!string.IsNullOrEmpty(obj.ContentModuleURL) && obj.ZipFile == null)
                {
                    returnPath = obj.ContentModuleURL;
                }
                else
                {
                    returnPath = UploadFile(obj.ZipFile, Convert.ToString(obj.ContentModuleId));
                }
                db.parameters.Clear();
                db.AddParameter("@ContentModuleId", SqlDbType.Int, obj.ContentModuleId);
                db.AddParameter("@ContentModuleName", SqlDbType.Text, obj.ContentModuleName);
                db.AddParameter("@ContentModuleDescription", SqlDbType.Text, obj.ContentModuleDescription);
                db.AddParameter("@ContentModuleType", SqlDbType.Text, obj.ContentModuleType);
                db.AddParameter("@ContentModuleURL", SqlDbType.Text, returnPath);
                db.AddParameter("@MasteryScore", SqlDbType.Int, obj.MasteryScore);
                db.AddParameter("@Duration", SqlDbType.Int, obj.Duration);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.createdBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.tenantId);
                status = db.ExecuteQuery("sp_CourseUpdate");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                //throw ex;
                status = -2;
            }
            return status;
        }

        public int DeleteCourse(tblCourse obj)
        {
            try
            {
                db = new DataRepository();
                db.parameters.Clear();
                db.AddParameter("@ContentModuleId", SqlDbType.Int, obj.ContentModuleId);
                db.AddParameter("@IsActive", SqlDbType.Bit, obj.IsActive);
                return db.ExecuteQuery("sp_CourseActivateDeactivate");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }

        public DataSet GetAssignedCourseUsers(int CourseId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@ContentModuleId", SqlDbType.Int, CourseId);
                DataSet ds = db.FillData("sp_GetAssignedUsersForCourse");
                return ds;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }
        public int DeleteAssignedUserForCourse(int CourseId)
        {
            int status = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@ContentModuleId", SqlDbType.Text, Convert.ToString(CourseId));
                status = db.ExecuteQuery("sp_DeleteAssignedUsersForCourse");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }

        public int AssignCourse(int ContentModuleId, int UserId, DateTime DueDate)
        {
            int status = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@UserId", SqlDbType.Text, UserId);
                db.AddParameter("@ActivityId", SqlDbType.Text, ContentModuleId);
                db.AddParameter("@DueDate", SqlDbType.DateTime, DueDate);
                status = db.ExecuteQuery("sp_CourseAssign");

            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }
    }
}
