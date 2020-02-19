using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRS.CoursePlayer
{
    public class Learner: BaseEntity
    {

        public const string USER_SESSION_ID = "USERID";
        public string LearnerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmployeeId { get; set; }
        public string DeptId { get; set; }
        public string JobId { get; set; }
        public string HireDate { get; set; }
        public string RegionId { get; set; }
        public string DistrictId { get; set; }
        public string StoreId { get; set; }
        public string EmployeeStatus { get; set; }
        public string RehireDate { get; set; }
        public string TerminationStatus { get; set; }
        public string TerminationDate { get; set; }
        public string Email { get; set; }
        public string LastAccessed { get; set; }
        public string DOSAId { get; set; }
        public string SectorId { get; set; }
        public string IsActive { get; set; }
        public string LanguageId { get; set; }
        public bool IsLogistics { get; set; }
        public bool IsComplianceVideo { get; set; }
        public bool IsIFFSDisabled { get; set; }
        public string IsTemp { get; set; }


        /// <summary>
        /// ENUM Method
        /// </summary>
        public new enum Method
        {
            GetUser_CoursePlayer,
            Get
        }
    
    }
}
