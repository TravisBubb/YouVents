using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using YouVents.Models;

namespace YouVents.Pages.Events
{
    public class IndexModel : PageModel
    {
        public List<Event> Events { get; set; }
        public int NumTickets { get; set; }

        public IActionResult OnGet()
        {
            Events = new List<Event>();
            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            using SqliteCommand cmd = new SqliteCommand($"SELECT * FROM Events", connection);
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Event MyEvent = new Event
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            OrganizerId = reader.GetString(reader.GetOrdinal("OrganizerId")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Rating = reader.GetInt32(reader.GetOrdinal("Rating")),
                            Description = reader.GetString(reader.GetOrdinal("Description")),
                            Date = reader.GetString(reader.GetOrdinal("Date")),
                            Time = reader.GetString(reader.GetOrdinal("Time")),
                            Capacity = reader.GetInt32(reader.GetOrdinal("Capacity")),
                            Street = reader.GetString(reader.GetOrdinal("Street")),
                            City = reader.GetString(reader.GetOrdinal("City")),
                            State = reader.GetString(reader.GetOrdinal("State")),
                            Zip = reader.GetString(reader.GetOrdinal("Zip")),
                            Price = reader.GetFloat(reader.GetOrdinal("Price"))
                        };
                        Events.Add(MyEvent);
                    }
                }
            }
            return Page();
        }
    }
}