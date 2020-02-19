var APIAdapter = new clAPIAdapter();

function clAPIAdapter(){
   this.LMSInitialize=LMSInitialize;
   this.LMSGetValue=LMSGetValue;
   this.LMSSetValue=LMSSetValue;
   this.LMSCommit=LMSCommit;
   this.LMSFinish=LMSFinish;
   this.LMSGetLastError=LMSGetLastError;
   this.LMSGetErrorString=LMSGetErrorString;
   this.LMSGetDiagnostic=LMSGetDiagnostic;
}

function LMSInitialize(str){
    return LMSIntInitialize(str);
}

function LMSGetValue(lParam){
    return LMSIntGetValue(lParam);
}

function LMSSetValue(lParam, lSetValue){
    return LMSIntSetValue(lParam, lSetValue);
}
var gTimerId;
function closetop() {
    top.close();
}
function LMSFinish(lParam) {
    var retLMSFinish;
    try {
        retLMSFinish = LMSIntFinish(lParam);
    }
    catch(e) { parent.alert(e); }

    if (!parent.IsSingleLaunchSco()) {
        parent.ExitServerFrame.fnExitContentPlayer(true);
    }
    else {
        //top.close();
        gTimerId = window.setTimeout("closetop()", 500);  //Solution for ipad closing window issue
    }
    return retLMSFinish;
}

function LMSCommit(lParam){
    return LMSIntCommit(lParam);
}

function LMSGetLastError(){
    var retVal= parseInt(LMSIntGetLastError(),10);
    if(isNaN(retVal))
        return 0;
    else
        return retVal;
}

function LMSGetErrorString(lErrNo){
    return LMSIntGetErrorString(lErrNo);
}

function LMSGetDiagnostic(lErrNo){
    return LMSIntGetDiagnostic(lErrNo);
}