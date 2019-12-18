

$(document).ready(function () {
    if ($("#UserId").val() == 0)
        $("#UserRoles").val(3);

    $('#btnUserSubmit').on("click", function () {
        if ($("#FirstName").val() == "") {
            alert("Please enter First Name");
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
    });

});