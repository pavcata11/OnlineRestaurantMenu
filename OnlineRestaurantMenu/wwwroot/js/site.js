
$(document).ready(function () {
    $('.count').prop('disabled', true);
    $(document).on('click', '.plus', function () {
        var count = $(this).closest(".qty").find(".count");
        // var count = $(this).siblings(".count"); //example with siblings
        // var count = $(this).parent().find(".count"); //example with parent
        $(count).val(parseInt($(count).val()) + 1);
    });
    $(document).on('click', '.minus', function () {
        var count = $(this).closest(".qty").find(".count");
        // var count = $(this).siblings(".count"); //example with siblings
        // var count = $(this).parent().find(".count"); //example with parent
        $(count).val(parseInt($(count).val()) - 1);
        if ($(count).val() == 0) {
            $(count).val(1);
        }
    });
});