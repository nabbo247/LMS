using LMSWeb.ViewModel;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using ClosedXML.Excel;
using System.IO;

namespace LMSWeb.Controllers
{
    public class ReportsController : Controller
    {
        UserRepository userRepository = new UserRepository();
        QuizRepository quizRepository = new QuizRepository();
        ReportRepository rpt = new ReportRepository();
        Exceptions newException = new Exceptions();
        // GET: Reports
        public ActionResult Index()
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                var objReportModel = rpt.GetMainReportForLearner(sessionUser.UserId, sessionUser.TenantId);
                return View("LearnerReportMain", objReportModel);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("LearnerReportMain");
            }
        }

        public ActionResult DetailReport(int activityId)
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                var attemptList = rpt.GetDetailReportForLearner(sessionUser.UserId, sessionUser.TenantId, activityId);
                return View(attemptList);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult AttemptReport(int activityId, int attempt)
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
                lstAllQuiz = quizRepository.GetQuizForLaunch(activityId, sessionUser.UserId);
                //var attempt = quizRepository.GetQuizAttemptByUserID(activityId, sessionUser.UserId);
                List<TblRespons> quizResponses = new List<TblRespons>();
                quizResponses = quizRepository.GetQuizResponsesByUserID(activityId, sessionUser.UserId, attempt);
                lstAllQuiz[0].TblResponses = quizResponses;

                var score = quizRepository.GetQuizScoreByUserID(activityId, sessionUser.UserId, attempt);
                lstAllQuiz[0].Score = Convert.ToInt32(score.Score);
                lstAllQuiz[0].completeTime = score.completedTime;

                JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                lstAllQuiz[0].hdnReviewData = json_serializer.Serialize(lstAllQuiz[0]);
                //var attemptList = rpt.GetDetailReportForLearner(sessionUser.UserId, sessionUser.TenantId, activityId);
                return View("AttemptReport", lstAllQuiz[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AttemptReport");
            }
        }
        public ActionResult ViewQuiz(int quizId, int userId, int attempt)
        {
            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
            lstAllQuiz = quizRepository.GetQuizForLaunch(quizId, userId);

            List<TblRespons> quizResponses = new List<TblRespons>();
            quizResponses = quizRepository.GetQuizResponsesByUserID(quizId, userId, attempt);
            lstAllQuiz[0].TblResponses = quizResponses;

            var score = quizRepository.GetQuizScoreByUserID(quizId, userId, attempt);
            lstAllQuiz[0].Score = Convert.ToInt32(score.Score);

            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            lstAllQuiz[0].hdnReviewData = json_serializer.Serialize(lstAllQuiz[0]);
            return View(lstAllQuiz[0]);

        }

        public ActionResult DeleteQuiz(int quizId, int userId, int attempt)
        {
            int result = quizRepository.DeleteResponse(quizId, userId, attempt);
            return RedirectToAction("Index");
        }

        public ActionResult AllReports()
        {

            return View();
        }

        public ActionResult UserReport(string isActive)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<UserReportModel> objUserList = new List<UserReportModel>();
            objUserList = rpt.GetUserReportForAdmin(sessionUser.TenantId, Convert.ToBoolean(isActive));
            return View(objUserList);
        }

        public ActionResult UserProgressReport(int UserId)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<UserProgressReportModel> objUserList = new List<UserProgressReportModel>();
            objUserList = rpt.GetUserProgressReportForAdmin(sessionUser.TenantId, UserId);
            return View(objUserList);
        }

        public ActionResult LearningCompletionReport()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<LearningCompletionReportModel> objUserList = new List<LearningCompletionReportModel>();
            objUserList = rpt.GetLearningCompletionReportForAdmin(sessionUser.TenantId);
            return View(objUserList);
        }

        public ActionResult LearningProgressCompletionReport(int ActivityId, string Type)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<LearningCompletionProgressReportModel> objUserList = new List<LearningCompletionProgressReportModel>();
            objUserList = rpt.GetLearningCompletionProgressReportForAdmin(sessionUser.TenantId, ActivityId, Type);
            return View(objUserList);
        }

        public ActionResult HighScoreUsersReport()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];

            List<HighScoreUsersReportModel> objUserList = new List<HighScoreUsersReportModel>();
            var objReportData = rpt.GetHighScoreUsersReportForAdmin(sessionUser.TenantId);
            return View(objReportData);
        }

        public ActionResult ExportToExcel(string isActive, string ReportName, string UserId, string ActivityId, string Type)
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                
                System.Data.DataTable table = new System.Data.DataTable();

                if (!string.IsNullOrEmpty(isActive))
                {
                    List<UserReportModel> objUserList = new List<UserReportModel>();
                    objUserList = rpt.GetUserReportForAdmin(sessionUser.TenantId, Convert.ToBoolean(isActive));
                    if (isActive == "True")
                    {
                        //excelSheet.Name = "Active User Report";
                        ReportName = "Active User Report";
                    }
                    else
                    {
                        //excelSheet.Name = "Total User Report";
                        ReportName = "Total User Report";
                    }

                    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(UserReportModel));
                    foreach (PropertyDescriptor prop in properties)
                        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                    foreach (UserReportModel item in objUserList)
                    {
                        DataRow row = table.NewRow();
                        foreach (PropertyDescriptor prop in properties)
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                        table.Rows.Add(row);
                    }
                    table.Columns.Remove("UserId");
                    
                }
                if (ReportName == "User Progress Report")
                {
                    List<UserProgressReportModel> objUserList = new List<UserProgressReportModel>();
                    objUserList = rpt.GetUserProgressReportForAdmin(sessionUser.TenantId, Convert.ToInt32(UserId));

                    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(UserProgressReportModel));
                    foreach (PropertyDescriptor prop in properties)
                        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                    foreach (UserProgressReportModel item in objUserList)
                    {
                        DataRow row = table.NewRow();
                        foreach (PropertyDescriptor prop in properties)
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                        table.Rows.Add(row);
                    }
                    table.Columns.Remove("ActivityId");
                    foreach (DataRow dr in table.Rows)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(dr["Comments"])))
                        {
                            dr["Comments"] = dr["Comments"].ToString().Replace("#;;#", "\n");
                        }
                    }
                }
                if (ReportName == "Learning Completion Report")
                {
                    List<LearningCompletionReportModel> objUserList = new List<LearningCompletionReportModel>();
                    objUserList = rpt.GetLearningCompletionReportForAdmin(sessionUser.TenantId);

                    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(LearningCompletionReportModel));
                    foreach (PropertyDescriptor prop in properties)
                        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                    foreach (LearningCompletionReportModel item in objUserList)
                    {
                        DataRow row = table.NewRow();
                        foreach (PropertyDescriptor prop in properties)
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                        table.Rows.Add(row);
                    }
                    table.Columns.Remove("ActivityId");
                }
                if (ReportName == "Learning Progress Report")
                {
                    List<LearningCompletionProgressReportModel> objUserList = new List<LearningCompletionProgressReportModel>();
                    objUserList = rpt.GetLearningCompletionProgressReportForAdmin(sessionUser.TenantId, Convert.ToInt32(ActivityId), Type);

                    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(LearningCompletionProgressReportModel));
                    foreach (PropertyDescriptor prop in properties)
                        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                    foreach (LearningCompletionProgressReportModel item in objUserList)
                    {
                        DataRow row = table.NewRow();
                        foreach (PropertyDescriptor prop in properties)
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                        table.Rows.Add(row);
                    }
                    foreach (DataRow dr in table.Rows)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(dr["Comments"])))
                        {
                            dr["Comments"] = dr["Comments"].ToString().Replace("#;;#", "\n");
                        }
                    }
                }


                if (ReportName == "High Score Users Report")
                {
                    List<HighScoreUsersReportModel> objUserList = new List<HighScoreUsersReportModel>();
                    var objReportData = rpt.GetHighScoreUsersReportForAdmin(sessionUser.TenantId);

                    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HighScoreUsersReportModel));
                    foreach (PropertyDescriptor prop in properties)
                        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                    foreach (HighScoreUsersReportModel item in objReportData)
                    {
                        DataRow row = table.NewRow();
                        foreach (PropertyDescriptor prop in properties)
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                        table.Rows.Add(row);
                    }
                    table.Columns.Remove("TotalQuestion");
                }

                string fileName = ReportName + ".xlsx";
                using (XLWorkbook wb = new XLWorkbook())
                {

                    //excelSheet.Name
                    table.TableName = ReportName;
                    wb.Worksheets.Add(table);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return null;
            }
        }

        public ActionResult ExportToPdf(string isActive, string ReportName, string UserId, string ActivityId, string Type)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];

            System.Data.DataTable table = new System.Data.DataTable();

            if (!string.IsNullOrEmpty(isActive))
            {
                List<UserReportModel> objUserList = new List<UserReportModel>();
                objUserList = rpt.GetUserReportForAdmin(sessionUser.TenantId, Convert.ToBoolean(isActive));
                if (isActive == "True")
                {
                    ReportName = "Active User Report";
                }
                else
                {
                    ReportName = "Total User Report";
                }

                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(UserReportModel));
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                foreach (UserReportModel item in objUserList)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                    table.Rows.Add(row);
                }
                table.Columns.Remove("UserId");
            }
            if (ReportName == "User Progress Report")
            {
                List<UserProgressReportModel> objUserList = new List<UserProgressReportModel>();
                objUserList = rpt.GetUserProgressReportForAdmin(sessionUser.TenantId, Convert.ToInt32(UserId));

                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(UserProgressReportModel));
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                foreach (UserProgressReportModel item in objUserList)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                    table.Rows.Add(row);
                }
                table.Columns.Remove("ActivityId");
                foreach (DataRow dr in table.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(dr["Comments"])))
                    {
                        dr["Comments"] = dr["Comments"].ToString().Replace("#;;#", "\n");
                    }
                }
            }
            if (ReportName == "Learning Completion Report")
            {
                List<LearningCompletionReportModel> objUserList = new List<LearningCompletionReportModel>();
                objUserList = rpt.GetLearningCompletionReportForAdmin(sessionUser.TenantId);

                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(LearningCompletionReportModel));
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                foreach (LearningCompletionReportModel item in objUserList)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                    table.Rows.Add(row);
                }
                table.Columns.Remove("ActivityId");
            }
            if (ReportName == "Learning Progress Report")
            {
                List<LearningCompletionProgressReportModel> objUserList = new List<LearningCompletionProgressReportModel>();
                objUserList = rpt.GetLearningCompletionProgressReportForAdmin(sessionUser.TenantId, Convert.ToInt32(ActivityId), Type);

                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(LearningCompletionProgressReportModel));
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                foreach (LearningCompletionProgressReportModel item in objUserList)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                    table.Rows.Add(row);
                }
                foreach (DataRow dr in table.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(dr["Comments"])))
                    {
                        dr["Comments"] = dr["Comments"].ToString().Replace("#;;#", "\n");
                    }
                }
            }

            if (ReportName == "High Score Users Report")
            {
                List<HighScoreUsersReportModel> objUserList = new List<HighScoreUsersReportModel>();
                var objReportData = rpt.GetHighScoreUsersReportForAdmin(sessionUser.TenantId);

                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HighScoreUsersReportModel));
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

                foreach (HighScoreUsersReportModel item in objReportData)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                    table.Rows.Add(row);
                }
                table.Columns.Remove("TotalQuestion");
            }

            // creating document object  
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            iTextSharp.text.Rectangle rec = new iTextSharp.text.Rectangle(PageSize.LETTER);
            rec.BackgroundColor = new BaseColor(System.Drawing.Color.Olive);
            Document doc = new Document(rec);
            doc.SetPageSize(iTextSharp.text.PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, ms);
            doc.Open();

            //Creating paragraph for header  
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.ORANGE);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(ReportName.ToUpper(), fntHead));
            doc.Add(prgHeading);

            //Adding paragraph for report generated by  
            Paragraph prgGeneratedBY = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, iTextSharp.text.BaseColor.BLUE);
            prgGeneratedBY.Alignment = Element.ALIGN_RIGHT;
            //prgGeneratedBY.Add(new Chunk("Report Generated by : ASPArticles", fntAuthor));  
            //prgGeneratedBY.Add(new Chunk("\nGenerated Date : " + DateTime.Now.ToShortDateString(), fntAuthor));  
            doc.Add(prgGeneratedBY);

            //Adding a line  
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            doc.Add(p);

            //Adding line break  
            doc.Add(new Chunk("\n", fntHead));

            //Adding  PdfPTable  
            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
            pdfTable.WidthPercentage = 100;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                string cellText = Server.HtmlDecode(table.Columns[i].ColumnName);
                PdfPCell cell = new PdfPCell();
                cell.Phrase = new Phrase(cellText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, 1, new BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                cell.BackgroundColor = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#C8C8C8"));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.PaddingBottom = 5;
                //cell.Width = 80f;
                pdfTable.AddCell(cell);
            }

            //writing table Data  
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    pdfTable.AddCell(table.Rows[i][j].ToString());
                }
            }

            doc.Add(pdfTable);
            doc.Close();
            byte[] result = ms.ToArray();

            string filename = ReportName + ".pdf";
            return File(result, "application/pdf", filename);


        }

        [HttpPost]
        public ActionResult GetFilteredData(string isActive, string fDate, string tDate, string ReportName, string UserId, string ActivityId, string type)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            if (ReportName == "UserReport")
            {
                List<UserReportModel> objUserList = new List<UserReportModel>();
                objUserList = rpt.GetUserReportForAdmin(sessionUser.TenantId, Convert.ToBoolean(isActive));
                if (!string.IsNullOrEmpty(fDate) && !string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.DateCreated != "" && Convert.ToDateTime(x.DateCreated) >= Convert.ToDateTime(fDate) && Convert.ToDateTime(x.DateCreated) <= Convert.ToDateTime(tDate)).ToList();
                }
                else if (!string.IsNullOrEmpty(fDate))
                {
                    objUserList = objUserList.Where(x => x.DateCreated != "" && Convert.ToDateTime(x.DateCreated) >= Convert.ToDateTime(fDate)).ToList();
                }
                else if (!string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.DateCreated != "" && Convert.ToDateTime(x.DateCreated) <= Convert.ToDateTime(tDate)).ToList();
                }

                return PartialView("_UserReportList", objUserList);
            }

            if (ReportName == "UserProgressReport")
            {
                List<UserProgressReportModel> objUserList = new List<UserProgressReportModel>();
                objUserList = rpt.GetUserProgressReportForAdmin(sessionUser.TenantId, Convert.ToInt32(UserId));

                if (!string.IsNullOrEmpty(fDate) && !string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.AttemptedOn != "" && (Convert.ToDateTime(x.AttemptedOn) >= Convert.ToDateTime(fDate) && Convert.ToDateTime(x.AttemptedOn) <= Convert.ToDateTime(tDate))).ToList();
                }
                else if (!string.IsNullOrEmpty(fDate))
                {
                    objUserList = objUserList.Where(x => x.AttemptedOn != "" && Convert.ToDateTime(x.AttemptedOn) >= Convert.ToDateTime(fDate)).ToList();
                }
                else if (!string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.AttemptedOn != "" && Convert.ToDateTime(x.AttemptedOn) <= Convert.ToDateTime(tDate)).ToList();
                }
                return PartialView("_UserProgressReportList", objUserList);
            }
            if (ReportName == "LearningCompletionReport")
            {
                List<LearningCompletionReportModel> objUserList = new List<LearningCompletionReportModel>();
                objUserList = rpt.GetLearningCompletionReportForAdmin(sessionUser.TenantId);
                if (!string.IsNullOrEmpty(fDate) && !string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.ActivityLearningAssigned != "" && (Convert.ToDateTime(x.ActivityLearningAssigned) >= Convert.ToDateTime(fDate) && Convert.ToDateTime(x.ActivityLearningAssigned) <= Convert.ToDateTime(tDate))).ToList();
                }
                else if (!string.IsNullOrEmpty(fDate))
                {
                    objUserList = objUserList.Where(x => x.ActivityLearningAssigned != "" && Convert.ToDateTime(x.ActivityLearningAssigned) >= Convert.ToDateTime(fDate)).ToList();
                }
                else if (!string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.ActivityLearningAssigned != "" && Convert.ToDateTime(x.ActivityLearningAssigned) <= Convert.ToDateTime(tDate)).ToList();
                }

                return PartialView("_LearningCompletionReportList", objUserList);
            }
            if (ReportName == "LearningProgressReport")
            {
                List<LearningCompletionProgressReportModel> objUserList = new List<LearningCompletionProgressReportModel>();
                objUserList = rpt.GetLearningCompletionProgressReportForAdmin(sessionUser.TenantId, Convert.ToInt32(ActivityId), type);
                if (!string.IsNullOrEmpty(fDate) && !string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.CompletionDate != "" && (Convert.ToDateTime(x.CompletionDate) >= Convert.ToDateTime(fDate) && Convert.ToDateTime(x.CompletionDate) <= Convert.ToDateTime(tDate))).ToList();
                }
                else if (!string.IsNullOrEmpty(fDate))
                {
                    objUserList = objUserList.Where(x => x.CompletionDate != "" && Convert.ToDateTime(x.CompletionDate) >= Convert.ToDateTime(fDate)).ToList();
                }
                else if (!string.IsNullOrEmpty(tDate))
                {
                    objUserList = objUserList.Where(x => x.CompletionDate != "" && Convert.ToDateTime(x.CompletionDate) <= Convert.ToDateTime(tDate)).ToList();
                }

                return PartialView("_LearningProgressReportList", objUserList);
            }

            return null;
        }
    }
}