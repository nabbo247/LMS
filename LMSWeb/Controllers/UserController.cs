using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using LMSWeb.App_Start;

namespace LMSWeb.Controllers
{
    public class UserController : Controller
    {
        UserRepository ur = new UserRepository();
        RolesRepository rr = new RolesRepository();
        TenantRepository tr = new TenantRepository();
        Exceptions newException = new Exceptions();
        // GET: Tenant
        public ActionResult Index()
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                List<TblUser> lstAllUsers = new List<TblUser>();
                lstAllUsers = ur.GetAllUsers(sessionUser.TenantId);
                return View(lstAllUsers);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult GetUserDetails()
        {
            try
            {
                List<TblUser> userDetails = new List<TblUser>();
                TblUser sessionUser = (TblUser)Session["UserSession"];
                userDetails = ur.GetUserById(sessionUser.TenantId);

                return View(userDetails);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult GetAllUsers()
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                List<TblUser> lstAllActiveUsers = new List<TblUser>();
                lstAllActiveUsers = ur.GetAllUsers(sessionUser.TenantId);

                return PartialView(lstAllActiveUsers);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult AddUser()
        {
            try
            {
                TblUser objEditData = new TblUser
                {
                    UserRoles = rr.GetAllRoles(),
                    Tenants = tr.GetAllTenants()
                };
                objEditData.IsMyProfile = false;
                return View("AddNewUser", objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AddNewUser");
            }
        }

        [HttpPost]
        public ActionResult AddUser(TblUser objUser, HttpPostedFileBase file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblUser sessionUser = (TblUser)Session["UserSession"];
                    objUser.TenantId = sessionUser.TenantId;
                    objUser.CreatedBy = sessionUser.UserId;

                    // objUser.DOB = objUser.DOB;
                    objUser.IsActive = true;
                    int rows = 0;
                    if (file != null)
                    {
                        var profileURL = System.Configuration.ConfigurationManager.AppSettings["ProfileImages"];
                        var profilePhysicalURL = System.Configuration.ConfigurationManager.AppSettings["ProfileImagesPhysicalURL"];

                        if (!System.IO.Directory.Exists(profilePhysicalURL + "\\" + objUser.TenantId))
                        {
                            System.IO.Directory.CreateDirectory(profilePhysicalURL + "\\" + objUser.TenantId);
                        }

                        string filePhysicalPath = System.IO.Path.Combine(profilePhysicalURL + "\\" + objUser.TenantId + "\\" + objUser.UserId + ".jpg");
                        string path = System.IO.Path.Combine(profileURL + "\\" + objUser.TenantId + "\\" + objUser.UserId + ".jpg");
                        file.SaveAs(filePhysicalPath);
                        objUser.profileImage = path;
                    }
                    if (objUser.UserId == 0)
                    {
                        CommonFunctions common = new CommonFunctions();
                        objUser.Password = common.GetEncodePassword("123456");
                        rows = ur.AddUser(objUser);
                    }
                    else
                    {
                        rows = ur.EditUser(objUser);
                        if (objUser.IsMyProfile)
                        {
                            if (!string.IsNullOrEmpty(objUser.OldPassword) && !string.IsNullOrEmpty(objUser.Password))
                            {
                                CommonFunctions common = new CommonFunctions();
                                objUser.OldPassword = common.GetEncodePassword(objUser.OldPassword);
                                objUser.Password = common.GetEncodePassword(objUser.Password);
                                var result = ur.ChangePassword(objUser, objUser.Password);

                            }
                        }
                        if (objUser.IsMyProfile)
                        {
                            var userDetails = ur.GetUserById(objUser.UserId);
                            Session["UserSession"] = userDetails[0];
                            TempData["Message"] = "User Information Saved Successfully";
                            return RedirectToAction("MyProfile", "Account");
                        }
                        

                    }
                    if (objUser.UserId == 0 && rows != 0)
                    {
                        Guid guid = Guid.NewGuid();
                        string token = guid.ToString();
                        var baseURL = System.Configuration.ConfigurationManager.AppSettings["BaseURL"];
                        var url = baseURL + @Url.Action("ChangePassword", "Login", new { t = token });
                        var link = "<a href='" + url + "'>Click Here</a>";
                        var emailBody = "Welcome To LMS. </br> Please click below link to Login </br>";
                        emailBody = emailBody + link;
                        var result = ur.AddToken(objUser.EmailId, token);

                        var emailSubject = System.Configuration.ConfigurationManager.AppSettings["emailSubject"];
                        tblEmails objEmail = new tblEmails();
                        objEmail.EmailTo = objUser.EmailId;
                        objEmail.EmailSubject = emailSubject;
                        objEmail.EmailBody = emailBody;

                        result = ur.InsertEmail(objEmail);

                        TempData["Message"] = "Saved Successfully";
                        if (objUser.IsMyProfile)
                            return RedirectToAction("Index", "Home");
                        else
                            return RedirectToAction("Index");

                    }
                    else
                    {
                        //TempData["Message"] = "Not Saved Successfully";
                        return RedirectToAction("Index");
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                if (objUser.IsMyProfile)
                {
                    return View("Profile", objUser);
                }
                else
                {
                    return View("AddNewUser",objUser);
                }

            }
        }

        public ActionResult EditUser(int id)
        {
            try
            {
                List<TblUser> userDetails = new List<TblUser>();
                userDetails = ur.GetUserById(id);
                TblUser objEditData = new TblUser();
                objEditData = userDetails[0];
                objEditData.UserRoles = rr.GetAllRoles();
                objEditData.Tenants = tr.GetAllTenants();
                objEditData.IsMyProfile = false;
                return View("AddNewUser", objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AddNewUser");
            }
        }

        [HttpPost]
        public ActionResult EditUser(TblUser objUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int rows = ur.EditUser(objUser);
                    if (rows != 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(objUser);
                    }
                }
                return View(objUser);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost, ActionName("DeleteUser")]
        public ActionResult DeleteConfirmUser(int id)
        {
            try
            {
                Response response = new Response();
                List<TblUser> objUserList = ur.GetUserById(id);
                TblUser objUser = objUserList[0];
                if (ModelState.IsValid)
                {
                    if (objUser.IsActive == true)
                    {
                        objUser.IsActive = false;
                    }
                    else
                    {
                        objUser.IsActive = true;
                    }
                    int rows = ur.DeleteUser(objUser);
                    if (rows != 0)
                    {
                        response.StatusCode = 1;

                    }
                    else
                    {
                        response.StatusCode = 0;

                    }
                }

            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Upload()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            return View("UploadUsers", sessionUser);
        }

        public ActionResult UploadUsers(TblUser objUser, HttpPostedFileBase file)
        {
            try
            {
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(file.InputStream))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        if (rows.Length > 1)
                        {
                            DataRow dr = dt.NewRow();
                            for (int i = 0; i < headers.Length; i++)
                            {
                                dr[i] = rows[i].Trim();
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    TblUser sessionUser = (TblUser)Session["UserSession"];
                    objUser.TenantId = sessionUser.TenantId;
                    objUser.CreatedBy = sessionUser.UserId;
                    objUser.RoleId = 3;
                    objUser.IsActive = true;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("</br></br><font color=\"red\"><b>Users below are not imported.</b></font>");
                    int TotalRows = 0;
                    int index = 0;
                    List<string> lstEmailIds = new List<string>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        index++;
                        if (!string.IsNullOrEmpty(Convert.ToString(dr["EmailId"])) && !string.IsNullOrEmpty(Convert.ToString(dr["FirstName"])))
                        {
                            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                            Match match = regex.Match(Convert.ToString(dr["EmailId"]));
                            if (match.Success)
                            {
                                objUser.FirstName = Convert.ToString(dr["FirstName"]);
                                objUser.LastName = Convert.ToString(dr["LastName"]);
                                objUser.EmailId = Convert.ToString(dr["EmailId"]);

                                CommonFunctions common = new CommonFunctions();
                                var result = common.GetEncodePassword("123456");
                                objUser.Password = result;
                                objUser.ContactNo = Convert.ToString(dr["ContactNo"]);
                                int rows = ur.AddUser(objUser);
                                if (rows > 0)
                                {
                                    TotalRows++;
                                    lstEmailIds.Add(objUser.EmailId);
                                }
                                if (rows == 0)
                                {
                                    sb.AppendLine("</br>User at row - " + index + " -  Name" + Convert.ToString(dr["FirstName"]) + " -  EmailId " + Convert.ToString(dr["EmailId"]));
                                    sb.AppendLine("</br>-----------------------------------------------------------------------");

                                }
                                if (rows == -2)
                                {
                                    sb.AppendLine("</br>EmailId " + Convert.ToString(dr["EmailId"]) + "  <b>Already Exist</b>");
                                    sb.AppendLine("</br>-----------------------------------------------------------------------");

                                }
                            }
                            else
                            {
                                sb.AppendLine("</br>EmailId " + Convert.ToString(dr["EmailId"]) + "  <b> is not Valid</b>");
                                sb.AppendLine("</br>-----------------------------------------------------------------------");
                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Convert.ToString(dr["EmailId"])))
                            {
                                sb.AppendLine("</br>User at row - " + index + " -  <b>Email Id</b> is <b>Empty</b>");
                                sb.AppendLine("</br>-----------------------------------------------------------------------");

                            }
                            if (string.IsNullOrEmpty(Convert.ToString(dr["FirstName"])))
                            {
                                sb.AppendLine("</br>User at row - " + index + " -  <b>First Name</b> is <b>Empty</b>");
                                sb.AppendLine("</br>-----------------------------------------------------------------------");

                            }
                        }
                    }
                    StringBuilder sb1 = new StringBuilder();
                    sb1.AppendLine("</br><font color=\"green\"><b>Number of User/s Imported - " + TotalRows + "</b></font>");
                    sb1.AppendLine("</br>-----------------------------------------------------------------------</br>");
                    foreach(var email in lstEmailIds)
                    {
                        sb1.AppendLine("Email Id - " + email + " -  <b>Added</b>");
                    }
                    ViewBag.Log = sb1.ToString() + sb.ToString();

                    //Insert Emails in DB
                    DataTable tbl = new DataTable();
                    tbl.Columns.Add(new DataColumn("EmailTo", typeof(string)));
                    tbl.Columns.Add(new DataColumn("EmailSubject", typeof(string)));
                    tbl.Columns.Add(new DataColumn("EmailBody", typeof(string)));
                    tbl.Columns.Add(new DataColumn("DateCreated", typeof(DateTime)));
                    tbl.Columns.Add(new DataColumn("isSent", typeof(bool)));
                    tbl.Columns.Add(new DataColumn("DateSent", typeof(DateTime)));
                    tbl.Columns.Add(new DataColumn("SentStatus", typeof(string)));

                    var emailSubject = System.Configuration.ConfigurationManager.AppSettings["emailSubject"];

                    foreach (var email in lstEmailIds)
                    {
                        Guid guid = Guid.NewGuid();
                        string token = guid.ToString();
                        var baseURL = System.Configuration.ConfigurationManager.AppSettings["BaseURL"];
                        var url = baseURL + @Url.Action("ChangePassword", "Login", new { t = token });
                        var link = "<a href='" + url + "'>Click Here</a>";
                        var emailBody = "Welcome To LMS. </br> Please click below link to Login </br>";
                        emailBody = emailBody + link;
                        var result = ur.AddToken(email, token);
                        DataRow dr = tbl.NewRow();
                        dr["EmailTo"] = email;
                        dr["EmailSubject"] = emailSubject;
                        dr["EmailBody"] = emailBody;
                        dr["DateCreated"] = DateTime.Now;
                        dr["isSent"] = 0;
                        dr["DateSent"] = DBNull.Value;
                        dr["SentStatus"] = null;

                        tbl.Rows.Add(dr);
                    }

                    int addedRows = ur.InsertEmails(tbl);
                }
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                TempData["Message"] = "There is some problem in Importing Users. Please contact Support Administrator";
                return View("UploadUsers");
            }

            return View("UploadUsers");
        }

    }
}