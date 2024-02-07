// Write your JavaScript code.
function toTable(data, container)
{
    data.forEach(obj =>
    {
        var table = $("<table class=\"table table-striped\">");
        for (var key in obj)
        {
            table.append("<tr><td>" + key + "</td><td>" + obj[key] + "</td></tr>");
        }

        $(container).append(table);
    });
}