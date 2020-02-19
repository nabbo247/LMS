<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaunchPage.aspx.cs" Inherits="UPSFreight.LaunchPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Launch Page</title>
    <style>
        .records_table {
        border:1px solid #CECECE;      
        
        }
        .tableHead {
        background-color:#CECECE;
        
        }
        .allrecords {
        background-color:#F0F0F0;
        
        }
    </style>
    <script type="text/javascript">
        var newwindow;
        function LaunchCourse(AID, LID)
        {
            
            newwindow = window.open('<%=System.Configuration.ConfigurationManager.AppSettings["sAppUrl"]+System.Configuration.ConfigurationManager.AppSettings["Launchlink"] %>?AID=' + AID + '&LID=' + LID + '&SameWindow=false&RetURL=/LaunchPage.aspx', 'SP', 'width=1024, height=800');
            beginPopupMonitoring();
        }

        function beginPopupMonitoring() {
            setInterval("isPopOpen()", 1000);
        }
        function isPopOpen() {
            
            try {
                if (newwindow && !newwindow.closed)
                {
                    //alert('open window');
                }
                else
                {
                    document.forms[0].submit();
                    //window.location.href = "LaunchPage.aspx";
                }
            }
            catch (e) {
                alert('Error:' + e.message);
                return;
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="mesg" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <div><asp:Label ID="lblFirstName" runat="server" Text="First Name:"></asp:Label></div>
            <asp:TextBox ID="txtFirstName" runat="server" Text=""></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please enter first name" Display="Static"></asp:RequiredFieldValidator>
        </div>

        <div>
            <div><asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label></div>
            <asp:TextBox ID="txtLastName" runat="server" Text=""></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Please enter last name" Display="Static"></asp:RequiredFieldValidator>
        </div>
    <div>
        <asp:Button ID="btnDoIt" runat="server" Text="Enter" OnClick="btnDoIt_Click" />
        <%--<input type="button" name="btnLaunch" value="Launch Course" onclick="javascript: LaunchCourse();" />--%>
    </div>
        <div id="divAssignmentTable" runat="server">

        </div>
    </form>
</body>
</html>
