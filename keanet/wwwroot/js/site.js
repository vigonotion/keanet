// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).on('click', '#chkInternetConnection', function() {

    var internetConnection = $(this).is(":checked");

    $.ajax({
        url: "/Home/SetInternetConnection",
        method: "post",
        data: {
            internetConnection: internetConnection
        },
        success: setPrice
    });
});

$(document).on('change', '#txtPhoneLines', function() {
    var phoneLines = $(this).val();

    $.ajax({
        url: "/Home/SetPhoneLines",
        method: "post",
        data: {
            phoneLines: phoneLines
        },
        success: setPrice
    });
});

$(document).on('click', '#add', function() {
    var addPhone = $( "#txtCellPhones" ).val();
    var addPhoneText = $("#txtCellPhones option:selected").text();
    
    $('#txtChosenCellPhones').append($('<option>', {
        value: addPhone,
        text: addPhoneText
    }));
});

$(document).on('click', '#remove', function() {
    var removePhone = $("#txtChosenCellPhones option:selected");

    removePhone.remove();
});

function setPrice(price) {
    $("#price").html(price);
}