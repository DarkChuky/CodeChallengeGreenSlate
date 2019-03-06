function GetUserProjects() {
        $("#SelectedUserId").change(function () {
            //$("#tblProjects").empty();

            $.getJSON('/Home/GetUserProjects', { userId: $("#SelectedUserId").val() }, function (data) {

                var tblProjects = $("#tblProjects");
                $.each(data, function (index, item) {
                    var tr = $("<tr></tr>");
                    tr.html(("<td>" + item.ProjectID + "</td>")
                        + " " + ("<td>" + item.StartDate + "</td>")
                        + " " + ("<td>" + item.TimeToStart + "</td>")
                        + " " + ("<td>" + item.EndDate + "</td>")
                        + " " + ("<td>" + item.Credits + "</td>")
                        + " " + ("<td>" + item.Status + "</td>"));
                    tblEmployee.append(tr);
                });

            });


        });
    }