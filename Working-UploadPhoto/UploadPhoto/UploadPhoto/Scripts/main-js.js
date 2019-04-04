$(document).ready(function () {

    $("#succesful").hide();
    $("#error").hide();

    $("#upload").click(function () {
        var photo = $("#file").val();

        if (photo >= 0) {
            $("#error").show();
            $("#succesful").hide();
        } else {
            $("#succesful").show();
            $("#error").hide();
        }

        $("#picture").removeAttr( "src" );
        $("#picture").attr( "src", photo);
        //$("#picture").add(value,photo);
    });

    $("#file").click(function () {
        $("#succesful").hide();
        $("#error").hide();
    });



});
