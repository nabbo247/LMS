var findAPITries=1;
var API = null;
var	timerID = null;
var	timerRunning = false;
var	startDate;
var	startSecs;
var timeValue;
var lessonInfo = null;
var finishCalled=false;
var Bookmark_location="";
var SetCompletioStatus = false;
var SetMasteryScore=75;



function FindAPI(win)
{
    //alert('In FindAPI');
   while ((win.API == null) && (win.parent != null) && (win.parent != win))
   {
      findAPITries++;
      // Note: 7 is an arbitrary number, but should be more than sufficient
      if (findAPITries > 7) 
      {
        parent.status = "Error finding API -- too deeply nested.";
         return null;
      }
      
      win = win.parent;

   }
   return win.API;
}
function GetAPI()
{
   var API = FindAPI(window);
 
   if ((API == null) && (window.opener != null) && (typeof(window.opener) != "undefined"))
   {
      API = FindAPI(window.opener);
   }
   if (API == null)
   {
     parent.status = "Unable to find an API adapter";
   }
   return API
}


function initSco()
{
    //alert('In initSco');
	API = GetAPI();	
	if( API != null )
	{
		var ret;
		var code;
		var diag;
		API.LMSInitialize("");
		
		startclock();

		var status = get_val("cmi.core.lesson_status");
		
		if (status == "not attempted")
		{
			// the student is now attempting the lesson
			set_val("cmi.core.lesson_status","incomplete");
		}

		Bookmark_location=get_val("cmi.suspend_data");
			
		code = API.LMSGetLastError();
		ret = API.LMSGetErrorString( code );
		diag = API.LMSGetDiagnostic( "" );		
	}
}



function set_val( gname,gvalue )
{
   // alert('In set_val :' + gname + ' $$ ' + gvalue);
	GetAPI();	
	if(API != null)
	{
		var ret;
		var code;
		var diag;		
		API.LMSSetValue( gname, gvalue );
		code = API.LMSGetLastError();
		ret = API.LMSGetErrorString( code );
		diag = API.LMSGetDiagnostic( "" );
	}
};

function get_val( gname )
{
   // alert('In set_val :' + gname);
	GetAPI();	
	if( API != null )
	{
		var ret1,ret2;
		var code;
		var diag;
				
		ret1 = API.LMSGetValue( gname );		
		code = API.LMSGetLastError();
		ret2 = API.LMSGetErrorString( code );
		diag = API.LMSGetDiagnostic( "" );
		return ret1;			
	}
	
};

function commit()
{
    //alert('In commit');
	
	GetAPI();
	if( API != null )
	{
		var ret = "";
		var code;
		var diag;
		
		API.LMSCommit("");
		code = API.LMSGetLastError();
		ret = API.LMSGetErrorString( code );
		diag = API.LMSGetDiagnostic( "" );		
	}
	
};

	
function finish()
{
    //alert('In finish');
	GetAPI();
	
	if( API != null )
	{
		var ret;
		var code;
		var diag;
		
		sTime=stopclock();
		sTime=String(sTime)
		set_val("cmi.core.session_time",sTime);
		
		ret = API.LMSFinish("");			
		code = API.LMSGetLastError();
		ret = API.LMSGetErrorString( code );
		diag = API.LMSGetDiagnostic( "" );		
	}	
};

function stopclock()
{

	if(timerRunning){
		clearTimeout(timerID)
		timerRunning = false
		return timeValue
}
}
//-----------------------------------------------------------------------
function startclock()
{

	startDate = new Date()
	startSecs = (startDate.getHours()*60*60) + (startDate.getMinutes()*60) 
						+ startDate.getSeconds()

	stopclock()
		showtime()
	
}
//-----------------------------------------------------------------------
function showtime()
{
	// this doesn't work correctly at midnight...

	var now = new Date()
	var nowSecs = (now.getHours()*60*60) + (now.getMinutes()*60) + now.getSeconds()
	var elapsedSecs = nowSecs - startSecs;

	var hours = Math.floor( elapsedSecs / 3600 )
	elapsedSecs = elapsedSecs - (hours*3600)

	var minutes = 	Math.floor( elapsedSecs / 60 )
	elapsedSecs = elapsedSecs - (minutes*60)

	var seconds = elapsedSecs

	timeValue = "" + hours
		if(hours<10){
		timeValue = "0" + hours
	}
	timeValue  += ((minutes < 10) ? ":0" : ":") + minutes
	timeValue  += ((seconds < 10) ? ":0" : ":") + seconds

		// Update display
	timerID = setTimeout("showtime()",1000)
	timerRunning = true
}


function fnSetCompletion ()
{
    //alert('In fnSetCompletion');
	if(SetCompletioStatus == false)
	{
		set_val("cmi.core.lesson_status","completed");
		SetCompletioStatus = true;				
	}
}

function fnGetBookMark()
{
    //alert('In fnGetBookMark: ' + Bookmark_location);
	return Bookmark_location;
}

function set_location(setbookmark,param)
{

   // alert('In set_location' + Bookmark_location);
	Bookmark_location=setbookmark;
	set_val('cmi.suspend_data',Bookmark_location);
}




//Set the score
function score(score)
{	
	set_val("cmi.core.score.raw",score);	
	if(score>=SetMasteryScore)
	{	
		set_val("cmi.core.lesson_status","passed");
	}
	else
	{
		//set_val("cmi.core.lesson_status","failed");	
	}
}

function fnGetStudentName()
{	
	return(get_val("cmi.core.student_name"))
}


//open the Html Page
function OpenHTMLPage(param)
{ 
	param = param.split("|");
	var htmlname = param[0];
	var launch = param[1];	  
	
	var winWidth=param[2];
	var winHeight=param[3];

	var screenWidth=screen.width/2
	var screenHeight=screen.height/2
	var xPos=screenWidth-(winWidth/2)
	var yPos=screenHeight-(winHeight/2)
	var option = "width="+winWidth+",height="+winHeight+",scrollbars=no,fullScreen=no,resizable=0,top="+yPos+",left="+xPos+"";

    var openHTMLWin=window.open(htmlname,launch,option); 
	openHTMLWin.focus();
}




//open the pdf documents
function OpenWebLink(param)
{ 	   
    var openWebWin=window.open(param,"_blank");
	openWebWin.focus();
}



//open the pdf documents
function OpenPDFDocuments(param)
{ 
	param = param.split("|");
	var pdfname = param[0];
	var launch = param[1];	   
	var winWidth=1010;
    var winHeight=675;   
   // var option = "width="+winWidth+",height="+winHeight+",scrollbars=no,fullScreen=no,resizable=0,top=0,left=0"
    var openWinPDF=window.open(pdfname,launch);  
}