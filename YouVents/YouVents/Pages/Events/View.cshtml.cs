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
        public int Edit;
        public string EventMap;

        [BindProperty]
        public int NumTickets { get; set; }

        public IActionResult OnGet(int id, int edit)
        {
            Edit = edit;
            Event = EventsMethods.GetById(id);

            string EventAddress = Event.Street + ", " + Event.City + ", " + Event.State + " " + Event.Zip;
            EventMap = "https://maps.google.com/maps?q=" + EventAddress + "&t=&z=13&ie=UTF8&iwloc=&output=embed";

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