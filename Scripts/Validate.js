$(document).ready(
    $('#regFirstName').change(function () {

        var fnRegex = /^[A-Z]+[A-z]{1,30}$"/g
        var fnvalue = $('#regFirstName').val()
        if (fnRegex.test(fnValue)) {
            $('#regFirstName').css('border', 'Pink');
        }

    })

);
