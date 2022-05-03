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
        public ApplicationUser _User { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public IActionResult OnGet()
        {
            Events = EventsMethods.GetAllFuture();

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _User = UsersMethods.GetById(userId);
            }
            return Page();
        }

        public class InputModel
        {

            public string Name { get; set; }

            [DataType(DataType.Date)]
            public DateTime Date { get; set; }

            public string City { get; set; }

            public float Price { get; set; }

            public string SortMethod { get; set; }
        }


        //Testing EventsQuery-->
        public IActionResult OnPost() {

            string name = Input.Name != null ? Input.Name : "%";
            name = "%" + name + "%";

            string city = Input.City != null ? Input.City : "%";
            city = "%" + city + "%";

            float price = Input.Price != 0 ? Input.Price : float.MaxValue;

            string date = Input.Date.ToString("yyyy/MM/dd");
            date = "0001/01/01" != date ? date : DateTime.Now.Date.ToString("yyyy/MM/dd");

            string sortMethod = Input.SortMethod;
            if (sortMethod == "Price (Low-High)")
                sortMethod = "Price";
            else if (sortMethod == "Price (High-Low)")
                sortMethod = "Price DESC";
            else if (sortMethod == "Date (Ascend)")
                sortMethod = "DateTime";
            else if (sortMethod == "Date (Descend)")
                sortMethod = "DateTime DESC";
            else sortMethod = "DateTime";

            Events = EventsMethods.EventsQuery(name, city, price, date, sortMethod);
            return Page();
        
        }
    }
}