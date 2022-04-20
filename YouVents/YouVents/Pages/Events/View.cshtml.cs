using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YouVents.API;
using YouVents.Areas.Identity.Data;
using YouVents.Models;

namespace YouVents.Pages.Events
{
    public class ViewModel : PageModel
    {
        public Event Event { get; set; }
        public ApplicationUser Organizer = null;

        [BindProperty]
        public int NumTickets { get; set; }

        public IActionResult OnGet(int id)
        {
            Event = EventsMethods.GetById(id);

            if (Event == null)
            {
                return NotFound();
            }

            Organizer = UsersMethods.GetById(Event.OrganizerId);

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            return Redirect($"/Events/Checkout/{id}/{NumTickets}");
        }
    }
}