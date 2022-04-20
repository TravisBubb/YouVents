using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YouVents.API;
using YouVents.Areas.Identity.Data;
using YouVents.Models;

namespace YouVents.Pages.Events
{
    public class ManageModel : PageModel
    {
        public List<Event> Events { get; set; }

        public IActionResult OnGet()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Events = EventsMethods.GetAllByOrgId(userId);

            return Page();
        }
    }
}