using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using YouVents.API;
using YouVents.Areas.Identity.Data;
using YouVents.Models;

namespace YouVents.Pages.Events {
    public class CreateModel : PageModel {
        public ApplicationUser _User;
        public List<string> AllTypes = EventsMethods.GetAllTypes();
        public List<string> AllStates = EventsMethods.GetAllStates();

        readonly Account account = new Account( // My Cloudinary account
                "dpmhx7k6y",
                "759656868747797",
                "aU4c2Fh7Dvm1n12JzgnFoUHWCt0");

        

        [BindProperty]
        public EventInput Input { get; set; }

        // On a Get action, simply load the page if the user is an organizer
        public IActionResult OnGet() {
            // Verify that the user is an organizer


            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _User = UsersMethods.GetById(userId);

            // If the user is an organizer, then proceed to the creation form
            if (_User.AccountType == "Organizer") {
                return Page();
            }
            // If the user is not an organizer, then redirect them to the browse page
            else {
                return RedirectToPage("/Events/Browse");
            }

            

        }

        // On a Post action, create a new Event and attempt to insert it into the database
        public IActionResult OnPost() {
            // Get the user's Id string
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //Image must have a value before going to EventMethods.Create
            if (Input.Image == null) { Input.Image = "/images/EVENT01.png"; }

            // Create a new Event to insert based on the inputs in the form
            Event e = new Event {
                Name = Input.Name,
                Rating = Input.Rating,
                Description = Input.Description,
                Date = Input.Date.ToString("yyyy/MM/dd"),
                Time = Input.Time.ToString("HH:mm"),
                Capacity = Input.Capacity,
                Street = Input.Street,
                City = Input.City,
                State = Input.State,
                OrganizerId = userId,
                Zip = Input.Zip,
                Price = Input.Price,
                Type = Input.Type,
                Image = Input.Image
            };

            //Console.WriteLine(e.Image);

            // Try to insert the event into the database
            EventsMethods.Create(e);

            return RedirectToPage("/Events/CreationConfirmation");
        }
    }
}