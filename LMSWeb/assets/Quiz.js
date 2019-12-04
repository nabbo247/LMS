var count = 0;
var optionCount = 2;

$(document).ready(function () {

    $('#btnAddQuestion').on("click", function () {
        AddQuestion();

    });
    $('#btnQuizSubmit').on("click", function () {
        var status = SaveQuiz();
        return status;
    });

});

function AddQuestion() {
    count++;
    optionCount = 2;
    var queHTML = "<div class=\"row col-12\">";
    queHTML += "<div class=\"row col-12\" id=dvQues" + count + ">";
    queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
    queHTML += "<select id=queType" + count + "><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";

    queHTML += "<div class=\"row col-12\">";
    queHTML += "<label class=\"col-3 p-0\">Question Text </label>";
    queHTML += "<textarea class=\"col-6 ml-0 form-control\" id=que" + count + "></textarea>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" id=dvQue" + count + "Options>";
    queHTML += "<label class=\"col-3 p-0\">Options </label>";
    queHTML += "<div class=\"row col-12\">";
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" value=1 name=Options" + count + " id=que" + count + "rbtnOption1 name=que" + count + "rbtnOption1 /><input type=text class=\"col-6 ml-0 form-control\" id=que" + count + "optionText1></input>";
    queHTML += "</div>";
    queHTML += "<div class=\"row col-12\">";
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" value=2 name=Options" + count + " id=que" + count + "rbtnOption2 name=que" + count + "rbtnOption2 /><input type=text class=\"col-6 ml-0 form-control\" id=que" + count + "optionText2></input>";
    queHTML += "<button onclick=\"addOption(" + count + ")\" id=que" + count + "btnOption2 type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
    queHTML += "</div>";
    queHTML += "</div>";
    queHTML += "<hr class=\"form-divider\">";
    queHTML += "</div>";
    queHTML += "</div>";

    $('#dvQuestions').append(queHTML);

}

function addOption(queCount) {
    optionCount++;
    var newHTML = "<div class=\"row col-12\" id=dvque" + queCount + "Option" + optionCount + ">";
    newHTML += "<label class=\"col-3 p-0\"></label>";
    newHTML += "<input type=\"radio\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\" id=que" + queCount + "optionText" + optionCount + "></input>";
    newHTML += "<button onclick=\"addOption(" + queCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
    newHTML += "<button onclick=\"removeOption(" + queCount + "," + optionCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";
    newHTML += "</div>";
    $("#dvQue" + queCount + "Options").append(newHTML);
}

function removeOption(queCount, optionCountToRemove) {   
    $("#dvque" + queCount + "Option" + optionCountToRemove).remove();

}

function SaveQuiz() {
    var IDs = $("#dvQuestions div[id^='dvQues']");
    var questionObj = [];
    $.each(IDs, function (index, value) {
        var id = value.id.substring(value.id.length - 1, value.id.length);
        item = {}
        item["QuestionTypeId"] = $("#queType" + id + " option:selected").val();
        item["QuestionText"] = $("#que" + id).val();

        var optionIDs = $("#dvQue" + id + "Options input[id^='que" + id + "rbtnOption']");
        var optionObj = [];
        $.each(optionIDs, function (index, value) {
            var optionId = value.id.substring(value.id.length - 1, value.id.length);
            optionItem = {}
            optionItem["CorrectOption"] = $('#' + value.id).is(':checked');
            optionItem["OptionText"] = $('#que' + id + 'optionText' + optionId).val();
            optionObj.push(optionItem);
        });
        item["Options"] = optionObj;
        questionObj.push(item);
    });
    $("#hdnData").val(JSON.stringify(questionObj));

    return true;
}