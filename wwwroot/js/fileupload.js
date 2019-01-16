function fileupload(filename) {
    var inputfile = document.getElementById(filename);

    var files = inputfile.files;

    var fdata = new FormData();

    for (var i = 0; i != files.length; i++) {
        fdata.append("files", files[i]);
    }

    $.ajax({
        url: "@Url.Action("UploadFile", "Books")",
        data: fdata,
        processData: false,
        contentType: false,
        type: 'POST',
        success: function (data) {
            alert("file upload successfully");
        },
        error: function (returnval) {
            alert(returnval);
        }


    });
}