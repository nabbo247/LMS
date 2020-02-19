<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LMSNewScormTopBar.aspx.cs" Inherits="HRS.CoursePlayer.LMSNewScormTopBar" %>

<!DOCTYPE html>
<html lang="en">
	<HEAD>
		<title>LMSNewScormTopBar</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT LANGUAGE="JavaScript">
		<!--
		
		function MM_reloadPage(init)
		{
		  //reloads the window if Nav4 resized
			if (init==true) with (navigator) 
			{
				if ((appName=="Netscape")&&(parseInt(appVersion)==4)) 
				{
					document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; 
				}
			}
			else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
		}
		
		MM_reloadPage(true);

		function fMoveOverNext()
		{		   
		}

		function fMoveOverPrevious()
		{
		}

		function fMoveNext()
		{

		}

		function fMovePrevious()
		{
		}

		function fSetURL(lURL)
		{
			if (lURL == '')
			{
				lURL =parent.parent.DefaultContentFrame.gURL;
			}
            parent.parent.ContentSrvFrame.mainFrame.document.bgColor = "#FFFFFF";			
		   parent.parent.ContentSrvFrame.mainFrame.location.href = lURL;
           // parent.parent.ContentSrvFrame.mainFrame.location.href = "LaunchCourseContent.aspx?lURL=" + lURL;
		}

		function fCloseWin()
		{
			top.close();
		}
		// -->
		</SCRIPT>
	</HEAD>
	<BODY BGCOLOR="white" onload="fSetURL('')" bottomMargin="0" leftMargin="0" topMargin="0"
		rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table width="100%" cellspacing="0" cellpadding="0" border="0">
				<tr>
					<td width="20" bgcolor="#4b5053" height="31">&nbsp;</td>
					<td width="650" align="left" bgColor="#4b5053"><asp:Label id="lblContentModuleName" runat="server" CssClass="clsPLATitle"></asp:Label></td>
					<td width="50" align="center" bgcolor="#4b5053"><a href="javascript:fCloseWin();" onclick="fCloseWin();return false;" style="CURSOR:hand; TEXT-DECORATION:none"><font face="verdana" color="white" size="2">EXIT</font></a></td>
				</tr>
				<tr>
					<td width="20" bgcolor="#595e61">&nbsp;</td>
					<td width="700" align="left" bgcolor="#595e61" valign="bottom"><img src="ScormLibrary/images/bracket1.jpg" height="31"><a href="javascript:fMoveOverPrevious();" style="CURSOR:hand" onclick="fMoveOverPrevious();return false;"><img src="ScormLibrary/images/sco_previous_btn_green.jpg" height="31" border="0"></a><a href="javascript:fMoveOverNext();" onclick="fMoveOverNext();return false;" style="CURSOR:hand"><img src="ScormLibrary/images/sco_next_btn_green.jpg" height="31" border="0"></a><img src="ScormLibrary/images/bracket2.jpg" height="31"></td>
					<td width="50" align="right" bgcolor="#595e61">&nbsp;</td>
				</tr>
			</table>
		</form>
	</BODY>
</html>
