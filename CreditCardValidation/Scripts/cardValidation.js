﻿$(function () {

    $("#credit_card_type").append(new Option("", ""));
    $("#credit_card_type").append(new Option("Visa", "Visa"));
    $("#credit_card_type").append(new Option("Master", "Master"));
    $("#credit_card_type").append(new Option("Amex", "Amex"));
    $("#credit_card_type").append(new Option("JCB", "JCB"));
    $("#credit_card_type").append(new Option("Other", "Other"));

    for (var i = 1; i < 13; i++) {
        $("#credit_card_expired_month").append(new Option(i, i));
    }
    var currentYear = (new Date()).getFullYear();
    for (var i = currentYear; i <= currentYear + 35; i++) {
        $("#credit_card_expired_year").append(new Option(i, i));
    }

    $('#credit_card_type').prop('disabled', 'disabled');
    $("#credit_card_number_invalid").hide();

    $("#credit_card_number").on("keypress keyup blur", function (event) {
        $(this).val($(this).val().replace(/[^\d].+/, ""));
        if ((event.which < 48 || event.which > 57)) {
            event.preventDefault();
        }
    });

    $("#credit_card_number").on("keypress keyup blur", function (event) {
        if ($("#credit_card_number").val().charAt(0) == "4") {
            $("#credit_card_type").val("Visa");
        }
        else if ($("#credit_card_number").val().charAt(0) == "5") {
            $("#credit_card_type").val("Master");
        }
        else if ($("#credit_card_number").val().substring(0, 2) == "34" || $("#credit_card_number").val().substring(0, 2) == "36") {
            $("#credit_card_type").val("Amex");
        }
        else if ($("#credit_card_number").val().substring(0, 4) == "3528" || $("#credit_card_number").val().substring(0, 4) == "3589") {
            $("#credit_card_type").val("JCB");
        }
        else if ($("#credit_card_number").val() != "") {
            $("#credit_card_type").val("Other");
        }
        else {
            $("#credit_card_type").val("");
        }

        /**Card Number Validation**/
        if ($("#credit_card_type").val() == "Amex") {
            if ($("#credit_card_number").val().length != 15) {
                console.log($("#credit_card_number").val().length);
                $("#credit_card_number_invalid").show();
            }
            else {
                console.log($("#credit_card_number").val().length);
                $("#credit_card_number_invalid").hide();
            }
        }
        else {
            if ($("#credit_card_number").val().length != 16) {
                $("#credit_card_number_invalid").show();
            }
            else {
                $("#credit_card_number_invalid").hide();
            }
        }



    });

});