function getProjAjax() {
    $.ajax({
        url: $('#getProjLink').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">ID</th><th scope=\"col\">Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Id + "</td><td>" + data[x].Name + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getTaskAjax() {
    $.ajax({
        url: $('#getTaskLink').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">ID</th><th scope=\"col\">Name</th><th scope=\"col\">Description</th><th scope=\"col\">Creation Date</th><th scope=\"col\">Due Date</th><th scope=\"col\">Project ID</th><th scope=\"col\">User ID</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Id + "</td><td>" + data[x].Name + "</td><td>" + data[x].Description + "</td><td>" + data[x].StartDate + "</td><td>" + data[x].DueDate + "</td><td>" + data[x].Project_Id + "</td><td>" + data[x].User_Id + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getUserAjax() {
    $.ajax({
        url: $('#getUserLink').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">ID</th><th scope=\"col\">UserName</th><th scope=\"col\">FirstName</th><th scope=\"col\">LastName</th><th scope=\"col\">Email</th><th scope=\"col\">Password</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Id + "</td><td>" + data[x].UserName + "</td><td>" + data[x].FirstName + "</td><td>" + data[x].LastName + "</td><td>" + data[x].Email + "</td><td>" + data[x].Password + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getMilestoneAjax() {
    $.ajax({
        url: $('#getMilestoneLink').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">ID</th><th scope=\"col\">Name</th><th scope=\"col\">StartDate</th><th scope=\"col\">EndDate</th><th scope=\"col\">User Id</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Id + "</td><td>" + data[x].Name + "</td><td>" + data[x].StartDate + "</td><td>" + data[x].EndDate + "</td><td>" + data[x].User_Id + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getMilestoneTaskAjax() {
    $.ajax({
        url: $('#getMilestoneTaskLink').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">ID</th><th scope=\"col\">Milestone Id</th><th scope=\"col\">Task Id</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Id + "</td><td>" + data[x].Milestone_Id + "</td><td>" + data[x].Task_Id + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getRoleAjax() {
    $.ajax({
        url: $('#getRoleLink').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">ID</th><th scope=\"col\">Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Id + "</td><td>" + data[x].Name + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getUserRoleAjax() {
    $.ajax({
        url: $('#getUserRoleLink').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">ID</th><th scope=\"col\">User Id</th><th scope=\"col\">Project Id</th><th scope=\"col\">Role Id</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Id + "</td><td>" + data[x].User_Id + "</td><td>" + data[x].Project_Id + "</td><td>" + data[x].Role_Id + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getQuery1Ajax() {

    $.ajax({
        url: $('#Query1Link').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">User Name</th><th scope=\"col\">Project Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].UserName + "</td><td>" + data[x].ProjectName + "</td></tr>")
                }
            }
        },
        error: function () {

        }
    });
}

function getSimpleQuery2Ajax() {

    $.ajax({
        url: $('#Query2Link').data('url'),
        data: 'userName=' + $('#query2Name').val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">Task Name</th><th scope=\"col\">Descroption</th><th scope=\"col\">Project Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].TaskName + "</td><td scope=\"row\">" + data[x].Description + "</td><td scope=\"row\">" + data[x].ProjectName + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getSimpleQuery3Ajax() {

    $.ajax({
        url: $('#Query3Link').data('url'),
        data: 'projectName=' + $('#query3Name').val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">Task Name</th><th scope=\"col\">Descroption</th><th scope=\"col\">User Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].TaskName + "</td><td scope=\"row\">" + data[x].Description + "</td><td scope=\"row\">" + data[x].UserName + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getSimpleQuery4Ajax() {

    $.ajax({
        url: $('#Query4Link').data('url'),
        data: 'userName=' + $('#query4Name').val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">Task Name</th><th scope=\"col\">Milestone Name</th><th scope=\"col\">Start Date</th><th scope=\"col\">End Date</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].TaskName + "</td><td scope=\"row\">" + data[x].MlName + "</td><td scope=\"row\">" + data[x].StartDate + "</td><td scope=\"row\">" + data[x].EndDate + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getSimpleQuery5Ajax() {

    $.ajax({
        url: $('#Query5Link').data('url'),
        data: 'mlName=' + $('#query5Name').val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">Task Name</th><th scope=\"col\">Description</th><th scope=\"col\">Creation Date</th><th scope=\"col\">Due Date</th><th scope=\"col\">Project Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].TaskName + "</td><td scope=\"row\">" + data[x].Description + "</td><td scope=\"row\">" + data[x].CreationDate + "</td><td scope=\"row\">" + data[x].DueDate + "</td><td scope=\"row\">" + data[x].ProjectName + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getAgregate1Ajax() {

    $.ajax({
        url: $('#Agregate1Link').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">User Name</th><th scope=\"col\">Task Count</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].UserName + "</td><td>" + data[x].TaskCount + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getNested1Ajax() {

    $.ajax({
        url: $('#Nested1Link').data('url'),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">Average</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Average + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getNested2Ajax() {

    $.ajax({
        url: $('#Nested2Link').data('url'),
        data: 'projectName=' + $('#nested2Name').val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">User Name</th><th scope=\"col\">Role Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].UserName + "</td><td scope=\"row\">" + data[x].RoleName + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getFunctionAjax() {

    $.ajax({
        url: $('#FunctionLink').data('url'),
        data: 'projectName=' + $('#functionName').val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">Number of users</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].Num + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}

function getProcedureAjax() {

    $.ajax({
        url: $('#ProcedureLink').data('url'),
        data: 'projectName=' + $('#procedureName').val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.length != 0) {
                $('#tablehead').empty();
                $('#tablebody').empty();
                $('#tablehead').append("<tr><th scope=\"col\">User Name</th><th scope=\"col\">Role Name</th></tr>")
                for (var x = 0; x < data.length; x++) {
                    $('#tablebody').append("<tr><td scope=\"row\">" + data[x].UserName + "</td><td scope=\"row\">" + data[x].RoleName + "</td></tr>")
                }
            }
        },
        error: function () {
            alert("I m here");
        }
    });
}