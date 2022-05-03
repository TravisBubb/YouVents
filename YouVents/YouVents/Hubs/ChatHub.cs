using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using YouVents.API;
using YouVents.Models;

namespace YouVents.Hubs {

    public class ChatHub : Hub {

        public async Task SendMessage(string SenderID, string SenderUserName, string ReceiverID, string message) {
            //Message NewMessage = new Message {
            //    SenderID = SenderID,
            //    ReceiverID = ReceiverID,
            //    Content = message

            //};

            //MessageMethods.AddNewMessage(NewMessage);

            //await Clients.All.SendAsync("ReceiveMessage", SenderID, message);
            await Clients.All.SendAsync("ReceiveMessage", SenderUserName, message);
            Console.WriteLine(SenderID);
            
            Message NewMessage = new Message {
                SenderID = SenderID,
                ReceiverID = ReceiverID,
                Content = message

            };

            MessageMethods.AddNewMessage(NewMessage);
        }
    }
}
