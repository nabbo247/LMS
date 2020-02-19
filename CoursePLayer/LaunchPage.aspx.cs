using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;
namespace HRS.CoursePlayer
{
    public partial class LaunchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["FN"]!=null && Session["LN"]!=null)
            {
                CheckNAssign_session();
            }
         
        }
        protected void btnDoIt_Click(object sender, EventArgs e)
        {

            CheckNAssign();
        }
        public void CheckNAssign()
        {
            SqlConnection oSQLConn = new SqlConnection();
            SqlCommand oSQLCommand = new SqlCommand();
            SqlDataReader sdr;
            String Id = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class=\"records_table\">");
            sb.Append("<tr class=\"tableHead\">");
            sb.Append("<td>Sr No.</td><td>Course Name</td><td>Assignment Date</td><td>Started Date</td><td>Completion Date</td><td>Completion Status</td><td>Score</td><td>Pass/Fail Status</td><td>Link</td>");
            sb.Append("</tr>");
            //sb.Append("</table>");
            string sFirstName = null;
            string sLastName = null;
            string sCourseName = null;
            string sCourseId = null;
            string sAssignmentDate = null;
            string sCompletionStatus = null;
            string sDateOfStart = null;
            string sDateOfCompletion = null;
            string sPassFailStatus = "";
            string sScore = "";

            bool bLaunch = false;
            oSQLConn.ConnectionString = ConfigurationManager.AppSettings["ConnString"];

            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtFirstName.Text.Trim()))
                {
                    mesg.Text = "First Name or LastName should not be empty";
                }
                else
                {
                    sFirstName = txtFirstName.Text.Trim();
                    sLastName = txtLastName.Text.Trim();
                    Session["FN"] = sFirstName;
                    Session["LN"] = sLastName;
                    oSQLConn.Open();
                    oSQLCommand.Connection = oSQLConn;
                    oSQLCommand.CommandType = CommandType.StoredProcedure;
                    oSQLCommand.CommandText = "ChecknCreate";

                    //Id = Guid.NewGuid().ToString();

                    SqlParameter param;
                    // param 1
                    //param = new SqlParameter("@Id", Id);
                    //param.SqlDbType = SqlDbType.VarChar;
                    //param.Size = 100;

                    //oSQLCommand.Parameters.Add(param);
                    // param 2
                    param = new SqlParameter("@FirstName", sFirstName);
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    oSQLCommand.Parameters.Add(param);
                    // param 3
                    param = new SqlParameter("@LastName", sLastName);
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    oSQLCommand.Parameters.Add(param);
                    sdr = oSQLCommand.ExecuteReader();
                    int i = 1;
                    if (sdr != null)
                    {
                        if (sdr.HasRows)
                        {


                            while (sdr.Read())
                            {
                                Id = Convert.ToString(sdr.GetSqlValue(0));
                                sFirstName = Convert.ToString(sdr.GetSqlValue(1));
                                sLastName = Convert.ToString(sdr.GetSqlValue(2));
                                sAssignmentDate = Convert.ToString(sdr.GetSqlValue(3));
                                sCourseName = Convert.ToString(sdr.GetSqlValue(4));
                                sCourseId = Convert.ToString(sdr.GetSqlValue(5));
                                sCompletionStatus = Convert.ToString(sdr.GetSqlValue(6));
                                if (Convert.ToString(sdr.GetSqlValue(7)) == "Null")
                                {
                                    sDateOfStart = "";
                                }
                                else
                                {
                                    sDateOfStart = Convert.ToString(sdr.GetSqlValue(7));
                                }
                                if (Convert.ToString(sdr.GetSqlValue(8)) == "Null")
                                {
                                    sDateOfCompletion = "";
                                }
                                else
                                {
                                    sDateOfCompletion = Convert.ToString(sdr.GetSqlValue(8));
                                }


                                if (Convert.ToString(sdr.GetSqlValue(9)) == "Null")
                                {
                                    sScore = "";
                                }
                                else
                                {
                                    sScore = Convert.ToString(sdr.GetSqlValue(9));
                                }
                                if (Convert.ToString(sdr.GetSqlValue(10)) == "Null")
                                {
                                    sPassFailStatus = "";
                                }
                                else
                                {
                                    sPassFailStatus = Convert.ToString(sdr.GetSqlValue(10));
                                }

                                sb.Append("<tr class=\"allrecords\">");
                                sb.Append("<td>" + i.ToString() + "</td>");
                                sb.Append("<td>" + sCourseName + "</td>");
                                sb.Append("<td>" + sAssignmentDate + "</td>");
                                sb.Append("<td>" + sDateOfStart + "</td>");
                                sb.Append("<td>" + sDateOfCompletion + "</td>");
                                sb.Append("<td>" + sCompletionStatus + "</td>");                                sb.Append("<td>" + sScore + "</td>");
                                sb.Append("<td>" + sPassFailStatus + "</td>");
                                sb.Append("<td><a href=\"javascript:LaunchCourse('" + sCourseId + "','" + Id + "')\">Launch</a></td>");
                                sb.Append("</tr>");

                                //bLaunch = true;

                            }
                        }
                        else
                        {
                            mesg.Text = "record not added or retrieved!";
                        }
                    }
                    else
                    {
                        mesg.Text = "record not added or retrieved!";
                    }
                    sb.Append("</table>");
                    divAssignmentTable.InnerHtml = sb.ToString();
                }

            }
            catch (Exception ex)
            {
                mesg.Text = "Error Occured:" + ex.Message;
            }
            finally
            {
                if (oSQLConn.State == ConnectionState.Open)
                {
                    oSQLConn.Close();
                }
                oSQLConn.Dispose();
            }

            //if (bLaunch)
            //{
            //    LaunchCourse(Id, sFirstName, sLastName);
            //}
        }

        public void CheckNAssign_session()
        {
            SqlConnection oSQLConn = new SqlConnection();
            SqlCommand oSQLCommand = new SqlCommand();
            SqlDataReader sdr;
            String Id = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class=\"records_table\">");
            sb.Append("<tr class=\"tableHead\">");
            sb.Append("<td>Sr No.</td><td>Course Name</td><td>Assignment Date</td><td>Started Date</td><td>Completion Date</td><td>Completion Status</td><td>Score</td><td>Pass/Fail Status</td><td>Link</td>");
            sb.Append("</tr>");
            //sb.Append("</table>");
            string sFirstName = null;
            string sLastName = null;
            string sCourseName = null;
            string sCourseId = null;
            string sAssignmentDate = null;
            string sCompletionStatus = null;
            string sDateOfStart = null;
            string sDateOfCompletion = null;
            string sPassFailStatus = "";
            string sScore = "";

            bool bLaunch = false;
            oSQLConn.ConnectionString = ConfigurationManager.AppSettings["ConnString"];

            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtFirstName.Text.Trim()))
                {
                    mesg.Text = "First Name or LastName should not be empty";
                }
                else
                {
                    sFirstName = Session["FN"].ToString();
                    sLastName = Session["LN"].ToString();
                    oSQLConn.Open();
                    oSQLCommand.Connection = oSQLConn;
                    oSQLCommand.CommandType = CommandType.StoredProcedure;
                    oSQLCommand.CommandText = "ChecknCreate";

                    //Id = Guid.NewGuid().ToString();

                    SqlParameter param;
                    // param 1
                    //param = new SqlParameter("@Id", Id);
                    //param.SqlDbType = SqlDbType.VarChar;
                    //param.Size = 100;

                    //oSQLCommand.Parameters.Add(param);
                    // param 2
                    param = new SqlParameter("@FirstName", sFirstName);
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    oSQLCommand.Parameters.Add(param);
                    // param 3
                    param = new SqlParameter("@LastName", sLastName);
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    oSQLCommand.Parameters.Add(param);
                    sdr = oSQLCommand.ExecuteReader();
                    int i = 1;
                    if (sdr != null)
                    {
                        if (sdr.HasRows)
                        {


                            while (sdr.Read())
                            {
                                Id = Convert.ToString(sdr.GetSqlValue(0));
                                sFirstName = Convert.ToString(sdr.GetSqlValue(1));
                                sLastName = Convert.ToString(sdr.GetSqlValue(2));
                                sAssignmentDate = Convert.ToString(sdr.GetSqlValue(3));
                                sCourseName = Convert.ToString(sdr.GetSqlValue(4));
                                sCourseId = Convert.ToString(sdr.GetSqlValue(5));
                                sCompletionStatus = Convert.ToString(sdr.GetSqlValue(6));
                                if (Convert.ToString(sdr.GetSqlValue(7)) == "Null")
                                {
                                    sDateOfStart = "";
                                }
                                else
                                {
                                    sDateOfStart = Convert.ToString(sdr.GetSqlValue(7));
                                }
                                if (Convert.ToString(sdr.GetSqlValue(8)) == "Null")
                                {
                                    sDateOfCompletion = "";
                                }
                                else
                                {
                                    sDateOfCompletion = Convert.ToString(sdr.GetSqlValue(8));
                                }

                                if (Convert.ToString(sdr.GetSqlValue(9)) == "Null")
                                {
                                    sScore = "";
                                }
                                else
                                {
                                    sScore = Convert.ToString(sdr.GetSqlValue(9));
                                }
                                if (Convert.ToString(sdr.GetSqlValue(10)) == "Null")
                                {
                                    sPassFailStatus = "";
                                }
                                else
                                {
                                    sPassFailStatus = Convert.ToString(sdr.GetSqlValue(10));
                                }

                                
                                

                                sb.Append("<tr class=\"allrecords\">");
                                sb.Append("<td>" + i.ToString() + "</td>");
                                sb.Append("<td>" + sCourseName + "</td>");
                                sb.Append("<td>" + sAssignmentDate + "</td>");
                                sb.Append("<td>" + sDateOfStart + "</td>");
                                sb.Append("<td>" + sDateOfCompletion + "</td>");
                                sb.Append("<td>" + sCompletionStatus + "</td>");
                                sb.Append("<td>" + sScore + "</td>");
                                sb.Append("<td>" + sPassFailStatus + "</td>");
                                sb.Append("<td><a href=\"javascript:LaunchCourse('" + sCourseId + "','" + Id + "')\">Launch</a></td>");
                                sb.Append("</tr>");

                                //bLaunch = true;

                            }
                        }
                        else
                        {
                            mesg.Text = "record not added or retrieved!";
                        }
                    }
                    else
                    {
                        mesg.Text = "record not added or retrieved!";
                    }
                    sb.Append("</table>");
                    divAssignmentTable.InnerHtml = sb.ToString();
                }

            }
            catch (Exception ex)
            {
                mesg.Text = "Error Occured:" + ex.Message;
            }
            finally
            {
                if (oSQLConn.State == ConnectionState.Open)
                {
                    oSQLConn.Close();
                }
                oSQLConn.Dispose();
            }

            //if (bLaunch)
            //{
            //    LaunchCourse(Id, sFirstName, sLastName);
            //}
        }


    }
}