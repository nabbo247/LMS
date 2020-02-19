<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScormCourseDefaultPage.aspx.cs"
    Inherits="HRS.CoursePlayer.ScormCourseDefaultPage" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>BV-LMS Scorm Default Page</title>
    <style>
        .gridtitlebgleft
        {
            background: #dfe2e9;
            font-weight: bold;
            color: #666666;
            text-align: left;
            vertical-align: top;
            height: 30px;
            word-wrap: break-word;
            font-family: Verdana;
            font-size: x-small;
        }
        .gridrowcolor2
        {
            word-wrap: break-word;
            vertical-align: top;
            background: #ffffff;
            font-family: Verdana;
            font-size: x-small;
        }
        .gridrowcolor1
        {
            word-wrap: break-word;
            vertical-align: top;
            background: #f5f8ff;
            font-family: Verdana;
            font-size: x-small;
        }
        .gridbox
        {
            width: 100%;
            padding: 4px;
            text-align: center;
            vertical-align: top;
            background-color: #C1C2C6;
            font-family: Verdana;
            font-size: x-small;
        }
        .SpanWordRap
        {
            padding-left: 20px;
            word-wrap: break-word;
        }
    </style>
</head>
<body onkeypress="javascript:onEnterKeyPress();" bottommargin="0" leftmargin="0"
    topmargin="0" rightmargin="0">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0" style="height: 60%">
        <tr bgcolor="#4b5053">
            <td style="padding-left: 22px; padding-bottom: 5px; padding-top: 10px; height: 5px;"
                colspan="5">
                <table width="100%">
                    <tr align="left">
                        <td>
                            <strong><span style="color: #ffffff; font-family: Verdana, Arial, Helvetica, sans-serif;
                                font-size: 15px; font-weight: bold;">&nbsp; <span style="font-size: 10pt">Welcome</span>
                                <asp:Label ID="lblWelcome" runat="server" Font-Names="Verdana" Font-Size="10pt"></asp:Label></span></strong>
                        </td>
                        <td align="right" valign="middle">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 5px; height: 285px">
                &nbsp;
            </td>
            <td style="width: 11px; height: 285px;">
            </td>
            <td valign="top" align="center" width="100%" bgcolor="#ffffff" style="height: 285px">
                <table cellspacing="0" cellpadding="10" width="100%" border="0">
                    <tr>
                        <td style="padding-left: 20px; font-family: Verdana, Arial, Helvetica, sans-serif;
                            font-size: 11px; font-weight: normal;" align="center" valign="middle">
                            <table id="tblupdate" runat="server" style="border: 1px solid #4b5053; padding-left: 0px;
                                background-color: #efefef; padding-top: 5px; width: 496px;">
                                <tr>
                                    <td style="height: 29px; text-align: left;" colspan="2">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td class="clsOrangeBGBar" style="padding-left: 10px; padding-bottom: 5px; padding-top: 5px">
                                                    <font class="clsFieldNames"><span style="font-size: 10pt">
                                                        <asp:Label ID="lblErr" runat="server" CssClass="clsText" Font-Bold="True" Font-Names="Verdana"
                                                            Font-Size="10pt" ForeColor="Red"></asp:Label></span></font>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td class="clsOrangeBGBar">
                                                    <strong><span cssclass="clsText" style="font-size: 10pt">Course Name: &nbsp;<asp:Label
                                                        ID="lblContentModuleName" runat="server"></asp:Label></span></strong>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 4px">
                                                </td>
                                                <td style="padding-top: 10px; height: 4px;">
                                                    <strong><span style="font-size: 10pt">Instructions:</span></strong>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td style="padding-top: 10px" align="left" valign="top">
                                                    <asp:Label runat="server" ID="lblMessage" CssClass="clsText" Font-Names="Verdana"
                                                        Font-Size="10pt"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 29px; padding-bottom: 10px;">
                                                    &nbsp;
                                                </td>
                                                <td class="clsGrayBGBar" style="padding-left: 5px; padding-bottom: 10px; padding-top: 5px;
                                                    height: 29px;">
                                                    <span style="font-size: 10pt"><strong>
                                                        <%=totalscos%>&nbsp;Lessons</strong></span>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                <table id="grvSco" class="gridbox" cellspacing="0" cellpadding="3" border="1" style="border-color:#CCCCCC;border-width:1px;border-style:None;font-family:Tahoma;font-size:Small;border-collapse:collapse;" rules="all">
                                                <thead><tr class="gridtitlebgleft" align="left" valign="middle" style="font-weight:bold;"><th scope="col">Lesson</th><th align="center" valign="middle" scope="col">Lesson Status</th></tr></thead>
                                                <tbody>
                                                <% foreach(var section in sections)
                                                   {
                                                       %>
                                                       <tr><td align="left" valign="middle"><%=section.Title %></td><td></td></tr>
                                                       <%
                                                       
                                                   }%>
                                                </tbody>
                                                </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 19px">
                                                    &nbsp;
                                                </td>
                                                <td style="height: 19px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 19px">
                                                    &nbsp;
                                                </td>
                                                <td style="height: 19px">
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 9px; height: 285px">
            </td>
            <td style="width: 5px; height: 285px">
            </td>
        </tr>
        <tr>
            <td colspan="5" style="height: 14px">
            </td>
        </tr>
    </table>
    <div runat="server" id="divXML">
    </div>

    <script language="javascript">
    if(arrManifestNodes.length ==1)
    {
        parent.SetLaunchSco(true);
        fGoToLaunchSco(arrManifestNodes[0].identifier);
    }
    else
    {
        parent.SetLaunchSco(false);
        parent.hideFrame();
    }
    </script>

    </form>
</body>
</html>
