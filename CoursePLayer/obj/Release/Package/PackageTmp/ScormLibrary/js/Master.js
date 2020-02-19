/*
	0 - [identifier, title, winTarget, adlcp:prerequisites, adlcp:datafromlms],	//item props
	1 - [resourceid, adlcp:scormtype, type, href], //resource props
	2 to n - [children]

	var COOL_NODES =
	[
		[['ITEM1','Course11','contentFrame','','Sample Launch data'],['Resource1','asset','webcontent','null'],
			[['ITEM2','DSL Overview','contentFrame','',''],['Resource2', 'sco', 'webcontent', '../course/dir1_SCO/m1.html'],
				[['ITEM3','DSL Defined','contentFrame','',''],['Resource3', 'sco', 'webcontent', '../course/dir2_SCO/m1p1.html'],
					[['ITEM4','High Speed','contentFrame','',''],['Resource4', 'sco', 'webcontent', '../course/dir3_SCO/m1p1u1.html']],
					[['ITEM5','Competing Technologies','contentFrame','',''],['Resource5', 'sco', 'webcontent', '../course/dir4_SCO/m1p1u2.html']],
					[['ITEM6','Uses for DSL','contentFrame','',''],['Resource6', 'sco', 'webcontent', '../course/dir5_SCO/m1p1u3.html']],
					[['ITEM7','Variants of DSL','contentFrame','',''],['Resource7', 'sco', 'webcontent', '../course/dir6_SCO/m1p1u4.html']],
				],
			],
			[['ITEM8','Technical Overview','contentFrame','',''],['Resource8', 'sco', 'webcontent', '../course/dir18_SCO/m2.html'],
				[['ITEM9','How Does DSL Work?','contentFrame','',''],['Resource9', 'sco', 'webcontent', '../course/dir19_SCO/m2p1.html'],
					[['ITEM10','Frequencies','contentFrame','',''],['Resource10', 'sco', 'webcontent', '../course/dir20_SCO/m2p1u1.html']],
					[['ITEM11','Broadband and Baseband','contentFrame11','',''],['Resource5', 'sco', 'webcontent', '../course/dir21_SCO/m2p1u2.html']],
					[['ITEM12','Bandwidth','contentFrame','',''],['Resource12', 'sco', 'webcontent', '../course/dir22_SCO/m2p1u3.html']],
					[['ITEM13','Telephony','contentFrame','',''],['Resource13', 'sco', 'webcontent', '../course/dir24_SCO/m2p1u5.html']],
				],
			],
		],
	];
*/

/***************************************************************************************
*											Master Template													*
***************************************************************************************/

	function CAttributes(lValidationType, lMode, lRequired, lLookup, lLValue, lHValue, lImplemented, lText)
	{	
		this.ValidationType = lValidationType;
		this.Mode = lMode;
		this.Required = lRequired;
		this.LookupName = lLookup;
		this.LValue = lLValue;
		this.HValue = lHValue;
		this.Implemented = lImplemented;
		this.Text = lText;
	}

	function CMasterTemplate(){	
		this.cmi__core___children = new CAttributes("CMIString255","Read","true","","","","","student_id,student_name,manageremail,studentemail,lesson_location,credit,lesson_status,entry,score,total_time,exit,session_time");
		this.cmi__core__student_id = new CAttributes("CMIIdentifier","Read","true","","","","","");
		this.cmi__core__student_name = new CAttributes("CMIString255","Read","true","","","","","");
		this.cmi__core__manageremail = new CAttributes("CMIString255","Read","true","","","","","");
		this.cmi__core__studentemail = new CAttributes("CMIString255","Read","true","","","","","");
		this.cmi__core__lesson_location = new CAttributes("CMIString255","Both","true","","","","","");
		this.cmi__core__credit = new CAttributes("CMIVocabulary","Read","true","Credit","","","","");
		this.cmi__core__lesson_status = new CAttributes("CMIVocabulary","Both","true","J_Status","","","","");
		this.cmi__core__entry = new CAttributes("CMIVocabulary","Read","true","Entry","","","","");
		
		//this.cmi__core__score
		this.cmi__core__score___children = new CAttributes("CMIString255","Read","true","","","","","raw,min,max");
		this.cmi__core__score__raw = new CAttributes("CMIDecimal","Both","true","","","","","");
		this.cmi__core__score__max = new CAttributes("CMIDecimal","Both","false","","","","","");
		this.cmi__core__score__min = new CAttributes("CMIDecimal","Both","false","","","","","");
		this.cmi__core__total_time = new CAttributes("CMITimespan","Read","true","","","","","");
		this.cmi__core__lesson_mode = new CAttributes("CMIVocabulary","Read","false","Lesson_Mode","","","","");
		this.cmi__core__exit = new CAttributes("CMIVocabulary","Write","true","Exit","","","","");
		this.cmi__core__session_time = new CAttributes("CMITimespan","Write","true","","","","","");
		this.cmi__suspend_data = new CAttributes("CMIString4096","Both","true","","","","","");
		this.cmi__launch_data = new CAttributes("CMIString4096","Read","true","","","","","");
		this.cmi__comments = new CAttributes("CMIString4096","Both","false","","","","","");
		this.cmi__comments_from_lms = new CAttributes("CMIString4096","Read","false","","","","","");
		
		//this.cmi__objectives
		this.cmi__objectives___children = new CAttributes("CMIString255","Read","false","","","","","id,score,status");
		this.cmi__objectives___count = new CAttributes("CMIInteger","Read","false","","","","","");
		
		//this.cmi__objectives___number
		this.cmi__objectives___number__id = new CAttributes("CMIIdentifier","Both","false","","","","","");
		
		//this.cmi__objectives___number__score
		this.cmi__objectives___number__score___children = new CAttributes("CMIString255","Read","false","","","","","raw,min,max");
		this.cmi__objectives___number__score__raw = new CAttributes("CMIDecimal","Both","false","","","","","");
		this.cmi__objectives___number__score__max = new CAttributes("CMIDecimal","Both","false","","","","","");
		this.cmi__objectives___number__score__min = new CAttributes("CMIDecimal","Both","false","","","","","");
		this.cmi__objectives___number__status = new CAttributes("CMIVocabulary","Both","false","J_Status","","","","");
		
		//this.cmi__student_data
		this.cmi__student_data___children = new CAttributes("CMIString255","Read","false","","","","","mastery_score,time_limit_action,max_time_allowed");
		this.cmi__student_data__mastery_score = new CAttributes("CMIDecimal","Read","false","","","","","");
		this.cmi__student_data__max_time_allowed = new CAttributes("CMITimespan","Read","false","","","","","");
		this.cmi__student_data__time_limit_action = new CAttributes("CMIVocabulary","Read","false","Time_Limit_Action","","","","");
		
		//this.cmi__student_preference
		this.cmi__student_preference___children = new CAttributes("CMIString255","Read","false","","","","","audio,language, speed,text");
		this.cmi__student_preference__audio = new CAttributes("CMISInteger","Both","false","","-1","100","","");
		this.cmi__student_preference__language = new CAttributes("CMIString255","Both","false","","","","","");
		this.cmi__student_preference__speed = new CAttributes("CMISInteger","Both","false","","-100","100","","");
		this.cmi__student_preference__text = new CAttributes("CMISInteger","Both","false","","-1","1","","");
		
		//this.cmi__interactions
		this.cmi__interactions___children = new CAttributes("CMIString255","Read","false","","","","","id,objectives,time,type,correct_responses,weighting,student_response,result,latency");
		this.cmi__interactions___count = new CAttributes("CMIInteger","Read","false","","","","","");
		
		//this.cmi__interactions___number
		this.cmi__interactions___number__id = new CAttributes("CMIIdentifier","Write","false","","","","","");
		
		//this.cmi__interactions___number__objectives
		this.cmi__interactions___number__objectives___count = new CAttributes("CMIInteger","Read","false","","","","","");
		
		//this.cmi__interactions___number__objectives___number
		this.cmi__interactions___number__objectives___number__id = new CAttributes("CMIIdentifier","Write","false","","","","","");
		
		this.cmi__interactions___number__time = new CAttributes("CMITime","Write","false","","","","","");
		this.cmi__interactions___number__type = new CAttributes("CMIVocabulary","Write","false","Interaction","","","","");
		
		//this.cmi__interactions___number__correct_responses
		this.cmi__interactions___number__correct_responses___count = new CAttributes("CMIInteger","Read","false","","","","","");
		
		//this.cmi__interactions___number__correct_responses___number
		this.cmi__interactions___number__correct_responses___number__pattern = new CAttributes("CMIFeedback","Write","false","","","","","");
		
		this.cmi__interactions___number__weighting = new CAttributes("CMIDecimal","Write","false","","","","","");
		this.cmi__interactions___number__student_response = new CAttributes("CMIFeedback","Write","false","","","","","");
		this.cmi__interactions___number__result = new CAttributes("CMIVocabulary","Write","false","Result","","","","");
		this.cmi__interactions___number__latency = new CAttributes("CMITimespan","Write","false","","","","","");
	}

	var gMasterTemplate = new CMasterTemplate();

/***************************************************************************************
*											Initial Userdat SCO												*
***************************************************************************************/

	function CSCO(){
		this.identifier;
		this.cmi__core__student_id = "";
		this.cmi__core__student_name = "";
		this.cmi__core__manageremail = "";
		this.cmi__core__studentemail = "";
		this.cmi__core__lesson_location="";
		this.cmi__core__credit = "credit";
		this.cmi__core__lesson_status = "not attempted";
		this.cmi__core__entry = "ab-initio";
		this.cmi__core__score__raw="";
		this.cmi__core__score__max="";
		this.cmi__core__score__min="";
		this.cmi__core__total_time = "0000:00:00.00";
		this.cmi__core__lesson_mode = "normal";
		this.cmi__core__exit="";
		this.cmi__core__session_time="0000:00:00.00";
		this.cmi__suspend_data="";
		this.cmi__launch_data="";
		this.cmi__comments="";
		this.cmi__comments_from_lms="";
		this.cmi__objectives___count="0";
		this.cmi__student_data__mastery_score="";
		this.cmi__student_data__max_time_allowed="";
		this.cmi__student_data__time_limit_action="";
		this.cmi__student_preference__language=sLearnerLanguageId;
	}


/***************************************************************************************
*											SCORM Functions States											*
***************************************************************************************/


	var gArrFunctionsState = [];
	gArrFunctionsState["NotInitialized"] = "LMSInitialize LMSGetLastError LMSGetErrorString LMSGetDiagnostic";
	gArrFunctionsState["Initialized"] = "LMSGetValue LMSSetValue LMSGetLastError LMSGetErrorString LMSGetDiagnostic LMSCommit LMSFinish";
	gArrFunctionsState["Finished"] = "LMSGetLastError LMSGetErrorString LMSGetDiagnostic";
	gArrFunctionsState["LMSFinishReturn"] = "true";


/***************************************************************************************
*											Current Status														*
***************************************************************************************/

	var gArrCurrentStatus = [];
	gArrCurrentStatus["Identifier"] = "";
	gArrCurrentStatus["SectionIdentifier"] = "";
	gArrCurrentStatus["PagePosition"] = "";
	gArrCurrentStatus["SectionPosition"] = "";
	gArrCurrentStatus["LastError"] = "0";
	gArrCurrentStatus["Status"] = "";
	gArrCurrentStatus["Default"] = "";
	gArrCurrentStatus["InitializedNodeId"] = "";
	gArrCurrentStatus["LastInitializedNodeId"] = "";
	gArrCurrentStatus["LastVisitedNodeId"] = "";

/***************************************************************************************
*											Scorm CMIVOCABULARY Lookup										*
***************************************************************************************/

	var gScormLookups = [];
	gScormLookups["Credit__credit"] = "credit";
	gScormLookups["Credit__no-credit"] = "no-credit";
	gScormLookups["Credit__Default"] = "credit";

	gScormLookups["Lesson_Mode__browse"] = "browse";
	gScormLookups["Lesson_Mode__Default"] = "normal";
	gScormLookups["Lesson_Mode__normal"] = "normal";
	gScormLookups["Lesson_Mode__review"] = "review";

	gScormLookups["J_Status__passed"] = "passed";	
	gScormLookups["J_Status__completed"] = "completed";	
	gScormLookups["J_Status__failed"] = "failed";	
	gScormLookups["J_Status__incomplete"] = "incomplete";	
	gScormLookups["J_Status__browsed"] = "browsed";	
	gScormLookups["J_Status__not attempted"] = "not attempted";	

	gScormLookups["Time_Limit_Action__exit,message"] = "exit,message";	
	gScormLookups["Time_Limit_Action__exit,no message"] = "exit,no message";	
	gScormLookups["Time_Limit_Action__continue,message"] = "continue,message";	
	gScormLookups["Time_Limit_Action__continue,no message"] = "continue,no message";	

	gScormLookups["Exit__time-out"] = "time-out";	
	gScormLookups["Exit__suspend"] = "suspend";	
	gScormLookups["Exit__Default"] = "suspend";	
	gScormLookups["Exit__logout"] = "logout";	
	gScormLookups["Exit__"] = "";	

	gScormLookups["Entry__ab-initio"] = "ab-initio";	
	gScormLookups["Entry__suspend"] = "suspend";	
	gScormLookups["Entry__"] = "";	

	gScormLookups["Result__correct"] = "correct";
	gScormLookups["Result__wrong"] = "wrong";
	gScormLookups["Result__unanticipated"] = "unanticipated";
	gScormLookups["Result__neutral"] = "neutral";
	gScormLookups["Result__CheckFor"] = "CMIDecimal";

	gScormLookups["Interaction__true-false"] = "true-false";
	gScormLookups["Interaction__choice"] = "choice";
	gScormLookups["Interaction__fill-in"] = "fill-in";
	gScormLookups["Interaction__matching"] = "matching";
	gScormLookups["Interaction__performance"] = "performance";
	gScormLookups["Interaction__sequencing"] = "sequencing";
	gScormLookups["Interaction__likert"] = "likert";
	gScormLookups["Interaction__numeric"] = "numeric";

/***************************************************************************************
*											SCORM Error Lookup												*
***************************************************************************************/

	var gErrorLookup = [];
	gErrorLookup["0"] = new Array("No error", "");
	gErrorLookup["101"] = new Array("General Exception", "");
	gErrorLookup["201"] = new Array("Invalid argument error", "");
	gErrorLookup["202"] = new Array("Element cannot have children", "");
	gErrorLookup["203"] = new Array("Element not an array - Cannot have count", "");
	gErrorLookup["301"] = new Array("Not initialized", "");
	gErrorLookup["401"] = new Array("Not implemented error", "");
	gErrorLookup["402"] = new Array("Invalid Set Value, element is a keyword", "");
	gErrorLookup["403"] = new Array("Element is read only", "");
	gErrorLookup["404"] = new Array("Element is write only", "");
	gErrorLookup["405"] = new Array("Incorrect Data Type", "");