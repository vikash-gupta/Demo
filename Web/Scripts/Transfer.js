$(function () {
    $("#form1").submit(function () {
        var isValid = $("#form1").valid();
        if (!isValid) {
            return false;
        }
        $.ajax({
            type: "PUT",
            url: "api/transfer",
            data: $("#form1").serialize(),
            success: function (a) {
                $('#message').html(a);
                $("#form1").hide();
            },
            error: function (a) {
                $('#message').html(a.responseText);
                $("#form1").hide();
            }
        });
        
        return false;
    });
    $("#form1").validate();

});