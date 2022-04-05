using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YouVents.API;
using YouVents.Models;

namespace YouVents.Pages.Events
{
    public class EditModel : PageModel
    {
        public Event Event { get; set; }

        public IActionResult OnGet(int id)
        {
            Event = EventsMethods.GetById(id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}