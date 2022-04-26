using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using YouVents.API;
using YouVents.Areas.Identity.Data;
using YouVents.Models;

namespace YouVents.Pages
{
    public class MessagesModel : PageModel
    {
        public List<Message> Messages { get; set; }
        public List<string> RecentContacts { get; set; }
        public ApplicationUser Receiver { get; set; }
        public ApplicationUser Sender { get; set; }
        public IActionResult OnGet(string? ReceiverUsername)
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                Sender = UsersMethods.GetById(userId);
                Console.WriteLine(ReceiverUsername);
                if (!(ReceiverUsername is null))
                {
                    Receiver = UsersMethods.GetByUsername(ReceiverUsername);
                    Messages = MessageMethods.GetPastMessages(userId, Receiver.Id);
                }
                else Receiver = new ApplicationUser { UserName = "" };

                RecentContacts = MessageMethods.GetRecentContacts(userId);


                return Page();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
