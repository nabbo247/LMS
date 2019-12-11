var count = 0;
var optionCount = 2;

$(document).ready(function () {
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


});

function ChangeType(id) {
   
    var selectedType = $("#queType" + id +" option:selected").val();    
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

    queHTML += "<div class=\"btn pl-4 pr-4 text-center btn-warning\" data-toggle=\"collapse\" data-target=\"#dvQues" + count + "\">Question " + count + "\</div>";

    queHTML += "<div class=\"row col-12 collapse show\" id=dvQues" + count + ">";
    queHTML += "<label class=\"col-3 p-0\">Question Type </label>";
    queHTML += "<select onchange=\"ChangeType(" + count + ")\" id=queType" + count + " class=\"col-6 ml-0 form-control\"><option value=\"1\" >Single Select</option><option value=\"2\">Multiple Select</option></select>";

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
    queHTML += "<label class=\"col-3 p-0\"></label>";
    queHTML += "<input type=\"radio\" value=2 name=Options" + count + " id=que" + count + "rbtnOption2 name=que" + count + "rbtnOption2 /><input type=text class=\"col-6 ml-0 form-control\"   id=que" + count + "optionText2></input>";
    queHTML += "<button onclick=\"addOption(" + count + ")\" id=que" + count + "btnOption2 type=\"button\" class=\"btn pl-4 pr-4 text-center btn-warning pull-right\" style=\"margin-left: 5px;\"> + </button>";
    queHTML += "</div>";
    queHTML += "</div>";

    queHTML += "</div>";
    queHTML += "<hr class=\"form-divider\">";
    queHTML += "</div>";
    

    $('#dvQuestions').append(queHTML);

}

function addOption(queCount) {
    var selectedType = $("#queType" + queCount + " option:selected").val(); 
    optionCount++;
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
    newHTML += "</div>";
    $("#dvQue" + queCount + "Options").append(newHTML);
}

function removeOption(queCount, optionCountToRemove) {
    $("#dvque" + queCount + "Option" + optionCountToRemove).remove();

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
        var id = value.id.substring(value.id.length - 1, value.id.length);
        
        item = {}
        item["QuestionTypeId"] = $("#queType" + id + " option:selected").val();
        item["QuestionText"] = $("#que" + id).val();
        
        if ($("#que" + id).val() == null || $("#que" + id).val() == "") {
            alert("Please enter Question Text");
            returnStatus = false;
            return false;
        }

        var OptionCheck = false;
        var optionIDs = $("#dvQue" + id + "Options input[id^='que" + id + "rbtnOption']");
        var optionObj = [];
        $.each(optionIDs, function (index, value) {
            var optionId = value.id.substring(value.id.length - 1, value.id.length);
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
   
    var IDs = $("#dvQuestions div[id^='que+']");
    var questionObj = [];
    
    $.each(IDs, function (index, value) {
        var id = value.id.substring(4, value.id.length);
        alert(id);

        var optionIDs = $("#que+" + id + " input[id^='que" + id + "Option']");
        console.log(optionIDs);

        $.each(optionIDs, function (index, value) {
            //var id = value.id.substring(4, value.id.length);
            alert(value); alert(value.id);

            

        });

    });

    var returnStatus = false;

    return returnStatus;
}
