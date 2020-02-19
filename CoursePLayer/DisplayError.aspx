<%@ Page Language="C#" AutoEventWireup="true" Inherits="DisplayError" Codebehind="DisplayError.aspx.cs" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title>HRS</title>
</head>
<body>
<script type="text/javascript">
    var handlingError = top.handlingError = true;
    function makeErrorAlert(returnVal) {
        var errorAlert = function(param1, param2) {
            return returnVal;
        }
        return errorAlert;
    }
    if (top.DefaultContentFrame && top.DefaultContentFrame.API) {
        top.DefaultContentFrame.API.LMSInitialize = makeErrorAlert(false);
        top.DefaultContentFrame.API.LMSCommit = makeErrorAlert(false);
        top.DefaultContentFrame.API.LMSFinish = makeErrorAlert(false);
        top.DefaultContentFrame.API.LMSSetValue = makeErrorAlert(false);
        top.DefaultContentFrame.API.LMSGetValue = makeErrorAlert("");
        top.DefaultContentFrame.API.LMSGetLastError = makeErrorAlert("101");
        top.DefaultContentFrame.API.LMSGetErrorString = makeErrorAlert("The user's session has timed out");
        top.DefaultContentFrame.API.LMSGetDiagnostic = makeErrorAlert("The user's session has timed out");
    }
    self.focus();

    if (window.top.location.href != window.location.href) {
        if (parent && parent.mainFrame && parent.mainFrame.location.href.indexOf("v5_0/syscheck") > 0) {
            parent.mainFrame.clearBeforeUnload();
            parent.mainFrame.onbeforeunload = null;
        } else {
            alert("An error has occurred.\nPlease exit this course and return to your home page to launch it again.");
        }
        try {
            window.top.location.replace(window.location.href);
        }
        catch (ex) {
            alert("If you continue in the course, any further progress will not be saved.\nPlease exit this course and return to your home page to launch it again.");
        }
    }
</script>
   <form id="Form1" method="post" runat="server">
       <table border="0" cellpadding="0" cellspacing="0" style="height: 73%"
           width="100%">
           <tr bgcolor="#4b5053">
               <td colspan="2" style="padding-left: 22px; padding-bottom: 10px; padding-top: 15px">
                   <strong><span style="font-weight: bold; font-size: 14px; color: #ffffff; font-family: Verdana, Arial, Helvetica, sans-serif">Error</span></strong></td>
           </tr>
           <tr>
               <td colspan="2" style="height: 16px">
                   &nbsp;</td>
           </tr>
           <tr>
               <td align="center" bgcolor="#ffffff" style="height: 304px" valign="top" width="100%">
                   <table border="0" cellpadding="10" cellspacing="0" width="100%">
                       <tr>
                           <td style="padding-left: 20px; padding-top: 10px">
                           </td>
                       </tr>
                       <tr>
                           <td style="height: 1px">
                           </td>
                       </tr>
                       <tr>
                           <td align="center" style="padding-left: 20px; font-weight: normal; font-size: 11px;
                               font-family: Verdana, Arial, Helvetica, sans-serif" valign="middle">
                               <table id="tblAddCourse" runat="server" style="border-right: #4b5053 1px solid; border-top: #4b5053 1px solid;
                                   padding-left: 20px; border-left: #4b5053 1px solid; width: 330px; padding-top: 5px;
                                   border-bottom: #4b5053 1px solid; height: 218px; background-color: #efefef">
                                   <tr>
                                       <td colspan="2" style="height: 194px" valign="top">
                                           <strong><span style="font-weight: bold; font-size: 14px; color: #ffffff; font-family: Verdana, Arial, Helvetica, sans-serif">
                                           </span></strong>
                                           <table align="center" style="vertical-align: middle; width: 402px; height: 178px">
                                               <tr>
                                                   <td rowspan="1">
                                                       <span style="font-size: 18pt"><span style="color: #879596" id="errorHeader" runat="server">Error!<font class="clsLoginTitle"></font></span></span></td>
                                               </tr>
                                               <tr>
                                                   <td rowspan="4">
                                                       <table border="0" bgcolor="#f5f5f5" width="100%" height="130" cellspacing="0" cellpadding="0"
							style="border-TOP:gray 1px solid; border-BOTTOM:gray 1px solid">
							<tr>
								<td width="40">&nbsp;</td>
								<td>
									<P ><FONT class="clsSmallText"><br />
                                        <span style="font-size: 10pt; font-family: Verdana" id="errorText" runat="server">
											Some error has occured in the system. 
                                        </span></FONT>
									</P>
									<FONT class="clsSmallText">
										<P >
                                            <span style="font-size: 10pt; font-family: Verdana" id="errorDescription" runat="server">We apologize for the inconvenience caused.&nbsp;
											<br />
											We will take appropriate action and do our best to avoid such errors in future.
                                            </span>
										</P>
										<P>
                                            <span style="font-size: 10pt; font-family: Verdana">Thank you for your continued support.</span></P>
										<P></FONT> &nbsp;</td>
								<td width="40">&nbsp;</td>
							</tr>
						</table>
                                                       &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</td>
                                               </tr>
                                               <tr>
                                               </tr>
                                               <tr>
                                               </tr>
                                               <tr>
                                               </tr>
                                           </table>
                                       </td>
                                   </tr>
                               </table>
                           </td>
                       </tr>
                   </table>
               </td>
               <td style="height: 304px">
                   <img alt="" height="352" width="8" /></td>
           </tr>
       </table>
		</form>
</body>
</html>
