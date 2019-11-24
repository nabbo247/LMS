using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using LMSBL.DBModels;

namespace LMSBL.Repository
{
    public class CoursesRepository
    {
        DataRepository db = new DataRepository();
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
                        FileName = CourseName + "_" + new Guid().ToString() + "." + zip.FileName.Split('.')[1];
                        System.IO.File.WriteAllBytes(Path.Combine(path, FileName), data);

                    }
                    return Path.Combine(path, FileName);
                }
                else
                {
                    return "";
                }
            }
            catch (Exception) { throw; }


        }

        public List<TblCourse> GetCourseById(int CourseId)
        {
            try
            {
                db.AddParameter("@courseId", SqlDbType.Int, CourseId);
                DataSet ds = db.FillData("sp_CourseGetById");
                List<TblCourse> coursesDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblCourse
                {
                    CourseId = Convert.ToInt32(dr["courseId"]),
                    CourseName = Convert.ToString(dr["courseName"]),
                    CourseDetails = Convert.ToString(dr["courseDetails"]),
                    CourseCategory = Convert.ToString(dr["courseCategory"]),
                    CoursePath = Convert.ToString(dr["coursePath"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    TenantId = Convert.ToInt32(dr["tenantId"]),
                    TenantName = Convert.ToString(dr["tenantName"])

                }).ToList();
                return coursesDetails;
            }
            catch (Exception) { throw; }
        }

        public List<TblCourse> GetAllCourses(int TenantId)
        {
            try
            {
                db.AddParameter("@tenantId", SqlDbType.Int, TenantId);
                DataSet ds = db.FillData("sp_CoursesGet");
                List<TblCourse> coursesDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblCourse
                {
                    CourseId = Convert.ToInt32(dr["courseId"]),
                    CourseName = Convert.ToString(dr["courseName"]),
                    CourseDetails = Convert.ToString(dr["courseDetails"]),
                    CourseCategory = Convert.ToString(dr["courseCategory"]),
                    CoursePath = Convert.ToString(dr["coursePath"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    CreatedBy = Convert.ToInt32(dr["createdBy"]),
                    CreatedOn = Convert.ToDateTime(dr["createdOn"]),
                    TenantId = Convert.ToInt32(dr["tenantId"]),
                    TenantName = Convert.ToString(dr["tenantName"])

                }).ToList();
                return coursesDetails;
            }
            catch (Exception) { throw; }
        }

        public int AddCourse(TblCourse obj)
        {
            try
            {
                string returnPath = UploadFile(obj.ZipFile, obj.CourseName);
                db.AddParameter("@courseName", SqlDbType.Text, obj.CourseName);
                db.AddParameter("@courseDetails", SqlDbType.Text, obj.CourseDetails);
                db.AddParameter("@courseCategory", SqlDbType.Text, obj.CourseCategory);
                db.AddParameter("@coursePath", SqlDbType.Text, returnPath);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.Tenants[0].TenantId);
                return db.ExecuteQuery("sp_CourseAdd");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditCourse(TblCourse obj)
        {
            try
            {
                string returnPath = UploadFile(obj.ZipFile, obj.CourseName);
                db.AddParameter("@courseId", SqlDbType.Int, obj.CourseId);
                db.AddParameter("@courseName", SqlDbType.Text, obj.CourseName);
                db.AddParameter("@courseDetails", SqlDbType.Text, obj.CourseDetails);
                db.AddParameter("@courseCategory", SqlDbType.Text, obj.CourseCategory);
                db.AddParameter("@coursePath", SqlDbType.Text, returnPath);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.Tenants[0].TenantId);
                return db.ExecuteQuery("sp_CourseUpdate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteCourse(TblCourse obj)
        {
            try
            {
                db = new DataRepository();
                db.AddParameter("@courseId", SqlDbType.Int, obj.CourseId);
                db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                return db.ExecuteQuery("sp_CourseActivateDeactivate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
