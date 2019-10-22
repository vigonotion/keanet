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
        success: function(result) { console.log(result) }
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
        success: function(result) { console.log(result) }
    });
});