using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Claims;
using YouVents.Areas.Identity.Data;
using YouVents.Models;
using YouVents.API;

namespace YouVents.Pages.Events
{
    public class IndexModel : PageModel
    {
        public List<Event> Events { get; set; }
        public int NumTickets { get; set; }
        public new ApplicationUser User { get; set; }

        public IActionResult OnGet()
        {
            Events = EventsMethods.GetAllFuture();
         
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                string userId = HttpContext.User.FindFirst(ClaimTypes.Name).Value;
                User = UsersMethods.GetById(userId);
            }
            return Page();
        }
    }
}