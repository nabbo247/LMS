var count = 0;
var optionCount = 2;
var quizQueIds = [];
var currentIndex = 0;
$body = $("body");



var tim;
var min = 00;
var sec = 00;
var f = new Date();

function customSubmit(someValue) {
    document.questionForm.minute.value = min;
    document.questionForm.second.value = sec;
    document.questionForm.submit();
}

function examTimer() {
    if (parseInt(sec) > 0) {

        document.getElementById("showtime").innerHTML = "Time Remaining :" + min + " Minutes ," + sec + " Seconds";
        sec = parseInt(sec) - 1;
        tim = setTimeout("examTimer()", 1000);
    }
    else {

        if (parseInt(min) == 0 && parseInt(sec) == 0) {
            document.getElementById("showtime").innerHTML = "Time Remaining :" + min + " Minutes ," + sec + " Seconds";
            alert("Time Up. Quiz will get submited automatically!");
            $("#completeTime").val(0);
            $("#btnResponseSubmit").click();

        }

        if (parseInt(sec) == 0) {
            document.getElementById("showtime").innerHTML = "Time Remaining :" + min + " Minutes ," + sec + " Seconds";
            min = parseInt(min) - 1;
            sec = 59;
            tim = setTimeout("examTimer()", 1000);
        }

    }
}
$(document).ready(function () {
    
    $(".textarea-editor").summernote();


    if ($("#hdnResponseData").val() != null && $("#hdnResponseData").val() != '') {
        SetResponses($("#hdnResponseData").val());
    }
    else {
        //SetResponses(111);
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
        $("#dvLoading").show();
        //Edit Questions Population
        var QuizData = JSON.parse($("#hdnEditData").val());
        //$("#hdnEditData").val("");
        LoadQuestionsForEdit(QuizData);
    }
    if ($("#hdnLaunchData").val() != null) {
        //Launch Quiz for User to Attempt
        var QuizLaunchData = JSON.parse($("#hdnLaunchData").val());
        //$("#hdnLaunchData").val("");
        LaunchQuizNew(QuizLaunchData);
    }

    if ($("#hdnViewData").val() != null) {
        //View Quiz for Admin
        var QuizViewData = JSON.parse($("#hdnViewData").val());
        //$("#hdnViewData").val("");
        ViewQuiz(QuizViewData);
    }

    if ($("#hdnReviewData").val() != null) {
        //Review Quiz after Submit the Responses
        var QuizReviewData = JSON.parse($("#hdnReviewData").val());
        console.log("Dinesh :- " + QuizReviewData);
        //$("#hdnReviewData").val("");
        ReviewQuiz(QuizReviewData);
    }

    // Highlight selected option
    $('.option-container > input[type="radio"]:selected').parent().addClass('selected-ans');
    //$('.option-container > input[type="radio"].option-container > input[type="checkbox"]').on('click', (e) => {
    //    if (e.target.checked) {
    //        $('.option-container').removeClass('selected-ans');
    //        e.target.parentNode.classList.add('selected-ans');
    //    }
    //});

    $('.option-container > input[type="checkbox"]:selected').parent().addClass('selected-ans');

   
});

function ChangeType(id) {

    var selectedType = $("#queType" + id + " option:selected").val();
    var IDs = $("#dvQue" + id + "Options input[id^='que" + id + "rbtn']");

    $.each(IDs, function (index, value) {
        if (selectedType == 2) {
            $('#' + value.id).get(0).type = 'checkbox';

            var optionIndex = value.id.indexOf("Option");
            var actualOptionId = value.id.substring(optionIndex + 6, value.id.length);
            console.log('que' + id + 'option' + actualOptionId + 'FeedbackDiv')
            //que1option2FeedbackDiv
            $('#que' + id + 'option' + actualOptionId + 'FeedbackDiv').hide();
            $('#que' + id + 'CorrectFeedbackDiv').show();
            $('#que' + id + 'InCorrectFeedbackDiv').show();
        }
        else {
            $('#' + value.id).get(0).type = 'radio';
            var optionIndex = value.id.indexOf("Option");
            var actualOptionId = value.id.substring(optionIndex + 6, value.id.length);
            $('#que' + id + 'option' + actualOptionId + 'FeedbackDiv').show();

            $('#que' + id + 'CorrectFeedbackDiv').hide();
            $('#que' + id + 'InCorrectFeedbackDiv').hide();
        }
    });

}

function AddQuestion() {
    count++;
    optionCount = 2;
    var queHTML = "<div class=\"que-container container-fluid mt-4 mb-4 pl-4 pr-4 pt-4 pb-4\" id=queContainer" + count + ">";
    queHTML += "<div class=\"row\" >";
    queHTML += "<div class=\"col question-btn btn text-center btn-primary profle-submit-btn\" data-toggle=\"collapse\" data-target=#dvQues" + count + ">Question</div>";
    queHTML += "<div class=\"col text-right\"  ><button onclick=\"deleteQuestion(" + count + ")\" class=\"btn btn-danger delete-btn\">Delete</button></div>";
    queHTML += "</div>";
    queHTML += "<div class=\"row col-12 collapse show in\" id=dvQues" + count + ">";
    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
    queHTML += "<select onchange=\"ChangeType(" + count + ")\" id=queType" + count + " class=\"col-6 ml-0 form-control\"><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";
    queHTML += "<div>";
    queHTML += "&nbsp;&nbsp;&nbsp;<input type=\"checkbox\" id=chkIsRandom" + count + ">";
    queHTML += "&nbsp;<b>Random Options</b>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12 mb-4\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\">Question Text </label>";
    queHTML += "<div class=\"col-9 p-0\">";
    queHTML += "<textarea class=\"col-6 ml-0 form-control\" id=que" + count + "></textarea>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" id=dvQue" + count + "Options>";
    queHTML += "<label class=\"col-3 p-0 \">Options </label>";
    queHTML += "<div class=\"row col-12\">";
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + count + " id=que" + count + "rbtnOption1 name=que" + count + "rbtnOption1 /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "optionText1></input>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px; id=que" + count + "option1FeedbackDiv>";
    queHTML += "<div class=\"col-9 offset-3 p-0\">";
    queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + count + "option1Feedback></textarea>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" class=\"radio-margin\" value=2 name=Options" + count + " id=que" + count + "rbtnOption2 name=que" + count + "rbtnOption2 /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "optionText2></input>";
    queHTML += "<button onclick=\"addOption(" + count + ")\" id=que" + count + "btnOption2 type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> + </button>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;\" id=que" + count + "option2FeedbackDiv>";
    queHTML += "<div class=\"col-9 offset-3 p-0\">";
    queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + count + "option2Feedback></textarea>";
    queHTML += "</div>";
    queHTML += "</div>";
    queHTML += "</div>";


    queHTML += "<div class=\"row col-12\" style=margin-top:5px;\" id=que" + count + "CorrectFeedbackDiv>";
    queHTML += "<div class=\"col-9 offset-3 p-0\">";
    queHTML += "<label class=\"col-6 p-0\">Feedback if correctly answered</label>";
    queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + count + "CorrectFeedback></textarea>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;\" id=que" + count + "InCorrectFeedbackDiv>";
    queHTML += "<div class=\"col-9 offset-3 p-0\">";
    queHTML += "<label class=\"col-6 p-0\">Feedback if incorrectly answered</label>";
    queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + count + "InCorrectFeedback></textarea>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "</div>";
    queHTML += "</div>";

    $('#dvQuestions').append(queHTML);

    $('#que' + count).summernote();
    $('#que' + count + 'option1Feedback').summernote();
    $('#que' + count + 'option2Feedback').summernote();

    $('#que' + count + 'CorrectFeedback').summernote();
    $('#que' + count + 'InCorrectFeedback').summernote();

    $('#que' + count + 'CorrectFeedbackDiv').hide();
    $('#que' + count + 'InCorrectFeedbackDiv').hide();

}

function deleteQuestion(queCount) {
    //alert(queCount)
    if (confirm("Are you sure you want to delete this Question?")) {
        $("#queContainer" + queCount).remove();
    }
    else {
        return false;
    }

}

function addOption(queCount) {
    var selectedType = $("#queType" + queCount + " option:selected").val();
    optionCount++;
    var newHTML = "<div class=\"row col-12\" id=dvQue" + queCount + "Option" + optionCount + " style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\"></label>";

    if (selectedType == 1) {
        newHTML += "<input type=\"radio\" class=\"radio-margin\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    else {
        newHTML += "<input type=\"checkbox\" class=\"radio-margin\"  name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    newHTML += "<button onclick=\"addOption(" + queCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px; \"> + </button>";
    newHTML += "<button onclick=\"removeOption(" + queCount + "," + optionCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> - </button>";

    newHTML += "<div class=\"col-9 offset-3 p-0\" style=margin-top:5px; id=que" + queCount + "option" + optionCount + "FeedbackDiv>";
    newHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    newHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + queCount + "option" + optionCount + "Feedback></textarea>";
    newHTML += "</div>";

    newHTML += "</div>";
    $("#dvQue" + queCount + "Options").append(newHTML);
    $('#que' + queCount + 'option' + optionCount + 'Feedback').summernote().addClass('col-9');

    if (selectedType == 2) {
        $('#que' + count + 'option' + optionCount + 'FeedbackDiv').hide();
        //$('#que' + count + 'option2Feedback').summernote();
    }

}

function addOptionInEdit(queCount) {
    var selectedType = $("#queType" + queCount + " option:selected").val();
    var newHTML = "<div class=\"row col-12\" id=dvque" + queCount + "Option" + optionCount + " style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\"></label>";
    if (selectedType == 1) {
        newHTML += "<input type=\"radio\" class=\"radio-margin\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    else {
        newHTML += "<input type=\"checkbox\" class=\"radio-margin\" name=Options" + queCount + " id=que" + queCount + "rbtnOption" + optionCount + " name=que" + queCount + "rbtnOption" + optionCount + " /><input type=text class=\"col-6 ml-0 form-control\"  id=que" + queCount + "optionText" + optionCount + "></input>";
    }
    newHTML += "<button onclick=\"addOption(" + queCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px; \"> + </button>";
    newHTML += "<button onclick=\"removeOption(" + queCount + "," + optionCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";

    newHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    newHTML += "<div class=\"col-9 offset-3 p-0\" style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    newHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + queCount + "option" + optionCount + "Feedback></input>";
    newHTML += "</div>";
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
        item["QuestionId"] = id;
        item["QuestionTypeId"] = $("#queType" + id + " option:selected").val();
        item["QuestionText"] = $("#que" + id).val();
        item["isRandomOption"] = $("#chkIsRandom" + id).is(":checked");

        if ($("#queType" + id + " option:selected").val() == 2) {
            console.log($("#que" + id + "CorrectFeedback").val())
            console.log($("#que" + id + "InCorrectFeedback").val())

            item["CorrectFeedback"] = $("#que" + id + "CorrectFeedback").val();//que2CorrectFeedback
            item["InCorrectFeedback"] = $("#que" + id + "InCorrectFeedback").val();
        }
        else {
            item["CorrectFeedback"] = "";
            item["InCorrectFeedback"] = "";
        }

        var OptionCheck = false;
        var optionIDs = $("#dvQue" + id + "Options input[id^='que" + id + "rbtnOption']"); //que1rbtnOption1. dvQue1Options
        var optionObj = [];
        $.each(optionIDs, function (index, value) {
            var indexId = value.id.indexOf("Option");//dvQue1021Option1026

            var optionId = value.id.substring((indexId + 6), value.id.length);

            optionItem = {}
            if ($('#' + value.id).is(':checked')) {
                OptionCheck = true;
            }
            if ($('#que' + id + 'optionText' + optionId).val() == null || $('#que' + id + 'optionText' + optionId).val() == "") {
                alert("Please enter Option Text");
                returnStatus = false;
                return false;
            }
            optionItem["OptionId"] = optionId;
            optionItem["CorrectOption"] = $('#' + value.id).is(':checked');
            optionItem["OptionText"] = $('#que' + id + 'optionText' + optionId).val();
            if ($("#queType" + id + " option:selected").val() == 1) {
                optionItem["OptionFeedback"] = $('#que' + id + 'option' + optionId + 'Feedback').val();
            }
            else {
                optionItem["OptionFeedback"] = "";
            }
            console.log($('#que' + id + 'option' + optionId + 'Feedback').val())
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
    //return false;
    return returnStatus;
}

function SaveResponse() {

    var returnStatus = true;
    var IDs = $("#dvQuestions div[id^='dvQue']");
    var questionObj = [];
    console.log($("#completeTime").val());
    if ($("#completeTime").val() != "0" && $("#completeTime").val() != "") {
        $("#completeTime").val(document.getElementById("showtime").innerHTML);
    }
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
                var actualOptionId = value.id.substring(optionIndex + 6, value.id.length);
                optionItem["questionId"] = id;
                optionItem["optionId"] = actualOptionId;
                optionItem["queFeedback"] = null;
                OptionCheck = true;
                optionObj.push(optionItem);
            }

        });
        questionObj.push(optionObj);
    });
    $("#hdnResponseData").val(JSON.stringify(questionObj));
    console.log(questionObj);
    return returnStatus;
}

function SetResponses(data) {
    if (data == 111) {

    }
    else {
        var responses = JSON.parse(data);
        console.log(responses)
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

    $('#btnQuizSubmit').html("<b>Save</b>");
    console.log(QuizData)
    $.each(QuizData.TblQuestions, function (index, value) {
        var queFirstLine = "";
        var queIndex = value.QuestionText.indexOf("?");
        if (queIndex <= 0) {
            queIndex = value.QuestionText.indexOf(".");

            if (queIndex <= 0) {
                queFirstLine = value.QuestionText;
            }
        }
        if (queFirstLine == "") {
            queFirstLine = value.QuestionText.substring(0, (queIndex + 1));
        }

        queFirstLine = queFirstLine.replace("<div>", "");
        queFirstLine = queFirstLine.replace("</div>", "");

        var queHTML = "<div class=\"que-container container-fluid mt-4 mb-4 pl-4 pr-4 pt-4 pb-4\" id=queContainer" + value.QuestionId + ">";
        queHTML += "<div class=\"row\"  >";
        queHTML += "<div class=\"col question-btn btn text-center btn-primary profle-submit-btn\" data-toggle=\"collapse\" data-target=#dvQues" + value.QuestionId + ">Question</div>";
        queHTML += "<div class=\"col\"  style=margin-left:5px;>" + queFirstLine + "</div>";
        queHTML += "<div class=\"btn btn-danger delete-btn\" onclick=\"deleteQuestion(" + value.QuestionId + ")\" >Delete</div>";
        queHTML += "</div>";

        queHTML += "<div class=\"row col-12 collapse\" id=dvQues" + value.QuestionId + ">";
        queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
        queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
        queHTML += "<select onchange=\"ChangeType(" + value.QuestionId + ")\" id=queType" + value.QuestionId + " class=\"col-6 ml-0 form-control\"><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";
        queHTML += "&nbsp;&nbsp;&nbsp;<input type=\"checkbox\" id=chkIsRandom" + value.QuestionId + ">";
        queHTML += "&nbsp;<b>Random Options</b>";
        queHTML += "</div>";

        queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
        queHTML += "<label class=\"col-3 p-0 \">Question Text </label>";
        queHTML += "<div class=\"col-9 p-0\">";
        queHTML += "<textarea class=\"col-6 ml-0 form-control\" id=que" + value.QuestionId + "></textarea>";
        queHTML += "</div>";
        queHTML += "</div>";
        queHTML += "<label class=\"col-3 p-0 hello\">Options </label>";
        queHTML += "<div class=\"row col-12\" style=margin-top:5px; id=dvQue" + value.QuestionId + "Options>";
        $.each(value.TblQuestionOptions, function (indexOption, valueOption) {

            queHTML += "<div class=\"row col-12\" style=margin-top:5px; id=dvQue" + value.QuestionId + "Option" + valueOption.OptionId + ">";
            queHTML += "<label class=\"col-3 p-0\"></label>";
            if (indexOption == 0) {
                if (value.QuestionTypeId == 1) {
                    queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                }
            }
            if (indexOption == 1) {
                if (value.QuestionTypeId == 1) {
                    queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"col question-btn-for-option text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> + </button>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> + </button>";
                }
            }
            if (indexOption > 1) {
                if (value.QuestionTypeId == 1) {
                    queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> + </button>";
                    queHTML += "<button onclick=\"removeOption(" + value.QuestionId + "," + valueOption.OptionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> - </button>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> + </button>";
                    queHTML += "<button onclick=\"removeOption(" + value.QuestionId + "," + valueOption.OptionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"col question-btn-for-option btn text-center btn-primary profle-submit-btn-for-option\" style=\"margin-left: 5px;\"> - </button>";
                }
            }

            queHTML += "<div class=\"row col-12\" style=margin-top:5px; id=que" + value.QuestionId + "option" + valueOption.OptionId + "FeedbackDiv>";
            queHTML += "<div class=\"col-9 offset-3 p-0\">";
            queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
            queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "option" + valueOption.OptionId + "Feedback></textarea>";
            queHTML += "</div>";
            queHTML += "</div>";

            queHTML += "</div>";
        });
        queHTML += "</div>";

        queHTML += "<div class=\"row col-12\" style=margin-top:5px;\" id=que" + value.QuestionId + "CorrectFeedbackDiv>";
        queHTML += "<div class=\"col-9 offset-3 p-0\">";
        queHTML += "<label class=\"col-6 p-0\">Feedback if correctly answered</label>";
        queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "CorrectFeedback></textarea>";
        queHTML += "</div>";
        queHTML += "</div>";

        queHTML += "<div class=\"row col-12\" style=margin-top:5px;\" id=que" + value.QuestionId + "InCorrectFeedbackDiv>";
        queHTML += "<div class=\"col-9 offset-3 p-0\">";
        queHTML += "<label class=\"col-6 p-0\">Feedback if incorrectly answered</label>";
        queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "InCorrectFeedback></textarea>";
        queHTML += "</div>";
        queHTML += "</div>";

        queHTML += "</div>";
        queHTML += "</div>";

        queHTML += "</div>";
        queHTML += "</div>";
        $('#dvQuestions').append(queHTML);

        $('#queType' + value.QuestionId).val(value.QuestionTypeId);
        if (value.isRandomOption)
            $('#chkIsRandom' + value.QuestionId).attr('checked', 'checked');

        $('#que' + value.QuestionId).val(value.QuestionText);
        $('#que' + value.QuestionId).summernote();

        $('#que' + value.QuestionId + 'CorrectFeedback').val(value.CorrectFeedback);
        $('#que' + value.QuestionId + 'CorrectFeedback').summernote();
        $('#que' + value.QuestionId + 'InCorrectFeedback').val(value.InCorrectFeedback);
        $('#que' + value.QuestionId + 'InCorrectFeedback').summernote();
        if (value.QuestionTypeId == 1) {
            $('#que' + value.QuestionId + 'CorrectFeedbackDiv').hide();
            $('#que' + value.QuestionId + 'InCorrectFeedbackDiv').hide();
        }
        $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
            $('#que' + value.QuestionId + 'optionText' + valueOption.OptionId).val(valueOption.OptionText);

            if (valueOption.CorrectOption)
                $("#que" + value.QuestionId + "rbtnOption" + valueOption.OptionId).attr('checked', 'checked');

            if (value.QuestionTypeId == 1) {
                $('#que' + value.QuestionId + 'option' + valueOption.OptionId + 'Feedback').val(valueOption.OptionFeedback);
                $('#que' + value.QuestionId + 'option' + valueOption.OptionId + 'Feedback').summernote();

                $('#que' + value.QuestionId + 'option' + valueOption.OptionId + 'FeedbackDiv').show();
            }
            else {
                console.log(value.QuestionId)
                console.log(valueOption.OptionId)
                $('#que' + value.QuestionId + 'option' + valueOption.OptionId + 'Feedback').summernote();
                $('#que' + value.QuestionId + 'option' + valueOption.OptionId + 'FeedbackDiv').hide(); //que1042option1076FeedbackDiv
            }
            optionCount = valueOption.OptionId;
        });

        count = value.QuestionId;
    });
}


function LaunchQuiz(QuizLaunchData) {
    console.log('QuizLaunchData : ', QuizLaunchData);
    $('#btnPrev').hide();
    $('#btnResponseSubmit').hide();
    var queHTML = "<div class=\"container-fluid  que-container mt-3\">";
    $.each(QuizLaunchData.TblQuestions, function (index, value) {
        item = {}
        item["QuestionId"] = value.QuestionId;

        quizQueIds.push(item);
        queHTML += "<div class=\"row question-div\" id=dvQue" + value.QuestionId + ">";
        queHTML += "<div class=\"col-12 px-4 py-4\" >";
        queHTML += "<label>" + value.QuestionText + " </label>";
        queHTML += "</div>";
        if (value.isRandomOption)
            value.TblQuestionOptions = shuffle(value.TblQuestionOptions);
        if (value.QuestionTypeId == 1) {            
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += "<label class=\"col-12 option-container\">";
                queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += "<span class=\"option-text\">"+valueOption.OptionText+" </span>";
                queHTML += "</label>";
            });
        }
        else {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += "<label class=\"col-12 option-container\">";
                queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += "<span class=\"option-text\"> "+valueOption.OptionText+" </span>";
                queHTML += "</label>";
            });
        }
        
        queHTML += "</div>";
        // append paginator list
        const paginatorHtml = "<li data-queid=dvQue" + value.QuestionId + ">" + index + 1 + "</li>";
        $('#paginator-list').append(paginatorHtml);
    });
    queHTML += "</div>";
    $('#dvQuestions').append(queHTML);


    // click handler for paginator
    $('#paginator-list > li').on('click', function () {
        $('#paginator-list > li').removeClass('active-paginator');
        $(this).addClass('active-paginator');
        const getCurrQueId = $(this).attr('data-queid');
        $('.question-div').hide();
        $('#' + getCurrQueId).show();

        var queId = getCurrQueId.substring(5, getCurrQueId.length)

        $.each(quizQueIds, function (indexQue, valueQue) {
            if (valueQue["QuestionId"] == queId) {
                currentIndex = indexQue;
                //alert(quizQueIds.length);
                //alert(currentIndex);
                if (quizQueIds.length == (currentIndex + 1)) {
                    $('#btnNext').hide();
                    $('#btnPrev').show();
                    $('#btnResponseSubmit').show();
                }
                else {
                    if (currentIndex != 0) {
                        $('#btnPrev').show();
                        $('#btnNext').show();
                        $('#btnResponseSubmit').hide();
                    }
                    else {
                        $('#btnPrev').hide();
                        $('#btnNext').show();
                        $('#btnResponseSubmit').hide();
                    }
                }
            }
        });
    });



    $.each(quizQueIds, function (indexQue, valueQue) {
        $('#queFeedback' + valueQue.QuestionId).summernote();
        if (indexQue == 0) {
            $('#dvQue' + valueQue.QuestionId).show();
        }
        else {
            $('#dvQue' + valueQue.QuestionId).hide();
        }
    });
    NextPrevQuestion();
    $('#btnPrev').on("click", function () {
        if (currentIndex > 0) {
            currentIndex--;
            NextPrevQuestion();
            if (currentIndex == 0) {
                $('#btnPrev').hide();
            }
            if (currentIndex != (quizQueIds.length - 1)) {
                //$('#btnPrev').hide();
                $('#btnNext').show();
                $('#btnResponseSubmit').hide();
            }
        }
    });

    $('#btnNext').on("click", function () {
        if (currentIndex != (quizQueIds.length - 1)) {
            currentIndex++;
            NextPrevQuestion();
            if (currentIndex > 0) {
                $('#btnPrev').show();
            }
        }
        if (currentIndex == (quizQueIds.length - 1)) {
            $('#btnNext').hide();
            $('#btnResponseSubmit').show();
        }
    });

    $('#btnCancel').on("click", function () {
        location.reload();

    });
    if (QuizLaunchData.Duration > 0) {
        min = QuizLaunchData.Duration;
        examTimer();
    }

}

function LaunchQuizNew(QuizLaunchData) {
    console.log('QuizLaunchData : ', QuizLaunchData);
    $('#btnPrev').hide();
    $('#btnResponseSubmit').hide();
    var queHTML = "<div class=\"user-quiz-container container-fluid\">";
    $.each(QuizLaunchData.TblQuestions, function (index, value) {
        item = {}
        item["QuestionId"] = value.QuestionId;

        quizQueIds.push(item);
        queHTML += "<div class=\"que-container row mt-4 pt-2 pb-2\" id=dvQue" + value.QuestionId + ">";
        queHTML += "<div class=\"col-12 que-text remove-padding\" >";
        queHTML += "<label class=\"font-weight-bold\">" + value.QuestionText + " </label>";
        
        queHTML += "<h6 class=\"font-weight-bold\">Options</h6>";
        queHTML += "<ul class=\"option-list list-unstyled add-padding\">";

        if (value.isRandomOption)
            value.TblQuestionOptions = shuffle(value.TblQuestionOptions);
        if (value.QuestionTypeId == 1) {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += "<li>";
                queHTML += "<label>";
                queHTML += "<input type=\"radio\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += "<span class=\"ml-2\"> "+valueOption.OptionText+" </span>";
                queHTML += "</label>";
                queHTML += "</li>";
            });
        }
        else {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += "<li>";
                queHTML += "<label>";
                queHTML += "<input type=\"checkbox\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += "<span class=\"ml-2\"> "+valueOption.OptionText+" </span>";
                queHTML += "</label>";
                queHTML += "</li>";
            });
        }
        queHTML += "</ul>";
        queHTML += "</div>";
        //queHTML += "<div class=\"col-4 blue-color text-right\">Weightage Point: 1</div>";
        queHTML += "<div class=\"options-container col-12 mt-3\">";
        queHTML += "</div>";
        queHTML += "</div>";
        // append paginator list
        const paginatorHtml = " <li class=\"list-inline-item\" data-queid='dvQue" + value.QuestionId + "'>" + (index + 1) + "</li>";
        $('#paginator-list').append(paginatorHtml);
    });
    queHTML += "</div>";
    $('#dvQuestions').append(queHTML);


    // click handler for paginator
    $('#paginator-list > li').on('click', function () {
        $('#paginator-list > li').removeClass('active-page');
        $(this).addClass('active-page');
        const getCurrQueId = $(this).attr('data-queid');
        $('.que-container').hide();
        $('#' + getCurrQueId).show();

        var queId = getCurrQueId.substring(5, getCurrQueId.length)

        $.each(quizQueIds, function (indexQue, valueQue) {
            if (valueQue["QuestionId"] == queId) {
                currentIndex = indexQue;
                //alert(quizQueIds.length);
                //alert(currentIndex);
                if (quizQueIds.length == (currentIndex + 1)) {
                    $('#btnNext').hide();
                    $('#btnPrev').show();
                    $('#btnResponseSubmit').show();
                }
                else {
                    if (currentIndex != 0) {
                        $('#btnPrev').show();
                        $('#btnNext').show();
                        $('#btnResponseSubmit').hide();
                    }
                    else {
                        $('#btnPrev').hide();
                        $('#btnNext').show();
                        $('#btnResponseSubmit').hide();
                    }
                }
            }
        });
    });



    $.each(quizQueIds, function (indexQue, valueQue) {
        $('#queFeedback' + valueQue.QuestionId).summernote();
        if (indexQue == 0) {
            $('#dvQue' + valueQue.QuestionId).show();
        }
        else {
            $('#dvQue' + valueQue.QuestionId).hide();
        }
    });
    NextPrevQuestion();
    $('#btnPrev').on("click", function () {
        if (currentIndex > 0) {
            currentIndex--;
            NextPrevQuestion();
            if (currentIndex == 0) {
                $('#btnPrev').hide();
            }
            if (currentIndex != (quizQueIds.length - 1)) {
                //$('#btnPrev').hide();
                $('#btnNext').show();
                $('#btnResponseSubmit').hide();
            }
        }
    });

    $('#btnNext').on("click", function () {
        if (currentIndex != (quizQueIds.length - 1)) {
            currentIndex++;
            NextPrevQuestion();
            if (currentIndex > 0) {
                $('#btnPrev').show();
            }
        }
        if (currentIndex == (quizQueIds.length - 1)) {
            $('#btnNext').hide();
            $('#btnResponseSubmit').show();
        }
    });

    $('#btnCancel').on("click", function () {
        location.reload();

    });
    if (QuizLaunchData.Duration > 0) {
        min = QuizLaunchData.Duration;
        examTimer();
    }

}
function ViewQuiz(QuizViewData) {
    console.log('QuizLaunchData : ', QuizViewData);
    $('#btnPrev').hide();
    $('#btnResponseSubmit').hide();
    var queHTML = "<div class=\"user-quiz-container container-fluid\">";
    $.each(QuizViewData.TblQuestions, function (index, value) {
        item = {}
        item["QuestionId"] = value.QuestionId;

        quizQueIds.push(item);
        queHTML += "<div class=\"que-container row mt-4 pt-2 pb-2\" id=dvQue" + value.QuestionId + ">";
        queHTML += "<div class=\"col-12 que-text font-weight-bold\" >";
        queHTML += "<label>" + value.QuestionText + " </label>";
        queHTML += "</div>";
        //queHTML += "<div class=\"col-2 blue-color text-right\">Weightage Point: 1</div>";
        queHTML += "<div class=\"options-container col-12 mt-3\">";
        queHTML += "<h6 class=\"font-weight-bold\">Options</h6>";
        queHTML += "<ul class=\"option-list list-unstyled\">";

        if (value.QuestionTypeId == 1) {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += "<li>";
                queHTML += "<label>";
                queHTML += "<input type=\"radio\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += "<span class=\"ml-2\"> "+valueOption.OptionText+" </span>";
                queHTML += "</label>";
                queHTML += "</li>";
                
            });
        }
        else {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += "<li>";
                queHTML += "<label>";
                queHTML += "<input type=\"checkbox\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += "<span class=\"ml-2\"> "+valueOption.OptionText+" </span>";
                queHTML += "</label>";
                queHTML += "</li>";
            });
        }
        
        queHTML += "</ul>";
        queHTML += "</div>";
        queHTML += "</div>";

        // append paginator list
        const paginatorHtml = " <li class=\"list-inline-item\" data-queid='dvQue"+value.QuestionId+"'>"+(index + 1)+"</li>";
        $('#paginator-list').append(paginatorHtml);
    });
    queHTML += "</div>";
    $('#dvQuestions').append(queHTML);
    
    // click handler for paginator
    $('#paginator-list > li').on('click', function () {
        $('#paginator-list > li').removeClass('active-page');
        $(this).addClass('active-page');
        const getCurrQueId = $(this).attr('data-queid');
        $('.que-container').hide();
        $('#' + getCurrQueId).show();

        var queId = getCurrQueId.substring(5, getCurrQueId.length)

        $.each(quizQueIds, function (indexQue, valueQue) {
            if (valueQue["QuestionId"] == queId) {
                currentIndex = indexQue;
                //alert(quizQueIds.length);
                //alert(currentIndex);
                if (quizQueIds.length == (currentIndex + 1)) {
                    $('#btnNext').hide();
                    $('#btnPrev').show();
                    $('#btnResponseSubmit').show();
                }
                else {
                    if (currentIndex != 0) {
                        $('#btnPrev').show();
                        $('#btnNext').show();
                        $('#btnResponseSubmit').hide();
                    }
                    else {
                        $('#btnPrev').hide();
                        $('#btnNext').show();
                        $('#btnResponseSubmit').hide();
                    }
                }
            }
        });
    });
   
    $.each(quizQueIds, function (indexQue, valueQue) {
        $('#queFeedback' + valueQue.QuestionId).summernote();
        if (indexQue == 0) {
            $('#dvQue' + valueQue.QuestionId).show();
        }
        else {
            $('#dvQue' + valueQue.QuestionId).hide();
        }
    });
    NextPrevQuestion();

    $('#btnPrev').on("click", function () {
        if (currentIndex > 0) {
            currentIndex--;
            NextPrevQuestion();
            if (currentIndex == 0) {
                $('#btnPrev').hide();
            }
            if (currentIndex != (quizQueIds.length - 1)) {
                //$('#btnPrev').hide();
                $('#btnNext').show();
                $('#btnResponseSubmit').hide();
            }
        }
    });

    $('#btnNext').on("click", function () {

        if (currentIndex != (quizQueIds.length - 1)) {
            currentIndex++;
            NextPrevQuestion();
            if (currentIndex > 0) {
                $('#btnPrev').show();
            }
        }
        if (currentIndex == (quizQueIds.length - 1)) {
            $('#btnNext').hide();
            $('#btnResponseSubmit').show();
        }

    });

    $('#btnCancel').on("click", function () {
        location.reload();
    });

    if (QuizViewData.Duration > 0) {
        min = QuizViewData.Duration;
        examTimer();
    }
}

function NextPrevQuestion() {
    $.each(quizQueIds, function (indexQue, valueQue) {
        if (indexQue == currentIndex) {
            $('#dvQue' + valueQue.QuestionId).show();
            const id = valueQue.QuestionId;
            console.log('id:', id);
            const p = $('[data-queid=dvQue' + id + ']');
            $(p).addClass('active-page');
            console.log('p : ', p);
        }
        else {
            $('#dvQue' + valueQue.QuestionId).hide();
            const id = valueQue.QuestionId;
            console.log('id:', id);
            const p = $('[data-queid=dvQue' + id + ']');
            $(p).removeClass('active-page');
        }
        //$('#paginator-list > li').removeClass('active-paginator');
    });

}


function ReviewQuiz(QuizReviewData) {
    console.log("New Learner Review Quiz")
    var queHTML = "<div class=\"user-quiz-container container-fluid\">";

    $.each(QuizReviewData.TblQuestions, function (index, value) {
        console.log(value);
        var isAttempted = false;
        var response = Object;
        $.each(QuizReviewData.TblResponses, function (indexRe, valueRe) {
            if (valueRe.QuestionId == value.QuestionId) {
                isAttempted = true;
                response = valueRe;
            }
        });

        item = {}
        item["QuestionId"] = value.QuestionId;
        quizQueIds.push(item);
        queHTML += "<div class=\"que-container row mt-4 pt-2 pb-2\" style=\"margin-bottom:20px;\" id=dvQue" + value.QuestionId + ">";
        queHTML += "<div class=\"col-12 que-text remove-padding\" >";
        if (isAttempted)
            queHTML += "<label class=\" font-weight-bold\"><p><b>Question " + (index + 1) + "</b></p>" + value.QuestionText + "</label>";
        else
            queHTML += "<label class=\" font-weight-bold\"><p><b>Question " + (index + 1) + " - Not Attempted </b></p>" + value.QuestionText + "</label>";
       
         
        if (value.QuestionTypeId == 1) {
            var attemptedFeedback = "";
            var correctPoint = 0;
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {

                queHTML += "<div class=\"col-12 option-container\">";
                if (isAttempted) {

                    if (valueOption.OptionId == response.OptionIds) {
                        //console.log('valueOption : ',valueOption);
                        // queHTML += "<input type=\"radio\" checked disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";

                        if (!valueOption.CorrectOption) {
                            queHTML += "<span class=\"option-text wrong-answer\"> <i class=\"fa fa-times-circle red-color radio-margin\"></i></span>";
                        } else {
                            queHTML += "<span class=\"option-text right-answer\"> <i class=\"fa fa-check-circle green-color radio-margin\"></i></span>";
                        }
                        attemptedFeedback = valueOption.OptionFeedback;
                    }
                    else
                        queHTML += "<input type=\"radio\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";

                }
                else
                    queHTML += "<input type=\"radio\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                if (valueOption.CorrectOption) {
                    //queHTML += `<span class="option-text ${valueOption.CorrectOption ? 'right-answer' : ''}"><b> ${valueOption.OptionText}</b> </span>`;
                    if (valueOption.CorrectOption)
                        queHTML += "<span class=\"option-text right-answer\"><b>" + valueOption.OptionText + "</b> </span>";
                    else
                        queHTML += "<span class=\"option-text\">" + valueOption.OptionText + " </span>";
                    if (valueOption.OptionId == response.OptionIds) {
                        correctPoint++;
                    }
                }
                else {
                    //queHTML += `<span class="option-text ${valueOption.CorrectOption ? 'right-answer' : ''}"> ${valueOption.OptionText} </span>`;
                    if (valueOption.CorrectOption)
                        queHTML += "<span class=\"option-text right-answer\"><b>" + valueOption.OptionText + "</b> </span>";
                    else
                        queHTML += "<span class=\"option-text\">" + valueOption.OptionText + " </span>";
                }
                queHTML += "</div>";
            });
            if (attemptedFeedback != "") {
                if (correctPoint == 0)
                    queHTML += "<div class=\"col-12 mt-2\"><span class=\"option-text\">0/1 point</span></div>";
                else
                    queHTML += "<div class=\"col-12 mt-2\"><span class=\"option-text\">1/1 point</span></div>";
                queHTML += "<div class=\"col-12\"><span class=\"option-text\">" + attemptedFeedback + " </span></div>";
            }
            else {
                if (correctPoint == 0)
                    queHTML += "<div class=\"col-12\"><span class=\"option-text\">0/1 point</span></div>";
                else
                    queHTML += "<div class=\"col-12\"><span class=\"option-text\">1/1 point</span></div>";
            }
            //queHTML += "</div>";

        }
        else {
            var correctCount = 0;
            var correctIds = [];
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                //console.log('valueOption : ', valueOption);
                queHTML += "<div class=\"col-12 option-container\">";
                var isRespondedOption = false;
                if (isAttempted) {
                    var opnIds = response.OptionIds.split(",");
                    //console.log(opnIds)
                    $.each(opnIds, function (indexOp, valueOp) {
                        if (valueOp == valueOption.OptionId) {
                            isRespondedOption = true;
                        }
                    });


                    if (isRespondedOption) {
                        if (valueOption.CorrectOption)
                            queHTML += "<span class=\"option-text right-answer\"> <i class=\"fa fa-check-circle green-color radio-margin\"></i></span>";
                        else
                            queHTML += "<span class=\"option-text wrong-answer\"> <i class=\"fa fa-times-circle red-color radio-margin\"></i></span>";
                        //queHTML += "<input type=\"checkbox\" disabled checked class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                    } else
                        queHTML += "<input type=\"checkbox\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                }
                else
                    queHTML += "<input type=\"checkbox\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";

                if (valueOption.CorrectOption) {
                    correctCount++;
                    correctIds.push(valueOption.OptionId);
                    queHTML += "<span class=\"option-text right-answer\"><b>"+valueOption.OptionText+"</b> </span>";
                    //queHTML += `<span class="option-text ${valueOption.CorrectOption ? 'right-answer' : ''}"><b> ${valueOption.OptionText}</b> </span>`;
                    //queHTML += `<span class="option-text"><b> ${valueOption.OptionText}</b> </span>`;
                    //queHTML += `<span class="option-text"> (Correct Answer)</span>`;
                }
                else {
                    queHTML += "<span class=\"option-text\">" + valueOption.OptionText + "</span>";
                    //queHTML += `<span class="option-text ${valueOption.CorrectOption ? 'right-answer' : ''}"> ${valueOption.OptionText} </span>`;
                    //queHTML += `<span class="option-text"> ${valueOption.OptionText} </span>`;
                }

                queHTML += "</div>";
            });
            if (response != null && response.OptionIds != null) {
                var isCorrect = false;

                //console.log(response.OptionIds)
                var optionIds = response.OptionIds.split(",");
                if (optionIds.length == correctCount) {
                    var correct = 0;
                    $.each(optionIds, function (index1, value1) {
                        $.each(correctIds, function (index2, value2) {
                            if (value1 == value2) {
                                correct++;
                            }
                        });
                    });
                    if (correct == correctCount) {
                        isCorrect = true;
                    }
                }
                if (isCorrect) {
                    queHTML += "<div class=\"col-12 mt-2\"><span class=\"option-text\">1/1 point</span></div>";
                    queHTML += "&nbsp;&nbsp;&nbsp;<span class=\"option-text\">" + value.CorrectFeedback + "</span>";
                }
                else {
                    queHTML += "<div class=\"col-12 mt-2\"><span class=\"option-text\">0/1 point</span></div>";
                    queHTML += "&nbsp;&nbsp;&nbsp; <span class=\"option-text\">" + value.InCorrectFeedback + "</span>";
                }
            }
            else
                queHTML += "<div class=\"col-12 mt-2\"><span class=\"option-text\">0/1 point</span></div>";
        }

        //if (isAttempted) {
        //    queHTML += "<div class=\"col-12 que-feedback\">";
        //    queHTML += "<label class=\"col-3 p-0\"><b>User Feedback</b></label>";
        //    queHTML += "<span class=\"option-text\">" + response.QuestionFeedback +"</span>";
        //    queHTML += "</div>";
        //}
        //queHTML += "<hr class=\"form-divider\">";
        queHTML += "</div>";
        queHTML += "</div>";

        // append paginator list
        const paginatorHtml = "<li data-queid=\"'dvQue" + value.QuestionId + "'>" + index + 1 + "</li>";
        //const paginatorHtml = `<li data-queid='dvQue${value.QuestionId}'>${index + 1}</li>`;
        $('#paginator-list').append(paginatorHtml);
    });
    queHTML += "</div>";
    $('#dvQuestions').append(queHTML);

    //
    $('.right-answer').parent().addClass('selected-ans');
}

function shuffle(array) {
    var currentIndex = array.length, temporaryValue, randomIndex;

    // While there remain elements to shuffle...
    while (0 !== currentIndex) {

        // Pick a remaining element...
        randomIndex = Math.floor(Math.random() * currentIndex);
        currentIndex -= 1;

        // And swap it with the current element.
        temporaryValue = array[currentIndex];
        array[currentIndex] = array[randomIndex];
        array[randomIndex] = temporaryValue;
    }

    return array;
}