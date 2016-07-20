var GigsDetailsController = function (followingService) {
    var followButton;
    var init = function () {
        $(".js-toggle-follow").click(toggleFollowing);
    };
    var toggleFollowing = function (e) {
        followButton = $(e.target);
        var followeeId = followButton.attr("data-user-id");

        if(followButton.hasClass("btn-default"))
            followingService.createFollowing(followeeId, done, fail);
        else
            followingService.deleteFollowing(followeeId, done, fail);
        };

    var done = function () {
        var text = (followButton.text() == "Follow") ? "UnFollow" : "Follow";
        followButton.toggleClass("btn-default").toggleClass("btn-info").text(text);
    };

    var fail = function () {
        alert("Something failed");
    };

    return {
        init: init
    };


}(FollowingService);