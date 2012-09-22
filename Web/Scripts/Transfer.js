$(function () {
    $("#form1").submit(function () {
        var jqxhr = $.post('api/transfer', $('#form1').serialize())
            .success(function (a) {
                $('#message').html(a);
                $("#form1").hide();
            })
            .error(function (a) {
                $('#message').html(a.responseText);
                $("#form1").hide();
            });
        return false;
    });
});