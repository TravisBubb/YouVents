using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YouVents.API;
using YouVents.Areas.Identity.Data;
using YouVents.Models;

namespace YouVents.Pages.Events
{
    public class BrowseModel : PageModel
    {
        public List<Event> Events { get; set; }
        public int NumTickets { get; set; }
        public new ApplicationUser User { get; set; }
        public InputModel Input { get; set; }

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
        public class InputModel {

            public string Name { get; set; }

            public string Description { get; set; }

            [DataType(DataType.Date)]
            public DateTime Date { get; set; }

            [DataType(DataType.Time)]
            public DateTime Time { get; set; }

            public int Capacity { get; set; }

            public string Street { get; set; }

            public string City { get; set; }

            public string State { get; set; }

            public string Zip { get; set; }

            public float Price { get; set; }

            public int Rating { get; set; }

            public string Type { get; set; }
        }
        //Testing EventsQuery-->
        public IActionResult OnPost() {

            Event e = new Event {
                Name = Input.Name,
                Rating = Input.Rating,
                Description = Input.Description,
                Date = Input.Date.ToString("ddd, dd MMM yyyy"),
                Time = Input.Time.ToString("hh:mm tt"),
                Capacity = Input.Capacity,
                Street = Input.Street,
                City = Input.City,
                State = Input.State,
                Zip = Input.Zip,
                Price = Input.Price,
                Type = Input.Type
            };

            EventsMethods.EventsQuery(e);
            return Page();
        
        }
        //end of EventsQuery Testing-->
    }
}