"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;



connection.on("ReceiveMessage", function (user, message) {
    let currentDate = new Date()
    currentDate = currentDate.toLocaleString()
    var SenderHiddenName = document.getElementById("SenderHiddenName").innerHTML;

    var AddSenderName = document.createElement("p");
    document.getElementById("messagesList").appendChild(AddSenderName);
    AddSenderName.className = "text-primary m-0";
    AddSenderName.id = "Sendername";
    AddSenderName.textContent = `${SenderHiddenName}: `;
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    var Timetamp = document.createElement("span");
    Timetamp.className = "text-muted small";
    Timetamp.id = "Timestamp";
    Timetamp.textContent = currentDate;
    AddSenderName.appendChild(Timetamp)

    var Message = document.createElement("p");
    document.getElementById("messagesList").appendChild(Message);
    Message.className = "text-black h4";
    Message.id = "Content";
    Message.textContent = `${message}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) { sendMessage();});
document.getElementById("sendButton").addEventListener("keypress", function (event) { if(event.key === "Enter") { sendMessage(); }}); // Currently not working

function sendMessage() {
    var SenderID = document.getElementById("SenderHiddenID").innerHTML;
    var ReceiverID = document.getElementById("ReceiverHiddenID").innerHTML;
    var message = document.getElementById("messageInput").value;

    connection.invoke("SendMessage", SenderID, ReceiverID, message).catch(function (err) {
        return console.error(err.toString());

    });

    event.preventDefault();
    document.getElementById("messageInput").value = ""; // deleting the text in the input field after clicking send

};
