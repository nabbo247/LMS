<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LMSExitPlayer.aspx.cs"
    Inherits="HRS.CoursePlayer.LMSExitPlayer" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title>Untitled Page</title>
    <script language="javascript" type="text/javascript">
    function fnExitContentPlayer(AllowTimer)
    {
        //if timer is required.
        if(AllowTimer)
            parent.setTimer();
       
       // parent.clearTimeout(timer);
    }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <table width="100%">
        <tr runat="server" id="trClient">
            <td align="right">
                <%--<asp:Button runat="server" Text=" Back To Menu " ID="btnExitClient" OnClientClick="javascript:fnExitContentPlayer(false);" />--%>
                <asp:Button runat="server" Text=" Back To Home " ID="btnExitServer" OnClick="btnExitServer_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
