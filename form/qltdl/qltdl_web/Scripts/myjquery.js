﻿
//dynamicId for text box's id
var dynamicId = 0


//event handler for Add button
$('#btnAdd').click(function () {
    dynamicId += 1
    $('#chitiet').append(
        "<tr>" +
        "<td>" + dynamicId + "</td>" +
        "<td>" + $('#item').val() + "</td> " +
        //"<td>" + $("#item option:selected").text() + "</td>" +
        //"<td>" + $('#amount').val() + "</td>" +
        '<td><button class="btn btn-danger btnDelete">Delete</button></td>' +
        '<input type="hidden" name="ct.Index" value="' + (dynamicId - 1) + '" />' +
        '<input type="hidden" name="ct[' + (dynamicId - 1) + '].NHIEMVU" value="' + $('#item').val() + '" />' +
        '<input type="hidden" name="ct[' + (dynamicId - 1) + '].SOLUONGN" value="' + $('#amount').val() + '" />' +
        "</tr>"

    )
});

$("#chitiet").on('click', '.btn.btn-danger.btnDelete', function () {
    $(this).closest('tr').find("input[type='hidden']").remove();
    $(this).closest('tr').remove();
});

$(function () { // will trigger when the document is ready
    $('.datepicker').datepicker({ dateFormat: 'mm-dd-yy' }); //Initialise any date pickers
});


