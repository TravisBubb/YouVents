using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using YouVents.API;
using YouVents.Models;

namespace YouVents.Hubs {

    public class ChatHub : Hub {

        public async Task SendMessage(string SenderID, string ReceiverID, string message) {
            //Message NewMessage = new Message {
            //    SenderID = SenderID,
            //    ReceiverID = ReceiverID,
            //    Content = message

            //};

            //MessageMethods.AddNewMessage(NewMessage);

            Console.WriteLine("Before await");

            await Clients.All.SendAsync("ReceiveMessage", SenderID, message);

            Console.WriteLine("After await");
            
            Message NewMessage = new Message {
                SenderID = SenderID,
                ReceiverID = ReceiverID,
                Content = message

            };

            MessageMethods.AddNewMessage(NewMessage);
        }
    }
}
