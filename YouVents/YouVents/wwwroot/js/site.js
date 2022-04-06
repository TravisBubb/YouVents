// Filter the list of Events based on input in the search bar
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
    // Try to perform a filter after a key-up event in the City bar
    //$("#FilterBtn").on('click', function () {

    //    // Get the text that is present in the search bar
    //    var value = $(this).val().toLowerCase(); //keyword "this" doesn't work anymore because I changed the "#CitySearch" to "#FilterBtn"

    //    // Attempt to filter the Events list based on the title of the events
    //    $("#EventList a").filter(function () {

    //        // Normalize the text to lowercase and split into an array of lines
    //        var lines = $(this).text().toLowerCase().trim().split("\n");


    //        // Get the title line
    //        var cityName = lines[4].trim().split(": ")[1];

    //        // Only show the Events whose names contain the search bar contents
    //        $(this).toggle(cityName.indexOf(value) > -1);
    //    });
    //});
});

////var date = $("#DateSearch").val().split("/");



//function NameFilter() {
//    // Get the text that is present in the search bar
//    var value = $(this).val().toLowerCase();

//    // Attempt to filter the Events list based on the title of the events
//    $("#EventList a").filter(function () {

//        // Normalize the text to lowercase and split into an array of lines
//        var lines = $(this).text().toLowerCase().trim().split("\n");

//        // Get the title line
//        var eventName = lines[0];

//        // Only show the Events whose names contain the search bar contents
//        $(this).toggle(eventName.indexOf(value) > -1);
//    });
//}

//function CityFilter() {
//    // Get the text that is present in the search bar
//    var value = $(this).val().toLowerCase();

//    // Attempt to filter the Events list based on the title of the events
//    $("#EventList a").filter(function () {

//        // Normalize the text to lowercase and split into an array of lines
//        var lines = $(this).text().toLowerCase().trim().split("\n");


//        // Get the title line
//        var cityName = lines[4].trim().split(": ")[1];

//        // Only show the Events whose names contain the search bar contents
//        $(this).toggle(cityName.indexOf(value) > -1);
//    });
//}

//$(document).ready(function () {
//    // Try to perform a filter after a key-up event in the search bar
//    $("#EventSearch").on("keyup", NameFilter());
//    // Try to perform a filter after a key-up event in the city search bar
//    $("#CitySearch").on("keyup", CityFilter());
//    )};


