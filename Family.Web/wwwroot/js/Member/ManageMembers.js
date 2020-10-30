function memberShow() {
    $('#task_View').hide();
    $('#addmember_View').show();
}
$(document).on("click", ".avtr-select", function () {
    $(".avtr-select").each(function (index, val) {
        if (val.className.includes('avtar-border')) {
            val.classList.remove('avtar-border');
        }
    });

    let avtar = $(this).data('avatar');
    $('#avatar').val(avtar);
    $(this).addClass('avtar-border');
});

$(document).ready(function () {
    getMembers();
});

let colors = ['#fe4e4e', '#feb84e', '#feec4e', '#3ec732', '#4efef3', '#4e7ffe'];

function getMembers() {
    $.ajax({
        type: "GET",
        url: "https://localhost:44376/api/member/getMembers",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            let membersHtml = "";
            let indx = 0;
            $.each(data, function (key, value) {
                membersHtml = membersHtml +
                    '<div class="menu-item col-10 offset-1 p-3 my-4 p-sm-2">' +
                    '<div class="avtar mr-3" style=" background-color:' + colors[indx] + '"> </div>' +
                    '<div class="label">' + value.firstName + " " + value.lastName + '</div>' +
                    '</div>'

                indx = indx + 1;

                if (indx === 6) {
                    indx = 0;
                }
            });

            $("#member-list").html('')
            $("#member-list").html(membersHtml)
        }
    });
}

function addMember() {
    var model = {
        FirstName: $('#firstName').val(),
        LastName: $('#lastName').val(),
        EmailAddress: $('#email').val(),
        Roles: $('#role').val(),
        Avatar: $('#avatar').val()
    };

    $.ajax({
        type: "POST",
        url: "https://localhost:44376/api/member/addMember",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(model),
        success: function (response) {
            if (response) {
                $('#firstName').val('');
                $('#lastName').val('');
                $('#email').val('');
                $('#role').val('');
                $(".avtr-select").each(function (index, val) {
                    if (val.className.includes('avtar-border')) {
                        val.classList.remove('avtar-border');
                    }
                });
                getMembers();
            }
            else {
                alert('Something went wrong, please try again later.');
            }
        }
    });
}