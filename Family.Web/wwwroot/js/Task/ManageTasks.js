function addTask() {
    var model = {
        Subject: $('#task_description').val(),
    };

    $.ajax({
        type: "POST",
        url: "https://localhost:44376/api/task/addTask",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(model),
        success: function (response) {
            if (response) {
                $('#task_description').val('');
                getTasks();
            }
            else {
                alert('Something went wrong, please try again later.');
            }
        }
    });
}


function taskShow() {
    $('#task_View').show();
    $('#addmember_View').hide();
}

function getTasks() {
    $.ajax({
        type: "GET",
        url: "https://localhost:44376/api/task/getTasks",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            let taskHtml = "";
            let indx = 0;
            $.each(data, function (key, value) {
                taskHtml = taskHtml +
                    '<div class="task-item p-3 my-3 row m-0">' +
                    '<div class="col-10 p-0">' +
                    '<input type="checkbox"' + value.IsComplete + '? "checked" : "") name="taskStatus-' + value.Id + '" id="taskStatus-' + value.Id + '" onchange="updateTaskStatus(this)" />' +
                    ' <label for="taskStatus-@Task.Id"> <span class="@(Task.IsComplete ? " done-text" : "")">' + value.subject + '</span></label><br>' +
                    '</div>' +
                    '<div class="col-2 p-0 d-flex justify-content-end align-items-center">' +
                    '<div class="avtar mr-1" style="background-color: @Member.Avatar;"></div>' +
                    '<img class="delete-icon pointer" src="/assets/images/delete-icon.svg" />' +
                    '</div>' +
                    '</div>'

                indx = indx + 1;

                if (indx === 6) {
                    indx = 0;
                }
            });

            $("#task-list").html('')
            $("#task-list").html(taskHtml)
        }
    });
}
$(document).ready(function () {
    getTasks();
});