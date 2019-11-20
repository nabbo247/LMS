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
        public string UploadFile(HttpPostedFileBase zip)
        {
            var path = ConfigurationManager.AppSettings["DestinationPath"].ToString();
            byte[] data;
            using (Stream inputStream = zip.InputStream)
            {
                using(MemoryStream ms=new MemoryStream())
                {
                    inputStream.CopyTo(ms);
                    data = ms.ToArray();
                }
               
                //if (!(inputStream is MemoryStream memoryStream))
                //{
                //    memoryStream = new MemoryStream();
                //    inputStream.CopyTo(memoryStream);
                //}
               // data = memoryStream.ToArray();
                System.IO.File.WriteAllBytes(Path.Combine(path, zip.FileName), data);

            }

            return Path.Combine(path, zip.FileName);
        }

        public List<TblCourse> GetCourseById(int CourseId)
        {

            db.AddParameter("@courseId", SqlDbType.Int, CourseId);
            DataSet ds = db.FillData("CourseGetById");
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

        public List<TblCourse> GetAllCourses(int TenantId)
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
                CreatedBy=Convert.ToInt32(dr["createdBy"]),
                CreatedOn=Convert.ToDateTime(dr["createdOn"]),
                TenantId = Convert.ToInt32(dr["tenantId"]),
                TenantName = Convert.ToString(dr["tenantName"])

            }).ToList();
            return coursesDetails;
        }

        

        public int AddCourse(TblCourse obj)
        {
            try
            {
                string returnPath = UploadFile(obj.ZipFile);
                obj.CreatedBy = 1;//hardcoded put loginid here
                db.AddParameter("@courseName", SqlDbType.Text, obj.CourseName);
                db.AddParameter("@courseDetails", SqlDbType.Text, obj.CourseDetails);
                db.AddParameter("@courseCategory", SqlDbType.Text, obj.CourseCategory);
                db.AddParameter("@coursePath", SqlDbType.Text, returnPath);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.Tenants[0].TenantId);
                return db.ExecuteQuery("CourseAdd");
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
                return db.ExecuteQuery("CourseActivateDeactivate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
