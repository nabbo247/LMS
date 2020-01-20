﻿using System;
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
                newException.AddDummyException("111");
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
                return View(objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddUser(TblUser objUser)
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
                    if (objUser.UserId == 0)
                    {
                        CommonFunctions common = new CommonFunctions();
                        objUser.Password = common.GetEncodePassword("123456");
                        rows = ur.AddUser(objUser);
                    }
                    else
                        rows = ur.EditUser(objUser);
                    if (rows != 0)
                    {
                        TempData["Message"] = "Saved Successfully";
                        if (objUser.IsMyProfile)
                            return RedirectToAction("Index", "Home");
                        else
                            return RedirectToAction("Index");

                    }
                    else
                    {
                        TempData["Message"] = "Not Saved Successfully";
                        return View(objUser);
                    }
                }
                return View(objUser);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View(objUser);
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
                return View("AddUser", objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
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
                        //return RedirectToAction("Index");
                    }
                    else
                    {
                        response.StatusCode = 0;
                        //return View(objUser);
                    }
                }
                //return View(objTenant);
                return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult Upload()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            return View(sessionUser);
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
                    sb.Append("</br><font color=\"red\"><b>Users below are not imported.</b></font>");
                    int TotalRows = 0;
                    int index = 0;
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
                    ViewBag.Log = sb1.ToString() + sb.ToString();
                }
            }
            catch(Exception ex)
            {
                newException.AddException(ex);
                TempData["Message"] = "There is some problem in Importing Users. Please contact Support Administrator";
                return View("Upload");
            }

            return View("Upload");
        }
    }
}