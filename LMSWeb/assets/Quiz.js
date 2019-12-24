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
        //Edit Questions Population
        var QuizLaunchData = JSON.parse($("#hdnLaunchData").val());
        $("#hdnLaunchData").val("");
        LaunchQuiz(QuizLaunchData);
    }

    // Highlight selected option
    $('.option-container > input[type="radio"]:selected').parent().addClass('selected-ans');
    $('.option-container > input[type="radio"]').on('click', (e) => {
        if (e.target.checked) {
            $('.option-container').removeClass('selected-ans');
            e.target.parentNode.classList.add('selected-ans');
        }
    });

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

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";    
    queHTML += "<div class=\"col-9 offset-3 p-0\">";
    queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    queHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "option1Feedback></input>";
    queHTML += "</div>";
    queHTML += "</div>";   

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" class=\"radio-margin\" value=2 name=Options" + count + " id=que" + count + "rbtnOption2 name=que" + count + "rbtnOption2 /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "optionText2></input>";
    queHTML += "<button onclick=\"addOption(" + count + ")\" id=que" + count + "btnOption2 type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
    queHTML += "</div>";

    queHTML += "<div class=\"row col-12\" style=margin-top:5px;>";    
    queHTML += "<div class=\"col-9 offset-3 p-0\">";
    queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    queHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "option2Feedback></input>";
    queHTML += "</div>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "</div>";
    //queHTML += "<hr class=\"form-divider\">";
    queHTML += "</div>";

    $('#dvQuestions').append(queHTML);

    $('#que' + count).summernote();
    $('#que' + count + 'option1Feedback').summernote();
    $('#que' + count + 'option2Feedback').summernote();

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

    newHTML += "<div class=\"col-9 offset-3 p-0\" style=margin-top:5px;>";
    newHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
    newHTML += "<input type=text class=\"col-6 ml-0 form-control\"   id=que" + queCount + "option" + optionCount + "Feedback></input>";
    newHTML += "</div>";
    
    newHTML += "</div>";
    $("#dvQue" + queCount + "Options").append(newHTML);
    $('#que' + queCount + 'option' + optionCount + 'Feedback').summernote().addClass('col-9');
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
        //if (!OptionCheck) {
        //    returnStatus = false;
        //    alert("Please select Answer");
        //    return false;
        //}
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
    console.log(QuizData)
    $.each(QuizData.TblQuestions, function (index, value) {

        var queHTML = "<div class=\"row col-12 que-container\" id=queContainer" + value.QuestionId + ">";
        queHTML += "<div class=\"row col-12\" >";
        queHTML += "<div class=\"btn pl-4 pr-4 text-center btn-warning\" data-toggle=\"collapse\" data-target=#dvQues" + value.QuestionId + ">Question</div>";
        //queHTML += "<div class=\"row col-9\">" + value.QuestionText + "</div>";
        queHTML += "<div class=\"btn btn-danger offset-10\" onclick=\"deleteQuestion(" + value.QuestionId + ")\" >Delete</div>";
        queHTML += "</div>";

        //queHTML += "<div class=\"row col-12 collapse show in\" id=dvQues" + count + ">";
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
                   
            queHTML += "<div class=\"col-9 offset-3 p-0\" style=margin-top:5px;>";
            queHTML += "<label class=\"col-3 p-0\">Option Feedback</label>";
            queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=que" + value.QuestionId + "option" + valueOption.OptionId + "Feedback></textarea>";
            queHTML += "</div>";
            
            queHTML += "</div>";
        });
        queHTML += "</div>";
        queHTML += "</div>";
        queHTML += "</div>";

        queHTML += "</div>";        
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
        queHTML += "<label>" + value.QuestionText+" </label>";
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
        queHTML += "<textarea class=\"col-6 ml-0 form-control\"   id=queFeedback" + value.QuestionId+"></textarea>";
        queHTML += "</div>";
        queHTML += "</div>";

        // append paginator list
        const paginatorHtml = ` <li data-queid='dvQue${value.QuestionId}'>${index + 1}</li>`; 
        $('#paginator-list').append(paginatorHtml);
    });
    queHTML += "</div>";
    $('#dvQuestions').append(queHTML);
    //$('#dvQues' + quizQueIds[0].QuestionId).hide();

    // click handler for paginator
    $('#paginator-list > li').on('click', function () {
        $('#paginator-list > li').removeClass('active-paginator');
        $(this).addClass('active-paginator');
        const getCurrQueId = $(this).attr('data-queid');
        $('.question-div').hide();
        $('#' + getCurrQueId).show();        
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

    $('#btnPrev').on("click", function () {
        if (currentIndex > 0) {
            currentIndex--;
            NextPrevQuestion();
           
        }
    });

    $('#btnNext').on("click", function () {
        if (currentIndex != (quizQueIds.length-1)) {
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
                const p = $('[data-queid=dvQue'+id+']');
                $(p).addClass('active-paginator');
                console.log('p : ', p);
            }
            else {                
                $('#dvQue' + valueQue.QuestionId).hide();
            }
            $('#paginator-list > li').removeClass('active-paginator');
        });   

}
