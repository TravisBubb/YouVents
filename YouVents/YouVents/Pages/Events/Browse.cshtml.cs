﻿using System;
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

        [BindProperty]
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

            [DataType(DataType.Date)]
            public DateTime Date { get; set; }

            public string City { get; set; }

            public float Price { get; set; }
        }
        //Testing EventsQuery-->
        public IActionResult OnPost() {


            string city = Input.City != null ? Input.City : "%";
            city = "%" + city + "%";

            float price = Input.Price != 0 ? Input.Price : float.MaxValue;

            string date = Input.Date.ToString("MM/dd/yyyy");
    

            Events = EventsMethods.EventsQuery(city, price, date);
            return Page();
        
        }
        //end of EventsQuery Testing-->
    }
}