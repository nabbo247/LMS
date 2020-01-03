

$(document).ready(function () {
    if ($("#UserId").val() == 0)
        $("#UserRoles").val(3);

    $('#btnUserSubmit').on("click", function () {
        var status = UserValidation();
        return status;
    });

    $('#btnTenantSubmit').on("click", function () {
        var status = TenantValidation();
        return status;
    });
});

function UserValidation() {
    if ($("#FirstName").val() == "") {
        alert("Please enter First Name");
        return false;
    }
    if ($("#LastName").val() == "") {
        alert("Please enter Last Name");
        return false;
    }
    if ($("#EmailId").val() == "") {
        alert("Please enter Email Id");
        return false;
    }
    if ($("#Password").val() == "") {
        alert("Please enter Password");
        return false;
    }
    if ($("#dtDOB").val() == "") {
        alert("Please enter Valid Date Of Birth");
        return false;
    }
    if ($("#ContactNo").val() == "") {
        alert("Please enter Contact Number");
        return false;
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