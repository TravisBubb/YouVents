using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using YouVents.API;
using YouVents.Models;

namespace YouVents.Pages.Events
{
    public class ViewModel : PageModel
    {
        public Event Event { get; set; }
        [BindProperty]
        public int NumTickets { get; set; }

        public IActionResult OnGet(int id)
        {
            Event = EventsMethods.GetById(id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            return Redirect($"/Events/Checkout/{id}/{NumTickets}");
        }
    }
}