<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionPoller.aspx.cs" Inherits="HRS.CoursePlayer.SessionPoller" %>
<!DOCTYPE html>
<html lang="en">
<head id="Head1" runat="server">
    <script language="javascript" type="text/javascript"  >
    function fnSetSessionPoller(gTimeInterval_Home)
    {
      if(gTimeInterval_Home > (60000*2)) //i.e 60 sec
      {
            window.setInterval("sendRequest('SessionPoller.aspx?SessionTimeOut="+gTimeInterval_Home+"')", (gTimeInterval_Home -(60000*2)))
      }
      else
      {
            window.setInterval("sendRequest('SessionPoller.aspx?SessionTimeOut="+gTimeInterval_Home+"')", (60000*2))
      }
    }
    function sendRequest(sPath)
    {
        window.location.href =sPath; 
    }
    </script>
</head>
<body runat="server" id="bodyMain" >
    <form id="form1" runat="server"></form>
</body>
</html>
