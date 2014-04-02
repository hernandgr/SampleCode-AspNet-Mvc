$(document).ready(function () {
    $('#btnSearch').on('click', function () {
        GetProduct($('#txtId').val());
    });
});

// Connecting to api
function GetProduct(id) {    
    var url = '../api/products/' + id;

    $.getJSON(url)
        .done(function (data) {
            $('#txtName').val(data.name);
            $('#txtPrice').val(data.price);
        });
}