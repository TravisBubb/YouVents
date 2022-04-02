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

namespace YouVents.Pages.Events
{
    public class CreateModel : PageModel
    {
        public new ApplicationUser User { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

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
        }


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

        public IActionResult OnPost()
        {
            return RedirectToPage("/Events/CreationConfirmation");
        }
    }
}