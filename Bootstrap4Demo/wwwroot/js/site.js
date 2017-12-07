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
        $inputReason.val(reason)
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
