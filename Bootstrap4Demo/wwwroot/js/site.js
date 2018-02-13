$(function () {
    "use strict";
    $("#nav-item-active").addClass("active");
});

(function () {
    "use strict";

    var $inputReason = $("#reasonInput");
    var $pickReason = $("#pickReason");

    $("#reasonDropdown a").on("click", function () {
        var reason = $(this).text();
        $inputReason.val(reason);
        $pickReason.text(reason);
    });

}) ();

(function () {
    "use strict";

    var $inputReason = $("#reasonInput").val();
    if ($inputReason)
    {
        $("#pickReason").text($inputReason);
    }

})();

(function () {
    "use strict";

    // .submit()
    // http://api.jquery.com/submit/
    //
    // Via JavaScript
    // https://getbootstrap.com/docs/4.0/components/modal/#via-javascript
    $("#contactForm").on("submit", function () {
        $("#sentDialog").modal("show");
        return false;
    });

    // Events
    // https://getbootstrap.com/docs/4.0/components/modal/#events
    $("#sentDialog").on("hidden.bs.modal", function () {
        window.alert("The modal dialog has been hidden.");
    });
})();

(function () {
    // Example: Enable tooltips everywhere - Tooltips
    // https://getbootstrap.com/docs/4.0/components/tooltips/#example-enable-tooltips-everywhere
    //
    // Options - Tooltips
    // https://getbootstrap.com/docs/4.0/components/tooltips/#options
    $("#contactForm input[type=submit]").tooltip({
        placement: "right",
        delay: { show: 500, hide: 100 }
    });
})();
