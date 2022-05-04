//Filter the list of Events based on input in the search bar (responsive) -- no longer being used
//$(document).ready(function () {

//    // Try to perform a filter after a key-up event in the search bar
//    $("#EventSearch").on("keyup", function () {

//        // Get the text that is present in the search bar
//        var value = $(this).val().toLowerCase();

//        // Attempt to filter the Events list based on the title of the events
//        $("#EventList span").filter(function () {

//            // Normalize the text to lowercase and split into an array of lines
//            var lines = $(this).text().toLowerCase().trim().split("\n");

//            // Get the title line
//            var eventName = lines[0];

//            console.log(lines);

//            // Only show the Events whose names contain the search bar contents
//            $(this).toggle(eventName.indexOf(value) > -1);

//        });
//    });
//});


// Clear the filter form when the clear button is clicked on /Events/Browse.cshtml
// Get all of the input elements and reset their values to the default
function clearForm() {
    const inputs = document.querySelectorAll('#EventSearch, #DateSearch, #PriceSearch, #CitySearch, #SortBy');
    inputs.forEach(input => {
        if (input.id === 'SortBy')
            input.value = 'Sort By';
        else
            input.value = '';
    });
}


window.addEventListener("resize", function () {
    //var messageContainer = document.getElementById("messageContainer");
    var scrollBoxes = document.getElementsByClassName("scrollable-content");
    for (var i = 0; i < scrollBoxes.length; i++) {
        scrollBoxes[i].style.height = (window.innerHeight * .60) + "px";
    }

});

var scrollBoxes = document.getElementsByClassName("scrollable-content");
for (var i = 0; i < scrollBoxes.length; i++) {
    scrollBoxes[i].style.height = (window.innerHeight * .60) + "px";
}
