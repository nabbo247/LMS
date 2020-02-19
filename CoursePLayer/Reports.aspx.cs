using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace HRS.CoursePlayer
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvBind(); //Bind gridview
            }
        }

        public void gvBind()
        {
            SqlConnection oSQLConn = new SqlConnection();
            oSQLConn.ConnectionString = ConfigurationManager.AppSettings["ConnString"];
            string sQuery = "Select aa.*, " +
	                " Isnull(CompletionStatus,'Not Started') CompletionStatus, " +
                    " IsNull(LCMT.DateOfStart,null) DateOfStart," +
                    " IsNull(LCMT.DateOfCompletion,null) DateOfCompletion," +
                    " Score, PassFailStatus, UserDataXML" +
	                " from (Select LG.LearnerId,FirstName,LastName,LAA.AssignmentDate,CMG.ContentModuleName,CMG.ContentModuleId from tblUser LG inner join " +
                    " tblLearnerActivityAssignment LAA on LG.LearnerId = LAA.LearnerId inner join " +
	                " tblScorm CMG on CMG.ContentModuleId = LAA.ActivityId) " +
                    " aa left outer join tblLearnerContentModTracking LCMT on aa.LearnerId = LCMT.LearnerId and aa.ContentModuleId = LCMT.ContentModuleId" +
	                " order by FirstName + ' '+ LastName,ContentModuleName";

            SqlDataAdapter dap = new SqlDataAdapter(sQuery, oSQLConn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            mygrid.DataSource = ds.Tables[0];
            mygrid.DataBind();
        }

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            mygrid.PageIndex = e.NewPageIndex;
            gvBind();
        }
    }
}