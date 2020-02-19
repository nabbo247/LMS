<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateLMS.aspx.cs" Inherits="HRS.CoursePlayer.UpdateLMS" 
    ValidateRequest="false" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>Content Frame</title>
        <script language="javascript" type="text/javascript">
            function callAlert() {
               
            }
            function CloseCoursePlayer() {
                alert('Your session has been expired');
                debugger;
               parent.parent.DefaultContentFrame.ShowSessionAlert();
            }
        </script>
</head>
<body bgcolor="#ffffff" onunload="setTimeout('callAlert();', 500);">
    <form name="formMain" id="formMain" method="get" runat="server"> 
              
         <input type="hidden" name="TARecords" id="TARecords" />      
         <asp:HiddenField ID="hdnCount" runat="server" />
         <asp:HiddenField ID="hdnScriptRegCount" runat="server" />
        <asp:HiddenField ID="hdnContentModuleId" runat="server" />
        <asp:HiddenField ID="hdnContentModuleIdIsA" runat="server" />
        <asp:HiddenField ID="hdnUserId" runat="server" />      
          <asp:HiddenField ID="hdnClientId" runat="server" />
         <asp:HiddenField ID="hdnCStartDate" runat="server" />
    </form>
</body>
</html>
