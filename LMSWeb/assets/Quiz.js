var count = 0;
var optionCount = 2;


$(document).ready(function () {
    $(".textarea-editor").summernote();
    //alert($("#hdnResponseData").val())
    if ($("#hdnResponseData").val() != null) {
        SetResponses($("#hdnResponseData").val());
    }
    else {
        SetResponses(111);
    }

    $('#btnAddQuestion').on("click", function () {

        AddQuestion();

        $(".expandableCollapsibleDiv > img").on("click", function (e) {
            var showElementDescription =
                $(this).parents(".expandableCollapsibleDiv").find("ul");

            if ($(showElementDescription).is(":visible")) {
                showElementDescription.hide("fast", "swing");
                $(this).attr("src", "/assets/images/up-arrow.jpg");
            } else {
                showElementDescription.show("fast", "swing");
                $(this).attr("src", "/assets/images/down-arrow.jpg");
            }
        });

    });
    $('#btnQuizSubmit').on("click", function () {
        var status = SaveQuiz();
        return status;
    });

    $('#btnResponseSubmit').on("click", function () {
        var status = SaveResponse();
        return status;
    });

    if ($("#hdnEditData").val() != null) {
        //Edit Questions Population
        var QuizData = JSON.parse($("#hdnEditData").val());
        $("#hdnEditData").val("");
        console.log(QuizData);
        LoadQuestionsForEdit(QuizData);
    }
    else {

    }

});

function ChangeType(id) {

    var selectedType = $("#queType" + id + " option:selected").val();
    var IDs = $("#dvQue" + id + "Options input[id^='que" + id + "rbtn']");
    $.each(IDs, function (index, value) {
        if (selectedType == 2) {
            $('#' + value.id).get(0).type = 'checkbox';
        }
        else {
            $('#' + value.id).get(0).type = 'radio';
        }
    });

}

function AddQuestion() {
    count++;
    optionCount = 2;
    var queHTML = "<div class=\"row col-12\">";

    queHTML += "<div class=\"btn pl-4 pr-4 text-center btn-warning\" >Question " + count + "\</div>";

    queHTML += "<div class=\"row col-12 collapse show\" id=dvQues" + count + ">";
    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
    queHTML += "<select onchange=\"ChangeType(" + count + ")\" id=queType" + count + " class=\"col-6 ml-0 form-control\"><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\">Question Text </label>";
    queHTML += "<textarea class=\"col-6 ml-0 form-control\" id=que" + count + "></textarea>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" id=dvQue" + count + "Options>";
    queHTML += "<label class=\"col-3 p-0\">Options </label>";
    queHTML += "<div class=\"row col-12\">";
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" value=1 name=Options" + count + " id=que" + count + "rbtnOption1 name=que" + count + "rbtnOption1 /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "optionText1></input>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    queHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "option1Feedback></input>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" value=2 name=Options" + count + " id=que" + count + "rbtnOption2 name=que" + count + "rbtnOption2 /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "optionText2></input>";
    queHTML += "<button onclick=\"addOption(" + count + ")\" id=que" + count + "btnOption2 type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    queHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "option2Feedback></input>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "</div>";
    queHTML += "<hr class=\"form-divider\">";
    queHTML += "</div>";


    $('#dvQuestions').append(queHTML);

    $('#que' + count).summernote();
    $('#que' + count + 'option1Feedback').summernote();
    $('#que' + count + 'option2Feedback').summernote();


}

function addOption(queCount) {
    //alert(queCount); alert(optionCount)
    var selectedType = $("#queType" + queCount + " option:selected").val();
    optionCount++;
    var newHTML = "<div class=\"row col-12\" id=dvQue" + queCount + "Option" + optionCount + " style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\"></label>";

    if (selectedType == 1) {
        newHTML += "<input type=\"radio\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    else {
        newHTML += "<input type=\"checkbox\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    newHTML += "<button onclick=\"addOption(" + queCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px; \"> + </button>";
    newHTML += "<button onclick=\"removeOption(" + queCount + "," + optionCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";

    newHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    newHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + queCount + "option" + optionCount + "Feedback></input>";
    newHTML += "</div>";

    newHTML += "</div>";
    $("#dvQue" + queCount + "Options").append(newHTML);
    $('#que' + queCount + 'option' +optionCount+'Feedback').summernote();
}

function addOptionInEdit(queCount) {
    var selectedType = $("#queType" + queCount + " option:selected").val();
    var newHTML = "<div class=\"row col-12\" id=dvque" + queCount + "Option" + optionCount + " style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\"></label>";
    if (selectedType == 1) {
        newHTML += "<input type=\"radio\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    else {
        newHTML += "<input type=\"checkbox\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    newHTML += "<button onclick=\"addOption(" + queCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px; \"> + </button>";
    newHTML += "<button onclick=\"removeOption(" + queCount + "," + optionCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";

    newHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    newHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + queCount + "option" + optionCount + "Feedback></input>";
    newHTML += "</div>";

    newHTML += "</div>";
    $("#dvQue" + queCount + "Options").append(newHTML);
}

function removeOption(queCount, optionCountToRemove) {
    $("#dvQue" + queCount + "Option" + optionCountToRemove).remove();
}

function SaveQuiz() {
    var returnStatus = true;
    if ($("#QuizName").val() == null || $("#QuizName").val() == "") {
        alert("Please enter Quiz Name");
        returnStatus = false;
        return false;
    }
    var IDs = $("#dvQuestions div[id^='dvQues']");
    var questionObj = [];
    $.each(IDs, function (index, value) {        
        var id = value.id.substring(6, value.id.length);    
        if ($("#que" + id).val() == null || $("#que" + id).val() == "") {
            alert("Please enter Question Text");
            returnStatus = false;
            return false;
        }
        item = {}
        item["QuestionTypeId"] = $("#queType" + id + " option:selected").val();
        item["QuestionText"] = $("#que" + id).val();        

        var OptionCheck = false;
        var optionIDs = $("#dvQue" + id + "Options input[id^='que" + id + "rbtnOption']"); //que1rbtnOption1. dvQue1Options
        var optionObj = [];
        $.each(optionIDs, function (index, value) {
            var indexId = value.id.indexOf("Option");//dvQue1021Option1026
            
            var optionId = value.id.substring((indexId +6), value.id.length);
            
            optionItem = {}
            if ($('#' + value.id).is(':checked')) {
                OptionCheck = true;
            }
            if ($('#que' + id + 'optionText' + optionId).val() == null || $('#que' + id + 'optionText' + optionId).val() == "") {
                alert("Please enter Option Text");
                returnStatus = false;
                return false;
            }
            optionItem["CorrectOption"] = $('#' + value.id).is(':checked');
            optionItem["OptionText"] = $('#que' + id + 'optionText' + optionId).val();
            optionItem["OptionFeedback"] = $('#que' + id + 'option' + optionId + 'Feedback').val();
            optionObj.push(optionItem);
        });

        if (!OptionCheck) {
            returnStatus = false;
            alert("Please check Correct Answer");
            return false;
        }

        item["Options"] = optionObj;
        questionObj.push(item);
    });
    $("#hdnData").val(JSON.stringify(questionObj));

    return returnStatus;
}

function SaveResponse() {

    var returnStatus = true;
    var IDs = $("#dvQuestions div[id^='dvQue']");
    var questionObj = [];

    $.each(IDs, function (index, value) {
        var id = value.id.substring(5, value.id.length);
        var optionIDs = $("#dvQue" + id + " input[id^='que" + id + "rbtnOption']");
        var OptionCheck = false;
        var optionObj = [];
        item = {}

        $.each(optionIDs, function (index, value) {
            //var id = value.id.substring(4, value.id.length);
            optionItem = {}

            if ($('#' + value.id).is(':checked')) {//que1rbtnOption1
                var optionIndex = value.id.indexOf("Option");
                var actualIndex = value.id.substring(optionIndex + 6, value.id.length);
                optionItem["questionId"] = id;
                optionItem["optionId"] = actualIndex;
                optionItem["queFeedback"] = $("#queFeedback" + id).val();
                OptionCheck = true;
                optionObj.push(optionItem);
            }

        });
        if (!OptionCheck) {
            returnStatus = false;
            alert("Please select Answer");
            return false;
        }
        questionObj.push(optionObj);
    });
    $("#hdnResponseData").val(JSON.stringify(questionObj));

    return returnStatus;
}

function SetResponses(data) {
    if (data == 111) {

    }
    else {
        var responses = JSON.parse(data);
        console.log(responses);

        $.each(responses, function (index, value) {
            if (value.OptionIds.indexOf(',') > 0) {
                var res = value.OptionIds.split(',');
                $.each(res, function (index, value1) {
                    $('#que' + value.QuestionId + 'rbtnOption' + value1).attr('checked', true);
                });
            }
            else {
                $('#que' + value.QuestionId + 'rbtnOption' + value.OptionIds).attr('checked', true);
            }

            $('#queFeedback' + value.QuestionId).html(value.QuestionFeedback);
        });
    }
}

function LoadQuestionsForEdit(QuizData) {

    console.log(QuizData.TblQuestions);
    $.each(QuizData.TblQuestions, function (index, value) {

        var queHTML = "<div class=\"row col-12\">";

        queHTML += "<div class=\"btn pl-4 pr-4 text-center btn-warning\" >Question " + (index + 1) + "\</div>";

        queHTML += "<div class=\"row col-12 collapse show\" id=dvQues" + value.QuestionId + ">";
        queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
        queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
        queHTML += "<select onchange=\"ChangeType(" + value.QuestionId + ")\" id=queType" + value.QuestionId + " class=\"col-6 ml-0 form-control\"><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";
        queHTML += "</div>";


        queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
        queHTML += "<label class=\"col-3 p-0\">Question Text </label>";
        queHTML += "<textarea class=\"col-6 ml-0 form-control\" id=que" + value.QuestionId + "></textarea>";
        queHTML += "</div>";


        $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
            console.log(valueOption)
            queHTML += "<div class=\"row col-12\" style=margin-top:5px; id=dvQue" + value.QuestionId + "Options>";
            queHTML += "<div class=\"row col-12\" style=margin-top:5px; id=dvQue" + value.QuestionId + "Option" + valueOption.OptionId + ">";
            queHTML += "<div class=\"row col-12\">";
            queHTML += "<label class=\"col-3 p-0\"></label>";
            if (indexOption == 0) {
                if (value.QuestionTypeId == 1) {
                    queHTML += "<input type=\"radio\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                }
            }
            if (indexOption == 1) {
                if (value.QuestionTypeId == 1) {
                    queHTML += "<input type=\"radio\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                }
            }
            if (indexOption > 1) {
                if (value.QuestionTypeId == 1) {
                    queHTML += "<input type=\"radio\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                    queHTML += "<button onclick=\"removeOption(" + value.QuestionId + "," + valueOption.OptionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                    queHTML += "<button onclick=\"removeOption(" + value.QuestionId + "," + valueOption.OptionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";
                }
            }


            queHTML += "</div>";
            queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
            queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
            queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "option" + valueOption.OptionId + "Feedback></textarea>";
            queHTML += "</div>";
            queHTML += "</div>";


        });
        queHTML += "</div>";
        queHTML += "</div>";

        queHTML += "</div>";
        queHTML += "<hr class=\"form-divider\">";
        queHTML += "</div>";
        $('#dvQuestions').append(queHTML);

        $('#queType' + value.QuestionId).val(value.QuestionTypeId);
        $('#que' + value.QuestionId).val(value.QuestionText);
        $('#que' + value.QuestionId).summernote();

        $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
            $('#que' + value.QuestionId + 'optionText' + valueOption.OptionId).val(valueOption.OptionText);

            if (valueOption.CorrectOption)
                $("#que" + value.QuestionId + "rbtnOption" + valueOption.OptionId).attr('checked', 'checked');

            
            $('#que' + value.QuestionId + 'option' + valueOption.OptionId + 'Feedback').val(valueOption.OptionFeedback);
            $('#que' + value.QuestionId + 'option' + valueOption.OptionId + 'Feedback').summernote();
            optionCount = valueOption.OptionId;
        });

    });


    //$('#que' + count).summernote();
}
