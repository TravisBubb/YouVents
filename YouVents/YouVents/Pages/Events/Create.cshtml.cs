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
using YouVents.Areas.Identity.Data;

namespace YouVents.Pages.Events
{
    public class CreateModel : PageModel
    {
        public ApplicationUser user { get; set; }

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

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            using SqliteCommand cmd = new SqliteCommand($"SELECT * FROM AspNetUsers WHERE UserName='{userId}'", connection);
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = new ApplicationUser
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            DOB = Convert.ToDateTime(reader.GetString(reader.GetOrdinal("DOB"))),
                            AccountType = reader.GetString(reader.GetOrdinal("AccountType"))
                        };
                    }
                }
            }

            if (user.AccountType == "Organizer")
            {
                return Page();
            }
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