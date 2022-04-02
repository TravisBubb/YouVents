using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using YouVents.API;
using YouVents.Models;

namespace YouVents.Pages.Events.Purchase
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        public Event Event { get; set; }
        public int NumTickets { get; set; }
        public float TotalCost { get; set; }

        public IActionResult OnGet(int id, int num_tix)
        {
            NumTickets = num_tix;
            Event = EventsMethods.GetById(id);
            TotalCost = NumTickets * Event.Price;
            return Page();
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Events/PurchaseConfirmation");
        }
    }
}