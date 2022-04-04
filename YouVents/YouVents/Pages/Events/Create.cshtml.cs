using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using YouVents.API;
using YouVents.Areas.Identity.Data;
using YouVents.Models;

namespace YouVents.Pages.Events
{
    public class CreateModel : PageModel
    {
        public ApplicationUser User;
        public List<string> AllTypes = EventsMethods.GetAllTypes();

        [BindProperty]
        public InputModel Input { get; set; }

        // Class to hold all of the inputs in the form
        public class InputModel
        {
            [Required]
            public string Name { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime Date { get; set; }
            
            [Required]
            [DataType(DataType.Time)]
            public DateTime Time { get; set; }

            public int Capacity { get; set; }
            
            [Required]
            public string Street { get; set; }
            
            [Required]
            public string City { get; set; }
            
            [Required]
            public string State { get; set; }
           
            [Required]
            public string Zip { get; set; }
            
            [Required]
            public float Price { get; set; }

            [Required]
            public int Rating { get; set; }

            public string Type { get; set; }
        }

        // On a Get action, simply load the page if the user is an organizer
        public IActionResult OnGet()
        {
            // Verify that the user is an organizer
            string userId = HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            User = UsersMethods.GetById(userId);

            // If the user is an organizer, then proceed to the creation form
            if (User.AccountType == "Organizer")
            {
                return Page();
            }
            // If the user is not an organizer, then redirect them to the browse page
            else
            {
                return RedirectToPage("/Events/Index");
            }
        }

        // On a Post action, create a new Event and attempt to insert it into the database
        public IActionResult OnPost()
        {
            // Get the user's Id string
            string userId = HttpContext.User.FindFirst(ClaimTypes.Name).Value;

            // Create a new Event to insert based on the inputs in the form
            Event e = new Event
            {
                Name = Input.Name,
                Rating = Input.Rating,
                Description = Input.Description,
                Date = Input.Date.ToString("ddd, dd MMM yyyy"),
                Time = Input.Time.ToString("hh:mm tt"),
                Capacity = Input.Capacity,
                Street = Input.Street,
                City = Input.City,
                State = Input.State,
                OrganizerId = userId,
                Zip = Input.Zip,
                Price = Input.Price,
                Type = Input.Type
            };

            // Try to insert the event into the database
            EventsMethods.Create(e);

            return RedirectToPage("/Events/CreationConfirmation");
        }
    }
}