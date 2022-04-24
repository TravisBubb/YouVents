//Filter the list of Events based on input in the search bar
$(document).ready(function () {

    // Try to perform a filter after a key-up event in the search bar
    $("#EventSearch").on("keyup", function () {

        // Get the text that is present in the search bar
        var value = $(this).val().toLowerCase();

        // Attempt to filter the Events list based on the title of the events
        $("#EventList a").filter(function () {

            // Normalize the text to lowercase and split into an array of lines
            var lines = $(this).text().toLowerCase().trim().split("\n");

            // Get the title line
            var eventName = lines[0];

            // Only show the Events whose names contain the search bar contents
            $(this).toggle(eventName.indexOf(value) > -1);

        });
    });


});

// For handling uploaded pictures
var CLOUDINARY_URL = "https://api.cloudinary.com/v1_1/dpmhx7k6y/image/upload";
var CLOUDINARY_UPLOAD_PRESET = "qhiukypt";
var My_PublicID = "759656868747797";

var ImageToUpload = document.getElementById('EventImageUpload');

//ImageToUpload.addEventListener('change', function (event) {
//        var file = event.target.files[0];
//        var formData = new FormData();
//        formData.append("file", file);
//        formData.append("upload_preset", CLOUDINARY_UPLOAD_PRESET);
//        //formData.append("public_id", My_PublicID);


//        var settings = {
//            "url": CLOUDINARY_URL,
//            "method": "POST",
//            "timeout": 0,

//            "processData": false,
//            "mimeType": "multipart/form-data",
//            "contentType": false,
//            "data": formData
//        };

//    $.ajax(settings).then(function (response) {

//        console.log(response.data);
//            console.log(response.url);
//        });
//});

ImageToUpload.addEventListener('change', function (event) {
    
    const postImage = async () => {

        var file = event.target.files[0];
        var formData = new FormData();
        formData.append("file", file);
        formData.append("upload_preset", CLOUDINARY_UPLOAD_PRESET);
        //formData.append("public_id", My_PublicID);


        var settings = {
            "url": CLOUDINARY_URL,
            "method": "POST",
            "timeout": 0,

            "processData": false,
            "mimeType": "multipart/form-data",
            "contentType": false,
            "data": formData
        };

        const response = await $.ajax(settings)
        console.log(response);
    }

    postImage()
    
});