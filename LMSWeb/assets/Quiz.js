var count = 0;
var optionCount = 2;
var quizQueIds = [];
var currentIndex = 0;


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
        //Edit Questions Population
        var QuizData = JSON.parse($("#hdnEditData").val());
        $("#hdnEditData").val("");
        LoadQuestionsForEdit(QuizData);
    }
    if ($("#hdnLaunchData").val() != null) {
        //Launch Quiz for User to Attempt
        var QuizLaunchData = JSON.parse($("#hdnLaunchData").val());
        $("#hdnLaunchData").val("");
        LaunchQuiz(QuizLaunchData);
    }
    
    if ($("#hdnViewData").val() != null) {
        //View Quiz for Admin
        var QuizViewData = JSON.parse($("#hdnViewData").val());
        $("#hdnViewData").val("");
        ViewQuiz(QuizViewData);
    }

    if ($("#hdnReviewData").val() != null) {        
        //Review Quiz after Submit the Responses
        var QuizReviewData = JSON.parse($("#hdnReviewData").val());
        //console.log(QuizReviewData);
        $("#hdnReviewData").val("");
        ReviewQuiz(QuizReviewData);
    }

    // Highlight selected option
    $('.option-container > input[type="radio"]:selected').parent().addClass('selected-ans');
    $('.option-container > input[type="radio"],.option-container > input[type="checkbox"]').on('click', (e) => {
        if (e.target.checked) {
            $('.option-container').removeClass('selected-ans');
            e.target.parentNode.classList.add('selected-ans');
        }
    });

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
    var queHTML = "<div class=\"row col-12 que-container \" id=queContainer" + count + ">";
    queHTML += "<div class=\"row col-12\" >";
    queHTML += "<div class=\"btn pl-4 pr-4 text-center btn-warning\" data-toggle=\"collapse\" data-target=#dvQues" + count + ">Question</div>";
    queHTML += "<div class=\"btn btn-danger offset-10\" onclick=\"deleteQuestion(" + count + ")\" >Delete</div>";
    queHTML += "</div>";
    queHTML += "<div class=\"row col-12 collapse show in\" id=dvQues" + count + ">";
    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
    queHTML += "<select onchange=\"ChangeType(" + count + ")\" id=queType" + count + " class=\"col-6 ml-0 form-control\"><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
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
    queHTML += "<button onclick=\"addOption(" + count + ")\" id=que" + count + "btnOption2 type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
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
    newHTML += "<button onclick=\"addOption(" + queCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px; \"> + </button>";
    newHTML += "<button onclick=\"removeOption(" + queCount + "," + optionCount + ")\" id=que" + queCount + "btnOption" + optionCount + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";
    
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
        item["QuestionTypeId"] = $("#queType" + id + " option:selected").val();
        item["QuestionText"] = $("#que" + id).val();

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
                optionItem["queFeedback"] = $("#queFeedback" + id).val();
                OptionCheck = true;
                optionObj.push(optionItem);
            }

        });        
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

        var queHTML = "<div class=\"row col-12 que-container\" id=queContainer" + value.QuestionId + ">";
        queHTML += "<div class=\"row col-12\" >";
        queHTML += "<div class=\"btn pl-4 pr-4 text-center btn-warning\" data-toggle=\"collapse\" data-target=#dvQues" + value.QuestionId + ">Question</div>";
        //queHTML += "<div class=\"offset-4\">Dinesh</div>";
        queHTML += "<div class=\"btn btn-danger offset-10\" onclick=\"deleteQuestion(" + value.QuestionId + ")\" >Delete</div>";
        queHTML += "</div>";
        
        queHTML += "<div class=\"row col-12 collapse\" id=dvQues" + value.QuestionId + ">";
        queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
        queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
        queHTML += "<select onchange=\"ChangeType(" + value.QuestionId + ")\" id=queType" + value.QuestionId + " class=\"col-6 ml-0 form-control\"><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";
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
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                }
            }
            if (indexOption > 1) {
                if (value.QuestionTypeId == 1) {
                    queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                    queHTML += "<button onclick=\"removeOption(" + value.QuestionId + "," + valueOption.OptionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";
                }
                else {
                    queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "optionText" + valueOption.OptionId + "></input>";
                    queHTML += "<button onclick=\"addOption(" + value.QuestionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
                    queHTML += "<button onclick=\"removeOption(" + value.QuestionId + "," + valueOption.OptionId + ")\" id=que" + value.QuestionId + "btnOption" + valueOption.OptionId + " type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> - </button>";
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
    var queHTML = `<div class="container-fluid  que-container mt-3">`;
    $.each(QuizLaunchData.TblQuestions, function (index, value) {
        item = {}
        item["QuestionId"] = value.QuestionId;

        quizQueIds.push(item);
        queHTML += "<div class=\"row question-div\" id=dvQue" + value.QuestionId + ">";
        queHTML += "<div class=\"col-12 px-4 py-4\" >";
        queHTML += "<label>" + value.QuestionText + " </label>";
        queHTML += "</div>";

        if (value.QuestionTypeId == 1) {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += `<div class="col-12 option-container">`;
                queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += `<span class="option-text"> ${valueOption.OptionText} </span>`;
                queHTML += "</div>";
            });
        }
        else {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += `<div class="col-12 option-container">`;
                queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += `<span class="option-text"> ${valueOption.OptionText} </span>`;
                queHTML += "</div>";
            });
        }

        queHTML += "<div class=\"col-12 border-top que-feedback\">";
        queHTML += "<label class=\"col-3 p-0\">Question Feedback</label>";
        queHTML += "<textarea class=\"col-6 ml-0 form-control textarea-editor\"   id=queFeedback" + value.QuestionId + "></textarea>";
        queHTML += "</div>";
        queHTML += "</div>";

        // append paginator list
        const paginatorHtml = ` <li data-queid='dvQue${value.QuestionId}'>${index + 1}</li>`;
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

        }
    });

    $('#btnNext').on("click", function () {
        if (currentIndex != (quizQueIds.length - 1)) {
            currentIndex++;
            NextPrevQuestion();
        }
    });
}

function ViewQuiz(QuizViewData) {
    console.log('QuizLaunchData : ', QuizViewData);
    var queHTML = `<div class="container-fluid  que-container mt-3">`;
    $.each(QuizViewData.TblQuestions, function (index, value) {
        item = {}
        item["QuestionId"] = value.QuestionId;

        quizQueIds.push(item);
        queHTML += "<div class=\"row question-div\" id=dvQue" + value.QuestionId + ">";
        queHTML += "<div class=\"col-12 px-4 py-4\" >";
        queHTML += "<label>" + value.QuestionText + " </label>";
        queHTML += "</div>";

        if (value.QuestionTypeId == 1) {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += `<div class="col-12 option-container">`;
                queHTML += "<input type=\"radio\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += `<span class="option-text"> ${valueOption.OptionText} </span>`;
                queHTML += "<div style=\"margin-left:25px;\"><b>Option Feedback</b> " + valueOption.OptionFeedback+" </div>";
                queHTML += "</div>";
            });
        }
        else {
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                queHTML += `<div class="col-12 option-container">`;
                queHTML += "<input type=\"checkbox\" class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                queHTML += `<span class="option-text"> ${valueOption.OptionText} </span>`;
                //queHTML += "<div style=\"margin-left:25px;\"><b>Option Feedback</b> " + valueOption.OptionFeedback + " </div>";
                queHTML += "</div>";
            });
        }
        if (value.QuestionTypeId == 2) {
            queHTML += "<div class=\"col-12 option-container\">";            
            queHTML += "<label><b>Feedback if correctly answered</b></label>";
            queHTML += "<div>" + value.CorrectFeedback + "</div>";           
            queHTML += "</div>";

            queHTML += "<div class=\"col-12 option-container\">";
            queHTML += "<label><b>Feedback if incorrectly answered</b></label>";
            queHTML += "<div>" + value.InCorrectFeedback + "</div>";
            queHTML += "</div>";
        }
        queHTML += "</div>";

        // append paginator list
        const paginatorHtml = ` <li data-queid='dvQue${value.QuestionId}'>${index + 1}</li>`;
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

        }
    });

    $('#btnNext').on("click", function () {
        if (currentIndex != (quizQueIds.length - 1)) {
            currentIndex++;
            NextPrevQuestion();
        }
    });
}

function NextPrevQuestion() {
    $.each(quizQueIds, function (indexQue, valueQue) {
        if (indexQue == currentIndex) {
            $('#dvQue' + valueQue.QuestionId).show();
            const id = valueQue.QuestionId;
            console.log('id:', id);
            const p = $('[data-queid=dvQue' + id + ']');
            $(p).addClass('active-paginator');
            console.log('p : ', p);
        }
        else {
            $('#dvQue' + valueQue.QuestionId).hide();
            const id = valueQue.QuestionId;
            console.log('id:', id);
            const p = $('[data-queid=dvQue' + id + ']');
            $(p).removeClass('active-paginator');
        }
        //$('#paginator-list > li').removeClass('active-paginator');
    });

}


function ReviewQuiz(QuizReviewData) {
   
    var queHTML = `<div class="container-fluid  que-container mt-3">`;
    
    $.each(QuizReviewData.TblQuestions, function (index, value) {
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
        queHTML += "<div class=\"row question-div  border-bottom\" style=\"margin-bottom:20px;\" id=dvQue" + value.QuestionId + ">";
        queHTML += "<div class=\"col-12\" >";
        if (isAttempted)
            queHTML += "<label><p><b>Question " + (index + 1) + "</b></p>" + value.QuestionText + " </label>";
        else
            queHTML += "<label><p><b>Question " + (index + 1) + " - Not Attempted </b></p>" + value.QuestionText + "</label>";
        queHTML += "</div>";

        if (value.QuestionTypeId == 1) {
            var attemptedFeedback = "";
            var correctPoint = 0;
            $.each(value.TblQuestionOptions, function (indexOption, valueOption) {
                
                queHTML += `<div class="col-12 option-container">`;
                if (isAttempted) {
                    if (valueOption.OptionId == response.OptionIds) {
                        //console.log(valueOption);
                        queHTML += "<input type=\"radio\" checked disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                        
                        attemptedFeedback = valueOption.OptionFeedback;
                    }
                    else
                        queHTML += "<input type=\"radio\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                }
                else
                    queHTML += "<input type=\"radio\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                if (valueOption.CorrectOption) {
                    queHTML += `<span class="option-text"><b> ${valueOption.OptionText}</b> </span>`;
                    queHTML += `<span class="option-text"> (Correct Answer)</span>`;
                    if (valueOption.OptionId == response.OptionIds) {
                        correctPoint++;
                    }
                }
                else {
                    queHTML += `<span class="option-text"> ${valueOption.OptionText} </span>`;
                }
                queHTML += "</div>";
            });
            if (attemptedFeedback != "") {
                if (correctPoint == 0)
                    queHTML += "<div class=\"col-12\"><span class=\"option-text\">0/1 point</span></div>";
                else
                    queHTML += "<div class=\"col-12\"><span class=\"option-text\">1/1 point</span></div>";
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
                queHTML += `<div class="col-12 option-container">`;
                var isRespondedOption = false;
                if (isAttempted) {
                    var opnIds = response.OptionIds.split(",");
                    //console.log(opnIds)
                    $.each(opnIds, function (indexOp, valueOp) {                        
                        if (valueOp == valueOption.OptionId) {
                            isRespondedOption = true;                            
                        }
                    });


                    if (isRespondedOption)
                        queHTML += "<input type=\"checkbox\" disabled checked class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                    else
                        queHTML += "<input type=\"checkbox\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";
                }
                else
                    queHTML += "<input type=\"checkbox\" disabled class=\"radio-margin\" value=1 name=Options" + value.QuestionId + " id=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " name=que" + value.QuestionId + "rbtnOption" + valueOption.OptionId + " />";

                if (valueOption.CorrectOption) {
                    correctCount++;
                    correctIds.push(valueOption.OptionId);
                    queHTML += `<span class="option-text"><b> ${valueOption.OptionText}</b> </span>`;
                    queHTML += `<span class="option-text"> (Correct Answer)</span>`;
                }
                else {
                    queHTML += `<span class="option-text"> ${valueOption.OptionText} </span>`;
                }

                queHTML += "</div>";
            });
            if (response != null && response.OptionIds != null) {
                var isCorrect = false;
                console.log(response.OptionIds)
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
                    queHTML += "<div class=\"col-12\"><span class=\"option-text\">1/1 point</span></div>";
                    queHTML += "&nbsp;&nbsp;&nbsp;<span class=\"option-text\">" + value.CorrectFeedback + "</span>";
                }
                else {
                    queHTML += "<div class=\"col-12\"><span class=\"option-text\">0/1 point</span></div>";
                    queHTML += "&nbsp;&nbsp;&nbsp; <span class=\"option-text\">" + value.InCorrectFeedback + "</span>";
                }                
            }
            else
                queHTML += "<div class=\"col-12\"><span class=\"option-text\">0/1 point</span></div>";
        }

        

        if (isAttempted) {
            queHTML += "<div class=\"col-12 que-feedback\">";
            queHTML += "<label class=\"col-3 p-0\"><b>User Feedback</b></label>";
            queHTML += "<span class=\"option-text\">" + response.QuestionFeedback +"</span>";
            queHTML += "</div>";
        }
        //queHTML += "<hr class=\"form-divider\">";
        queHTML += "</div>";
        
        // append paginator list
        const paginatorHtml = ` <li data-queid='dvQue${value.QuestionId}'>${index + 1}</li>`;
        $('#paginator-list').append(paginatorHtml);
    });
    queHTML += "</div>";
    $('#dvQuestions').append(queHTML);
}