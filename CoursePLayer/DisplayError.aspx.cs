

using System;

public partial class DisplayError : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["error"] == "SessionTimeout")
        {
            errorHeader.InnerText = "Session Timeout";
            errorText.InnerText = "Your session has expired.";
            errorDescription.InnerText = "Please return to your home page and sign in again.";
        }
    }
}
