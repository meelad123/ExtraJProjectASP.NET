$(document).ready(function () {
    $('#user-name').focus(
            function () {
                $('.login-field-user').css({
                    "border-left": "solid 3px #337ab7",
                    "background-color": "#fbfbfb"
                    })
            }
        ).blur(
            function () {
                $('.login-field-user').css({
                    "border-left": "solid 3px rgba(0, 0, 0, 0.00)",
                    "background-color": "#fff"
                });
            }
        );
    $('#user-password').focus(
            function () {
                $('.login-field-pass').css({
                    "border-left": "solid 3px #337ab7",
                    "background-color": "#fbfbfb"
                })
            }
        ).blur(
            function () {
                $('.login-field-pass').css({
                    "border-left": "solid 3px rgba(0, 0, 0, 0.00)",
                    "background-color": "#fff"
                });
            }
        );
});