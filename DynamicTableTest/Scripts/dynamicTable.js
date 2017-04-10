function createTable(result, divId) {
    // EXTRACT VALUE FOR HTML HEADER. 
    var col = [];
    var i = 0;
    for (i = 0; i < result.length; i++) {
        for (var key in result[i]) {
            if (col.indexOf(key) === -1) {
                col.push(key);
            }
        }
    }

    // CREATE DYNAMIC TABLE.
    var table = document.createElement("table");

    // CREATE HTML TABLE HEADER ROW USING THE EXTRACTED HEADERS ABOVE.
    var header =  table.createTHead();
    var tr = header.insertRow(-1);                   // TABLE ROW.

    for (i = 0; i < col.length; i++) {
        var th = document.createElement("th");      // TABLE HEADER.
        th.innerHTML = addSpace(col[i]);
        tr.appendChild(th);
    }

    // ADD JSON DATA TO THE TABLE BODY AS ROWS.
    var body = table.createTBody();
    for (i = 0; i < result.length; i++) {

        tr = body.insertRow(-1);

        for (var j = 0; j < col.length; j++) {
            var tabCell = tr.insertCell(-1);
            tabCell.innerHTML = result[i][col[j]];
        }
    }

    // ADD THE NEWLY CREATED TABLE WITH JSON DATA TO A CONTAINER.
    var divContainer = document.getElementById(divId);
    divContainer.innerHTML = "";
    divContainer.appendChild(table);
    $('table').addClass("table table-striped");

    $('table').DataTable({
        pagingType: "full_numbers",
        columnDefs: [{
            "targets": 'no-sort',
            "orderable": false,
            "order": []
        }],
    });
}

function addSpace(text) {
    text = text.replace(/([A-Z])/g, ' $1').trim();

    return text;
}