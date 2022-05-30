$(".messages").animate({ scrollTop: $(document).height() }, "fast");

$("#profile-img").click(function () {
    $("#status-options").toggleClass("active");
});

$(".expand-button").click(function () {
    $("#profile").toggleClass("expanded");
    $("#contacts").toggleClass("expanded");
});


function newMessage() {
    var t = new Date().toLocaleTimeString();
    var d = new Date().toLocaleDateString();
    var time = t + " " + d + ' ';


    message = $(".message-input input").val();
    if ($.trim(message) == '') {
        return false;
    }


    $('<li class="sent"><p>' + time + '<br>' + message + '</p></li>').appendTo($('.messages ul'));
    $('.message-input input').val(null);
    $('.contact.active .preview').html('<span>You: </span>' + message);
    $(".messages").animate({ scrollTop: $(document).height() }, "fast");
};

// send the message after press the submit key (the arrow send button)
$('.submit').click(function () {
    newMessage();
});

// send the message after press enter key
$(window).on('keydown', function (e) {
    if (e.which == 13) {
        newMessage();
        return false;
    }
});




