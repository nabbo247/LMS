function ShowSessionAlert() {

    //parent.parent.parent.hideFrame();     
    alert('Course session expired. Please relaunch the course.');
    parent.parent.ExitServerFrame.fnExitContentPlayer(true);
}

function fResetError() {
    fSetError("0");
}

var debugWindow;
if (top.location.href.indexOf("debugAPI") > -1) {
    debugWindow = window.open("", "debug", "width=600,height=150,top=0,left=0,toolbars=no,resizable=yes,scrollbars=yes");
    top.focus();
    top.Lcp = top.Lcp || {};
    top.Lcp.debugApi = true;
}

function isDebug() {
    return top.Lcp && top.Lcp.debugApi && debugWindow && !debugWindow.closed;
}

function zeroPad(someNumber, digits) {
    var numString = someNumber.toString();
    while (numString.length < digits) {
        numString = "0" + numString;
    }
    return numString;
}

function debugPrint(someString) {
    if (isDebug()) {
        var time = new Date();
        var timeString = time.getHours() + ":" + zeroPad(time.getMinutes(), 2) + ":" + zeroPad(time.getSeconds(), 2) + "." + zeroPad(time.getMilliseconds(), 3);
        debugWindow.document.write(timeString + ": " + someString + "<br/>");
    }
}


function fSetError(lErrNo) {
    gArrCurrentStatus["LastError"] = lErrNo;
}

function fCheckForEmptyString(lString) {
    if (lString != "") {
        fSetError("201");		//Invalid argument error
        return false;
    }

    return true;
}

function fCheckErrorStatus() {
    if (fGetNode("LastError") == "0") {
        return "true";
    }
    else {
        return "false";
    }
}

function fIsFunctionAllowed(lFunctionName) {
    var sRetVal = gArrCurrentStatus["Status"];
    if (!sRetVal || sRetVal == "") {
        return false;
    }
    var sFunctions = gArrFunctionsState[sRetVal];
    if (sFunctions.indexOf(lFunctionName) != -1) {
        return true;
    }

    if (sRetVal == "NotInitialized") {
        fSetError("301");
    }
    else {
        fSetError("101");
    }

    return false;
}

//This function will be called from LMSInitialize to set the core.entry
//depending on core.exit
function fModifyCoreEntry() {
    var sExitVal = fDirectGetDataFormUserDataXML("cmi__core__exit");

    if (sExitVal == "suspend") {
        fDirectSetDataToUserDataXML("cmi__core__entry", "suspend");
    }
    else {
        fDirectSetDataToUserDataXML("cmi__core__entry", "");
    }
}


function LMSIntInitialize(lParam) {
    debugPrint("Initialize: lParam = '" + lParam + "'");
    if (!fCheckForEmptyString(lParam)) {
        debugPrint("exiting Initialize, may not call with parameter value");
        return "false";
    }

    if (!fIsFunctionAllowed("LMSInitialize")) {
        debugPrint("exiting Initialize, function not allowed now");
        return "false";
    }


    fResetError();
    fModifyCoreEntry();
    fCheckAndCreateSCOBlock();
    fSetNode("Status", "Initialized");

    debugPrint("finished Initialize");
    return fCheckErrorStatus();
}

function LMSIntGetValue(lParam) {
    debugPrint("GetValue: lParam = '" + lParam + "'");
    if (!fIsFunctionAllowed("LMSGetValue")) {
        debugPrint("exiting GetValue, function not allowed now");
        return "";
    }

    fResetError();
    var data = fGetSetUserData(lParam, "", "Get");
    debugPrint("finished GetValue, returning data: '" + data + "'");
    return data;
}

function LMSIntSetValue(lParam, lData) {

    if (lParam == "cmi.core.score" && gTrackScoreSettingFromLMS == "false") {
        debugPrint("exiting SetValue, skipping score");
        return "true";
    }

    if (lParam == "cmi.interactions" && gTrackResponseSettingFromLMS == "false") {
        debugPrint("exiting SetValue, skipping interactions");
        return "true";
    }

    if (!fIsFunctionAllowed("LMSSetValue")) {
        debugPrint("exiting SetValue, function not allowed now");
        return "false";
    }

    if (lParam == "cmi.core.lesson_status" && lData == "not attempted") {
        debugPrint("exiting SetValue, not allowed to set status not attempted");
        fSetError("405");
        return "false";
    }

    fResetError();

    var compareData = lData;
    if (lParam == "cmi.core.lesson_status") {
        compareData = fGetSetUserData(lParam, "", "Get");
    }

    fGetSetUserData(lParam, lData, "Set");
    fSendRequest("SaveCurrentSco");
    if (compareData != lData) {
        debugPrint("changed lesson status from '" + compareData + "' to '" + lData + "', going to send data");
        fSendRequest("SaveCurrentSco");
    }
    debugPrint("finished SetValue");
    return fCheckErrorStatus();
}

function LMSIntFinish(lParam) {
    debugPrint("Finish: lParam = '" + lParam + "'");

    if (!fCheckForEmptyString(lParam)) {
        debugPrint("exiting Finish, may not call with parameter value");
        return "false";
    }

    if (!fIsFunctionAllowed("LMSFinish")) {
        debugPrint("exiting Finish, function not allowed now");
        return "false";
    }

    fModifySCOParamsBeforeLMSFinish();
    fResetError();
    LMSIntCommit("");
    fSetNode("Status", "Finished");

    var LMSIntFinish = fCheckErrorStatus();
    fSetLMSFinishReturn(LMSIntFinish);
    debugPrint("finished Finish");
    return LMSIntFinish;
}

function LMSIntCommit(lParam) {
    debugPrint("Commit: lParam = '" + lParam + "'");

    if (!fCheckForEmptyString(lParam)) {
        debugPrint("exiting Commit, may not call with parameter value");
        return "false";
    }

    if (!fIsFunctionAllowed("LMSCommit")) {
        debugPrint("exiting Commit, function not allowed now");
        return "false";
    }

    fResetError();

    if (!fSendRequest("SaveCurrentSco")) {
        fSetError("101");
    }
    debugPrint("finished Commit");
    return fCheckErrorStatus();
}

function LMSIntGetLastError() {

    if (!fValidateFinishedState("LMSGetLastError")) {
        return "false";
    }

    return fGetNode("LastError");
}

function LMSIntGetErrorString(lErrNo) {

    if (!fValidateFinishedState("LMSGetErrorString")) {
        return "false";
    }

    return fGetErrorString(lErrNo);
}

function LMSIntGetDiagnostic(lErrNo) {

    if (!fValidateFinishedState("LMSGetDiagnostic")) {
        return "false";
    }

    return fGetErrorDiagnostic(lErrNo);
}

//---------------------------------------------------------------------------

function fGetErrorString(lErrNo) {
    if (gErrorLookup[lErrNo]) {
        return gErrorLookup[lErrNo][0];
    }

    return "";
}

function fGetErrorDiagnostic(lErrNo) {
    if (gErrorLookup[lErrNo]) {
        return gErrorLookup[lErrNo][1];
    }

    return "";
}

function fValidateFinishedState(lFunctionName) {
    if (!fIsFunctionAllowed(lFunctionName)) {
        return false;
    }

    if (fGetNode("Status") == "Finished") {
        if (fGetLMSFinishReturn() == "true") {
            return false;
        }
    }

    return true;
}

function fGetLMSFinishReturn() {
    return gArrFunctionsState["LMSFinishReturn"];
}


function fSetLMSFinishReturn(lValue) {
    gArrFunctionsState["LMSFinishReturn"] = lValue;
}

function fCheckAndCreateSCOBlockForAsset() {
    var sIdentifier = fGetNode("Identifier");
    var oSCO = fGetCurrentSCO();

    if (!oSCO) {
        oSCO = new CSCO();
        oSCO.identifier = sIdentifier;

        //set Learner id
        oSCO.cmi__core__student_id = gStudentId;

        //set Learner Name
        oSCO.cmi__core__student_name = gLearnerName;

        //set Manager Email 
        oSCO.cmi__core__manageremail = gManagerEmail;

        //set Student Email 
        oSCO.cmi__core__studentemail = gStudentEmail;

        oSCO.cmi__student_preference__language = sLearnerLanguageId;

        //set lesson_status to completed vinod bonde
        oSCO.cmi__core__lesson_status = "completed";

        arrSCO[arrSCO.length] = oSCO;

        fSendRequest("SaveCurrentSco");
    }
}

function fCheckAndCreateSCOBlock() {

    var sIdentifier = fGetNode("Identifier");
    var oSCO = fGetCurrentSCO();

    if (!oSCO) {
        oSCO = new CSCO();
        oSCO.identifier = sIdentifier;

        //set Learner id
        oSCO.cmi__core__student_id = gStudentId;

        //set Learner Name
        oSCO.cmi__core__student_name = gLearnerName;

        //set Manager Email 
        //oSCO.cmi__core__manageremail = gManagerEmail;

        //set Student Email 
        //oSCO.cmi__core__studentemail = gStudentEmail;

        oSCO.cmi__student_preference__language = sLearnerLanguageId;

        arrSCO[arrSCO.length] = oSCO;

        //set data from Manifest
        fSetDataFromManifest("cmi__launch_data", "datafromlms");//modified 

        fSetDataFromManifest("cmi__student_data__mastery_score", "masteryscore");

        fSetDataFromManifest("cmi__student_data__max_time_allowed", "adlcp:maxtimeallowed");
        fSetDataFromManifest("cmi__student_data__time_limit_action", "adlcp:timelimitaction");
    }
}

function fSetDataFromManifest(lXPath, lParam) {

    retVal = fGetDataFromManifest(lParam);

    if (retVal != "") {
        fDirectSetDataToUserDataXML(lXPath, retVal);
    }
}

function fIsNumeric(lValue) {
    if ((/^[0-9 ]+$/.test(lValue))) {
        return true;
    }

    return false;
}


function fGetSetUserData(lParam, lData, lGetSet) {

    if (lParam.indexOf(".") == -1) {
        fSetError("201");
        return "";
    }

    /*
        - Clonning User data xml to achieve the functionality to roll back
          the changes if required
        - Make any changes to this clone node and if no error ocurred then 
          copy it back to the user data xml

        set xmlUserDataClone = CreateObject("Microsoft.xmldom")
        xmlUserDataClone.async = false
        call xmlUserDataClone.loadXML(xmlUserData.xml)
    */

    var arrParams = lParam.split(".");

    var userData_RunningPath = "";
    var sPreviousObjectivePath = "";              	//to check against userdata xml for objective sequence
    var template_RunningPath = "";                	//to check against template xml
    var currentNodeName = "";
    var bObjective = false;

    for (var i = 0; i < arrParams.length; i++) {
        if (fIsNumeric(arrParams[i])) {
            sPreviousObjectivePath = userData_RunningPath.substr(2) + "__" + "_" + (arrParams[i] - 1);
            arrParams[i] = "_" + arrParams[i];
            currentNodeName = "_number";             //to check against template xml
            bObjective = true;
        }
        else {
            currentNodeName = arrParams[i];
            if (fIsNumeric(currentNodeName.substr(0, 1))) {
                fSetError("201");
                return "";
            }
        }

        template_RunningPath = template_RunningPath + "__" + currentNodeName;     //to check against template xml

        userData_RunningPath = userData_RunningPath + "__" + arrParams[i];  			//to check against userdata xml
    }

    template_RunningPath = template_RunningPath.substr(2);
    userData_RunningPath = userData_RunningPath.substr(2);

    if (lGetSet == "Set") {
        fSetNodeValue(template_RunningPath, userData_RunningPath, lData, bObjective, sPreviousObjectivePath);
    }
    else {
        return fGetNodeValue(template_RunningPath, userData_RunningPath);
    }

    var bERROR = fGetNode("LastError");
    if (bERROR != "0") {
        return "";
    }

    return "";
}

function fGetLastNodeInContext(lXPath) {
    ArrNodes = lXPath.split("__");
    return ArrNodes[ArrNodes.length - 1];
}

//verifies the context passed to the function against the template
function fIsCorrectContext(lContext) {
    eval("var oTemplateNode = gMasterTemplate." + lContext);
    return (!fIsUndefined(oTemplateNode));
}

function fIsUndefined(val) {
    return typeof (val) == 'undefined';
}

//verifies the context passed to the function is implemented or not
function fIsImplemented(lContext) {
    var sRetVal = fGetValueFromMasterTemplate(lContext + ".Implemented");
    return (sRetVal != "false");
}

function fCanWrite(lNode) {
    var sRetVal = lNode.Mode;

    if (sRetVal == "Write" || sRetVal == "Both") {
        return true;
    }

    return false;
}

function fCanRead(lNode) {
    var sRetVal = lNode.Mode;
    if (sRetVal == "Read" || sRetVal == "Both") {
        return true;
    }

    return false;
}


function fCheckError(lCase, lContext) {
    eval("var oTemplateNode = gMasterTemplate." + lContext);
    var sErrorNumber = "0";
    var sLastNode = fGetLastNodeInContext(lContext);

    switch (lCase) {
        case "201":											//correct Context
            if (!fIsCorrectContext(lContext)) {
                sErrorNumber = "201";

                if (sLastNode == "_children") {
                    sErrorNumber = "202";
                }

                if (sLastNode == "_count") {
                    sErrorNumber = "203";
                }
            }
            break;

        case "202":
            break;

        case "203":
            if (sLastNode == "_count") {
                sErrorNumber = "203";
            }
            break;

        case "401":           							//IsImplemented
            if (!fIsImplemented(lContext)) {
                sErrorNumber = "401";
            }
            break;

        case "404":           							//Can Read
            if (!fCanRead(oTemplateNode)) {
                sErrorNumber = "404";
            }
            break;

        case "402":
            if (sLastNode == "_children" || sLastNode == "_count" || sLastNode == "_version") {
                sErrorNumber = "402";
            }
            break;

        case "403":
            if (!fCanWrite(oTemplateNode)) {
                sErrorNumber = "403";
            }
            break;
    }

    if (sErrorNumber == "0") {
        return false;
    }
    else {
        fSetError(sErrorNumber);
        return true;
    }
}


function fGetNodeValue(lTemplateNodePath, lUserNodePath) {
    //fGetNodeValue = "false"

    //correct Context
    if (fCheckError("201", lTemplateNodePath)) {
        return "";
    }

    //IsImplemented
    if (fCheckError("401", lTemplateNodePath)) {
        return "";
    }

    //Can Read
    if (fCheckError("404", lTemplateNodePath)) {
        return "";
    }

    var sRetVal = "";

    if (fGetLastNodeInContext(lTemplateNodePath) == "_children") {
        //if not XMLLib.fgetvalue(xmlTemplateDoc, lTemplateNodePath, lGetValue) then
        sRetVal = fGetValueFromMasterTemplate(lTemplateNodePath + ".Text");

        if (fIsUndefined(sRetVal)) {
            fSetError("401");
        }
    }
    else {
        if (fGetLastNodeInContext(lTemplateNodePath) == "_count") {
            //inscrease the ._count
            fUpdateCount(lUserNodePath);

            //call XMLLib.fgetvalue(xmlUserDataClone, lUserNodePath, lGetValue)
            sRetVal = fDirectGetDataFormUserDataXML(lUserNodePath);
            if (sRetVal == "") {
                sRetVal = "0";
            }
        }
        else {
            sRetVal = fDirectGetDataFormUserDataXML(lUserNodePath);
            if (sRetVal == "") {
                fSetError("201");
            }
        }
    }

    fSetError("0");
    return sRetVal;
}

function fSetNodeValue(lTemplateNodePath, lUserNodePath, lSetValue, lbObjective, lsPreviousObjectivePath) {

    //incorrect Context
    if (fCheckError("201", lTemplateNodePath)) {
        return false;
    }

    //not Implemented
    if (fCheckError("401", lTemplateNodePath)) {
        return false;
    }

    //reserved keywords
    if (fCheckError("402", lTemplateNodePath)) {
        return false;
    }

    //Can Write
    if (fCheckError("403", lTemplateNodePath)) {
        return false;
    }

    //check sequence for objectives, interactions and interactions.objectives
    if (!fCheckForObjectiveSequence(lsPreviousObjectivePath, lbObjective)) {
        return false;
    }

    if (!fValidateSetValue(lTemplateNodePath, lSetValue)) {
        return false;
    }

    //call XMLLib.fCreateFirstContext(xmlUserDataClone, lUserNodePath, oNode)
    //append to the previously set comments
    if (lTemplateNodePath == "cmi__comments") {
        lSetValue = fDirectGetDataFormUserDataXML(lUserNodePath) + lSetValue;
    }

    //call XMLLib.fAddCdataToNode(xmlUserDataClone, oNode, lSetValue)
    fDirectSetDataToUserDataXML(lUserNodePath, lSetValue);

    //inscrease the ._count if data for new objective is added to the userdata
    //call fUpdateCount(lTemplateNodePath)

    fSetError("0");
    return true;
}

function fCheckForObjectiveSequence(lPreviousObjectivePath, lbObjective) {

    if (!lbObjective) {
        return true;
    }

    if (lPreviousObjectivePath.indexOf("_-1") != -1) {
        return true;
    }

    sRetVal = fDirectGetDataFormUserDataXML(lPreviousObjectivePath + "__id");
    if (sRetVal == "") {
        fSetError("201");
        return false;
    }

    return true;
}

function fValidateSetValue(lContext, lVal) {

    if (!fSpChecks(lContext, lVal)) {
        return false;
    }

    var sRetVal = fGetValueFromMasterTemplate(lContext + ".ValidationType");
    var sLookupName = "";

    if (sRetVal.toUpperCase() == "CMIVOCABULARY") {
        sLookupName = fGetValueFromMasterTemplate(lContext + ".LookupName");
    }

    if (!fExtResValidate(sRetVal, lVal, sLookupName, fGetValueFromMasterTemplate(lContext + ".LValue"), fGetValueFromMasterTemplate(lContext + ".HValue"))) {
        fSetError("405", "true");
        return false;
    }

    return true;
}

function fSpChecks(lContext, lVal) {

    switch (lContext) {
        case "cmi__core__score__raw":
        case "cmi__core__score__max":
        case "cmi__core__score__min":
        case "cmi__objectives___number__score__raw":
        case "cmi__objectives___number__score__max":
        case "cmi__objectives___number__score__min":
            if (lVal == "") {
                return true;
            }
            if (fExtResValidate("CMIDECIMAL", lVal, "", "", "")) {
                //value must be 0 to 100
                if (parseFloat(lVal) < 0 || parseFloat(lVal) > 100) {
                    fSetError("405", "true");
                    return false;
                }
            }
            break;
    }

    return true;
}

function fUpdateCount(lUserNodePath) {
    //cmi__objectives___count										n.id
    //cmi__interactions___count									n.id
    //cmi__interactions__n__objectives___count				n.id
    //cmi__interactions__n__correct_responses___count		n.pattern

    var sPreText = lUserNodePath.substr(0, lUserNodePath.indexOf("___count"));
    var sPostText
    if (lUserNodePath.indexOf("correct_responses") != -1) {
        sPostText = "pattern";
    }
    else {
        sPostText = "id";
    }

    var i = -1;
    for (; ;) {
        if (!fNodeExistsInCurrentSco(sPreText + "___" + (++i) + "__" + sPostText)) {
            break;
        }
    }

    fDirectSetDataToUserDataXML(lUserNodePath, i.toString());
}

function fModifySCOParamsBeforeLMSFinish() {
    fModifyLessonStatus();
    fModifyTotalTime();
}

//This function will be called before LMSFinish to add session_time
//to total_time
function fModifyTotalTime() {
    var sTotalTime = fDirectGetDataFormUserDataXML("cmi__core__total_time");
    var sSessionTime = fDirectGetDataFormUserDataXML("cmi__core__session_time");

    sTotalTime = fAddTime(sSessionTime, sTotalTime);
    if (sTotalTime != "false") {
        fDirectSetDataToUserDataXML("cmi__core__total_time", sTotalTime);
    }
}

//This function will be called before LMSFinish to correct the lesson_status
//depending on mastery-score and raw-score if the test is for credit
function fModifyLessonStatus() {
    var sLessonStatus = fDirectGetDataFormUserDataXML("cmi__core__lesson_status");

    if (sLessonStatus == "not attempted") {
        sLessonStatus = "completed";
        fDirectSetDataToUserDataXML("cmi__core__lesson_status", sLessonStatus);
    }

    if (sLessonStatus == "completed") {
        var sCredit = fDirectGetDataFormUserDataXML("cmi__core__credit");
        var sMasteryScore = fDirectGetDataFormUserDataXML("cmi__student_data__mastery_score", sMasteryScore);
        if (sCredit != "" && sMasteryScore != "") {
            var sRowScore = fDirectGetDataFormUserDataXML("cmi__core__score__raw");
            if (sRowScore != "") {
                if (parseFloat(sRowScore) < parseFloat(sMasteryScore)) {
                    fDirectSetDataToUserDataXML("cmi__core__lesson_status", "failed");
                }
                else {
                    fDirectSetDataToUserDataXML("cmi__core__lesson_status", "passed");
                }
            }
        }
    }
}

function fAddTime(lTime1, lTime2) {
    var arrTime1 = lTime1.split(":");
    var arrTime2 = lTime2.split(":");

    var extraMinute = 0;
    var extraHour = 0;

    if (arrTime1.length != 3 || arrTime2.length != 3) {
        return "false";
    }

    var fSecond = parseFloat(arrTime1[2]) + parseFloat(arrTime2[2]);
    if (fSecond >= 60) {
        fSecond = fSecond - 60;
        extraMinute = 1;
    }

    var fMinute = parseInt(arrTime1[1]) + parseInt(arrTime2[1]) + extraMinute;
    if (fMinute >= 60) {
        fMinute = fMinute - 60;
        extraHour = 1;
    }

    var fHour = parseInt(arrTime1[0]) + parseInt(arrTime2[0]) + extraHour;

    var fSecondArr = fSecond.toString().split(".");

    if (fSecondArr.length == 1) {
        if (fSecondArr[0].length == 1) {
            fSecond = "0" + fSecondArr[0] + ".00";
        }
        else {
            fSecond = fSecondArr[0] + ".00";
        }
    }
    else {
        if (fSecondArr[0].length == 1) {
            fSecondArr[0] = "0" + fSecondArr[0];
        }
        if (fSecondArr[1].length == 1) {
            fSecondArr[1] = fSecondArr[1] + "0";
        }

        fSecond = fSecondArr[0] + "." + fSecondArr[1];
    }

    fMinute = fMinute.toString();
    if (fMinute.length == 1) {
        fMinute = "0" + fMinute;
    }

    fHour = fHour.toString();
    if (fHour.length == 1) {
        fHour = "0" + fHour;
    }


    if (fSecond.length > 5) {
        fSecond = fSecond.substring(0, 5);
    }
    return fHour + ":" + fMinute + ":" + fSecond;

}

//----------------------------------------------------------------------------

function fSendRequest(lCase) {
   // debugger;
    var sURL = gUserDataURL;

    switch (lCase) {
        case "Initialise":
            break;
        case "SaveCurrentSco":
            sURL = sURL + "&Case=SaveCurrentSco";
            var sData = fSCOToXML(fGetNode("Identifier"));
            sData = "<Root><Case>SaveCurrentSco</Case><StudentId>" + gStudentId + "</StudentId><ManifestId>" + gManifestId + "</ManifestId><UserDataXML>" + sData + "</UserDataXML><ClientId>" + clientId + "</ClientId><SessionId>" + sessionId + "</SessionId></Root>";

            fSendDataToLMSNEWServer(sData, sURL);

            break;
    }

    return true;
}

function fSendDataToLMSNEWServer(lData, lURL) {
    if (!parent.ContentSrvFrame.controlFrame.document.forms[0]) {
        if (top.handlingError) {
            return false;
        } else {
            top.handlingError = true;
            //top.location.href = "DisplayError.aspx";
        }
    }

    //parent.ContentSrvFrame.controlFrame.document.formMain.TARecords.value = lData;
    //parent.ContentSrvFrame.controlFrame.document.formMain.method = "post";

    //parent.ContentSrvFrame.controlFrame.document.formMain.action = lURL;
    //parent.ContentSrvFrame.controlFrame.document.formMain.submit();
    try {
        parent.ContentSrvFrame.controlFrame.document.forms[0].TARecords.value = lData;
        parent.ContentSrvFrame.controlFrame.document.forms[0].method = "post";

        parent.ContentSrvFrame.controlFrame.document.forms[0].action = lURL;
        parent.ContentSrvFrame.controlFrame.document.forms[0].submit();
    }
    catch (ex) {
        console.log("send error");
        console.log(ex);

    }
}

function fGetCount(lSCO, lUserNodePath) {
    //cmi__objectives___count										n.id
    //cmi__interactions___count									n.id
    //cmi__interactions___n__objectives___count				n.id
    //cmi__interactions___n__correct_responses___count		n.pattern

    var sPreText = lUserNodePath.substr(0, lUserNodePath.indexOf("___count"));
    var sPostText
    if (lUserNodePath.indexOf("correct_responses") != -1) {
        sPostText = "pattern";
    }
    else {
        sPostText = "id";
    }

    var i = -1;
    var sRetVal;
    for (; ;) {
        eval("sRetVal = lSCO." + sPreText + "___" + (++i) + "__" + sPostText);
        if (fIsUndefined(sRetVal)) {
            break;
        }
    }

    return i;
}

function fSCOToXML(lIdentifier) {
    var sPreText;
    var oSCO = fGetSCO(lIdentifier);

    var iCnt = fGetCount(oSCO, "cmi__objectives___count");
    var sObjectives = "<objectives>" +
        "<_count>" + iCnt + "</_count>";

    sPreText = "cmi__objectives___";
    for (var i = 0; i < iCnt; i++) {
        sObjectives = sObjectives + "<_" + i + ">" +
            "<id>" + fGetValueFromSCO(oSCO, sPreText + i + "__id") + "</id>" +
            "<score>" +
            "<raw>" + fGetValueFromSCO(oSCO, sPreText + i + "__score__raw") + "</raw>" +
            "<max>" + fGetValueFromSCO(oSCO, sPreText + i + "__score__max") + "</max>" +
            "<min>" + fGetValueFromSCO(oSCO, sPreText + i + "__score__min") + "</min>" +
            "</score>" +
            "<status>" + fGetValueFromSCO(oSCO, sPreText + i + "__status") + "</status>" +
            "</_" + i + ">";
    }

    sObjectives = sObjectives + "</objectives>";


    var sIntPreText = "";
    var iCnt;
    var j;
    var iIntCnt = fGetCount(oSCO, "cmi__interactions___count");

    var sInteractions = "<interactions>" +
        "<_count>" + iIntCnt + "</_count>";

    sIntPreText = "cmi__interactions___";
    for (i = 0; i < iIntCnt; i++) {
        sInteractions = sInteractions + "<_" + i + ">" +
            "<id>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__id") + "</id>";

        iCnt = fGetCount(oSCO, sIntPreText + i + "__objectives___count");
        sInteractions = sInteractions + "<objectives>" +
            "<_count>" + iCnt + "</_count>";

        for (j = 0; j < iCnt; j++) {
            sInteractions = sInteractions + "<_" + j + ">" +
                "<id>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__objectives___" + j + "__id") + "</id>" +
                "</_" + j + ">";

        }

        sInteractions = sInteractions + "</objectives>" +
            "<time>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__time") + "</time>" +
            "<type>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__type") + "</type>";

        iCnt = fGetCount(oSCO, sIntPreText + i + "__correct_responses___count");
        sInteractions = sInteractions + "<correct_responses>" +
            "<_count>" + iCnt + "</_count>";

        for (j = 0; j < iCnt; j++) {
            sInteractions = sInteractions + "<_" + j + ">" +
                "<pattern>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__correct_responses___" + j + "__pattern") + "</pattern>" +
                "</_" + j + ">";

        }

        sInteractions = sInteractions + "</correct_responses>" +
            "<weighting>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__weighting") + "</weighting>" +
            "<student_response>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__student_response") + "</student_response>" +
            "<result>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__result") + "</result>" +
            "<latency>" + fGetValueFromSCO(oSCO, sIntPreText + i + "__latency") + "</latency>" +
            "</_" + i + ">";
    }

    sInteractions = sInteractions + "</interactions>";

    var random_integer = Math.random() * 101 | 0;

    //"<manageremail><![CDATA[" + fGetValueFromSCO(oSCO, "cmi__core__manageremail") + "]]></manageremail>" +
    //"<studentemail><![CDATA[" + fGetValueFromSCO(oSCO, "cmi__core__studentemail") + "]]></studentemail>" +


    var sRetXML = "<sco identifier='" + lIdentifier + "'><cmi><core>" +
        "<student_id><![CDATA[" + fGetValueFromSCO(oSCO, "cmi__core__student_id") + "]]></student_id>" +
        "<student_name><![CDATA[" + fGetValueFromSCO(oSCO, "cmi__core__student_name") + "]]></student_name>" +
        "<lesson_location><![CDATA[" + fGetValueFromSCO(oSCO, "cmi__core__lesson_location") + "]]></lesson_location>" +
        "<credit>" + fGetValueFromSCO(oSCO, "cmi__core__credit") + "</credit>" +
        "<lesson_status>" + fGetValueFromSCO(oSCO, "cmi__core__lesson_status") + "</lesson_status>" +
        "<entry>" + fGetValueFromSCO(oSCO, "cmi__core__entry") + "</entry>" +
        "<score>" +
        "<raw>" + fGetValueFromSCO(oSCO, "cmi__core__score__raw") + "</raw>" +
        "<max>" + fGetValueFromSCO(oSCO, "cmi__core__score__max") + "</max>" +
        "<min>" + fGetValueFromSCO(oSCO, "cmi__core__score__min") + "</min>" +
        "</score>" +
        "<total_time>" + fGetValueFromSCO(oSCO, "cmi__core__total_time") + "</total_time>" +
        "<lesson_mode>" + fGetValueFromSCO(oSCO, "cmi__core__lesson_mode") + "</lesson_mode>" +
        "<exit>" + fGetValueFromSCO(oSCO, "cmi__core__exit") + "</exit>" +
        "<session_time>" + fGetValueFromSCO(oSCO, "cmi__core__session_time") + "</session_time>" +
        "</core>" +
        "<suspend_data><![CDATA[" + fGetValueFromSCO(oSCO, "cmi__suspend_data") + "]]></suspend_data>" +
        "<launch_data><![CDATA[" + fGetValueFromSCO(oSCO, "cmi__launch_data") + "]]></launch_data>" +
        "<comments>" + fGetValueFromSCO(oSCO, "cmi__comments") + "</comments>" +
        //"<comments_from_lms>" + fGetValueFromSCO(oSCO, "cmi__comments_from_lms") + "</comments_from_lms>" +
        "<comments_from_lms>" + random_integer + "</comments_from_lms>" +
        sObjectives +
        "<student_data>" +
        "<mastery_score>" + fGetValueFromSCO(oSCO, "cmi__student_data__mastery_score") + "</mastery_score>" +
        "<max_time_allowed>" + fGetValueFromSCO(oSCO, "cmi__student_data__max_time_allowed") + "</max_time_allowed>" +
        "<time_limit_action>" + fGetValueFromSCO(oSCO, "cmi__student_data__time_limit_action") + "</time_limit_action>" +
        "</student_data>" +
        "<student_preference>" +
        "<audio>" + fGetValueFromSCO(oSCO, "cmi__student_preference__audio") + "</audio>" +
        "<language>" + fGetValueFromSCO(oSCO, "cmi__student_preference__language") + "</language>" +
        "<speed>" + fGetValueFromSCO(oSCO, "cmi__student_preference__speed") + "</speed>" +
        "<text>" + fGetValueFromSCO(oSCO, "cmi__student_preference__text") + "</text>" +
        "</student_preference>" +
        sInteractions +
        "</cmi></sco>";

    return sRetXML;
}

//--------------------------------------------------------------------------------
//Get Set Functions
//--------------------------------------------------------------------------------

function fGetValueFromMasterTemplate(lParam) {
    eval("var sRetVal = gMasterTemplate." + lParam);
    if (fIsUndefined(sRetVal)) {
        sRetVal = "";
    }

    return sRetVal;
}

function fGetValueFromSCO(lSCO, lParam) {

    if (!lSCO) {
        return "";
    }

    eval("var sRetVal = lSCO." + lParam);
    if (fIsUndefined(sRetVal)) {
        sRetVal = "";
    }

    return sRetVal;
}

function fGetItemNodeObject(lIdentifier) {
    var arrNodes = arrManifestNodes; //NTrees["COOLjsTree"].Nodes;
    for (var i = 0; i < arrNodes.length; i++) {
        if (arrNodes[i].identifier == lIdentifier) {
            return arrNodes[i];
        }
    }
    return null;
}

function fGetValue(lNode, lParam) {
    var sRetVal = lNode[lParam];
    if (sRetVal) {
        return sRetVal;
    }
    else {
        return "";
    }
}

function fGetDataFromManifest(lParam) {
    var sNodeId = fGetNode("Identifier");

    var oNode = fGetItemNodeObject(sNodeId);
    return fGetValue(oNode, lParam);
}

function fGetSCO(lIdentifier) {
    for (var i = 0; i < arrSCO.length; i++) {

        if (arrSCO[i].identifier == lIdentifier) {

            return arrSCO[i];
        }
    }

    return null;
}

function fGetCurrentSCO() {
    var sIdentifier = fGetNode("Identifier");
    return fGetSCO(sIdentifier);
}

function fNodeExistsInCurrentSco(lParam) {
    var sRetVal;
    var oSCO = fGetCurrentSCO();

    if (oSCO) {
        eval("sRetVal = oSCO." + lParam);
        return (!fIsUndefined(sRetVal));
    }
}

function fDirectGetDataFormUserDataXML(lParam) {
    var sRetVal;
    var oSCO = fGetCurrentSCO();

    if (oSCO) {
        eval("sRetVal = oSCO." + lParam);
        if (fIsUndefined(sRetVal)) {
            sRetVal = "";
        }
    }

    return sRetVal;
}

function fDirectSetDataToUserDataXML(lParam, lData) {
    var oSCO = fGetCurrentSCO();

    if (oSCO) {
        eval("oSCO." + lParam + " = lData");
    }
}

function fGetNode(lParam) {
    return gArrCurrentStatus[lParam];
}

function fSetNode(lParam, lVal) {
    gArrCurrentStatus[lParam] = lVal;
    return true;
}

function fGoToLaunchSco(sSingleScoLaunch) {
    var sBookmark = sSingleScoLaunch;

    if (sBookmark != "") {
        var oNode = fGetItemNodeObject(sBookmark);
        var lUrl = fGetValue(oNode, "href");
        var lIdentifier = fGetValue(oNode, "identifier");

        fOpenScoAsset(gContentPath + lUrl, lIdentifier);
    }
}


