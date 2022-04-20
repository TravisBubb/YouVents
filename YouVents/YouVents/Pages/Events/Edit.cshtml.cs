using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public List<string> AllTypes = EventsMethods.GetAllTypes();
        public List<string> AllStates = EventsMethods.GetAllStates();

        [BindProperty]
        public EventInput Input { get; set; }


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
            Event = EventsMethods.GetById(id);

            // Create a new Event to insert based on the inputs in the form
            Event e = new Event
            {
                Name = Input.Name,
                Description = Input.Description,
                Date = Input.Date.ToString("yyyy/MM/dd"),
                Time = Input.Time.ToString("HH:mm"),
                Capacity = Input.Capacity,
                Street = Input.Street,
                City = Input.City,
                State = Input.State,
                Zip = Input.Zip,
                Price = Input.Price,
                Type = Input.Type,
                Id = id
            };

            EventsMethods.Update(e);

            return Page();
        }
    }
}