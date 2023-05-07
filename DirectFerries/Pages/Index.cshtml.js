$(document).ready(function () {
    $('#nameError').hide();
    $('#surnameError').hide();
    $('#dobError').hide();
    $('#dobMsg').hide();
    datePickerId.max = new Date().toISOString().split("T")[0];
    //hide spinner page is ready
    //$('#loaderId').hide();
});


$(document).on("keyup", "#name", function () {
    let hasValue = $(this).val().length > 0;
    if (hasValue) {
        $('#nameError').hide();
    }
    else {
        $('#nameError').show();
    }
});

$(document).on("keyup", "#surname", function () {
    let hasValue = $(this).val().length > 0;
    if (hasValue) {
        $('#surnameError').hide();
    }
    else {
        $('#surnameError').show();
    }
});

$(document).on("change", "#dob", function () {
    let hasValue = $(this).val().length > 0;
    if (hasValue) {
        $('#dobError').hide();
    }
    else {
        $('#dobError').show();
    }
});

$(document).on("keydown", "#dob", function () {
    $('#dobMsg').show();
    setTimeout(function () { $('#dobMsg').hide(); }, 3000);
    return false;
});

$("form").submit(function (e) {
    $('#nameError').hide();
    $('#surnameError').hide();
    $('#dobError').hide();
    $('#dobMsg').hide();
    let hasName = $('#name').val().length > 0;
    let hasSurname = $('#surname').val().length > 0;
    let hasDOB = $('#dob').val().length > 0;

    if ((hasName) && (hasSurname) && (hasDOB)) {
        //display spinner in case is slow
        //$('#loaderId').show();
    }
    else {
        if (!hasName) {
            $('#nameError').show();
        }
        if (!hasSurname) {
            $('#surnameError').show();
        }
        if (!hasDOB) {
            $('#dobError').show();
        }
        e.preventDefault();
        return false;
    }
});
