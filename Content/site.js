

$('body').on('click', '#pagerHolder .pagination a:not(.disabled)', function (event) {    
    event.preventDefault();
    if ($(this).closest("li").hasClass("disabled")) {
        return false;
    }

    var url = $(this).attr('href');
    if (!url) {
        return;
    }

    
    $.ajax({
        url: url,
        success: function (result) {          
            $("#resultHolder").html(result);           
        }
    });
});


function SetActiveLink(linkID) {

    $link = $("#"+linkID);
    $navMain = $("#navMain");

    var activeItems = $navMain.find("li .active");
    activeItems.removeClass("active");

    if ($link.hasClass("active") == false) {
        $link.addClass("active");
    }


}

