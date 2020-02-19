

$(document).ready(function () {
    if ($("#UserId").val() == 0)
        $("#UserRoles").val(3);

    if ($("#UserId").val() == 0) {
        $("#TenantUserRoles").val(2);
        $("#TenantUserRoles").prop("disabled", true);

    }

    $('#btnUserSubmit').on("click", function () {
        var status = UserValidation();
        return status;
    });

    $('#btnTenantSubmit').on("click", function () {
        var status = TenantValidation();
        return status;
    });

    $('#btnCourseSubmit').on("click", function () {
        var status = CourseValidation();
        return status;
    });
    $('#btnUserUpload').on("click", function () {
        var status = UserUploadValidation();
        return status;
    });
    
});

function UserValidation() {
    if ($("#FirstName").val() == "") {
        alert("Please enter First Name");
        $("#FirstName").focus();
        return false;
    }

    if ($("#EmailId").val() == "") {
        alert("Please enter Email Id");
        $("#EmailId").focus();
        return false;
    }
    if ($("#Password").val() != "") {
        if ($("#OldPassword").val() == "") {
            alert("Please enter Current Password");
            $("#OldPassword").focus();
            return false;
        }
        if ($("#Password").val() != $("#ConfirmPassword").val()) {
            alert("New Password and Current Password is not matching");
            return false;
        }
    }

    return true;
}

function TenantValidation() {

    if ($("#TenantName").val() == "") {
        alert("Please enter Client Name");
        return false;
    }

    if ($("#TenantDomain").val() == "") {
        alert("Please enter Client Domain");
        return false;
    }

    if ($("#DtActivitionFrom").val() == "") {
        alert("Please enter Activation From Date");
        return false;
    }

    if ($("#DtActivitionTo").val() == "") {
        alert("Please enter Activation To Date");
        return false;
    }

    if ($("#NoOfUserAllowed").val() == "") {
        alert("Please enter Number of User");
        return false;
    }
    return true;
}

function CourseValidation() {

    if ($("#ContentModuleName").val() == "") {
        alert("Please enter Course Name");
        $("#ContentModuleName").focus();
        return false;
    }

    if ($("#ContentModuleURL").val() == "") {
        if ($("#file").val() == "") {
            alert("Please upload Course");
            return false;
        }
        else {
            var index = $("#file").val().indexOf(".zip");
            if (index <= 0) {
                alert("Please upload ZIP file only");
                return false;
            }
        }
    }

    return true;
}

function UserUploadValidation() {

    if ($("#file").val() == "") {
        alert("Please select file");
        return false;
    }
    else {
        var index = $("#file").val().indexOf(".csv");
        if (index <= 0) {
            alert("Please upload Csv file only");
            return false;
        }
    }

    return true;
}

