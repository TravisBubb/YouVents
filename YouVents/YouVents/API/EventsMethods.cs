using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using YouVents.Models;

namespace YouVents.API
{
    // Static class that holds all backend methods dealing with Event objects
    public static class EventsMethods
    {
        // Sort a list of events by date and time in either ascending or descending order.
        // Default ordering is ascending; set desc=false for descending order
        private static void SortByDate(List<Event> events, bool desc = false)
        {

            // Sort the given list of events inplace based on date and time
            events.Sort(delegate (Event x, Event y)
            {
                var xDate = Convert.ToDateTime(x.Date);
                var yDate = Convert.ToDateTime(y.Date);
                var xTime = Convert.ToDateTime(x.Time);
                var yTime = Convert.ToDateTime(y.Time);

                int rc = (DateTime.Compare(xDate, yDate));

                // If different dates, then sort by date
                if ((rc > 0 && !desc) || (rc < 0 && desc))
                    return 1;

                // If both dates the same, then compare times
                else if (rc == 0)
                {
                    rc = DateTime.Compare(xTime, yTime);
                    if ((rc > 0 && !desc) || (rc < 0 && desc))
                        return 1;
                    else if ((rc < 0 && !desc) || (rc > 0 && desc))
                        return -1;
                    else return 0;
                }

                // If different dates, put them in reverse order
                else return -1;
            });

        }

        internal static List<Event> EventsQuery(string city, float price, string date)
        {
            throw new NotImplementedException();
        }


        // Return a list of all of the Event objects in the database
        public static List<Event> GetAll()
        {
            // Declare a list of Event objects - to be returned
            List<Event> Events = new List<Event>();

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT * FROM Events", connection);
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                // Check if there are any rows to read, given the above query
                if (reader.HasRows)
                {
                    // Loop through each row in the query result
                    while (reader.Read())
                    {
                        // Create an event object and add it to the list
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
                            Price = reader.GetFloat(reader.GetOrdinal("Price")),
                            Type = reader.GetString(reader.GetOrdinal("Type"))
                        };
                        Events.Add(MyEvent);
                    }
                }
            }
            // Return the list of events that were returned -- all events in the db
            return Events;
        }

        // Return a list of all of the Event objects in the database that have a date/time in the future
        public static List<Event> GetAllFuture()
        {
            // Declare a list of Event objects - to be returned
            List<Event> Events = new List<Event>();

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT * FROM Events", connection);
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                // Check if there are any rows to read, given the above query
                if (reader.HasRows)
                {
                    // Get the current date and time
                    DateTime now = DateTime.Now;

                    // Loop through each row in the query result
                    while (reader.Read())
                    {
                        // Compare the Event's date and time to the current date and time
                        DateTime date = Convert.ToDateTime(reader.GetString(reader.GetOrdinal("Date")));
                        DateTime time = Convert.ToDateTime(reader.GetString(reader.GetOrdinal("Time")));
                        int rc = DateTime.Compare(now.Date, date);
                        if ((rc < 0) || (rc == 0 && DateTime.Compare(now.ToLocalTime(), time) < 0))
                        {
                            // Create an event object and add it to the list
                            Event MyEvent = new Event
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                OrganizerId = reader.GetString(reader.GetOrdinal("OrganizerId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Rating = reader.GetInt32(reader.GetOrdinal("Rating")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                Date = Convert.ToString(date),
                                Time = Convert.ToString(time),
                                Capacity = reader.GetInt32(reader.GetOrdinal("Capacity")),
                                Street = reader.GetString(reader.GetOrdinal("Street")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                State = reader.GetString(reader.GetOrdinal("State")),
                                Zip = reader.GetString(reader.GetOrdinal("Zip")),
                                Price = reader.GetFloat(reader.GetOrdinal("Price")),
                                Type = reader.GetString(reader.GetOrdinal("Type")),
                                Image = reader.GetString(reader.GetOrdinal("Image"))
                            };
                            Events.Add(MyEvent);
                        }
                    }
                }
            }
            // Sort the list of events by date and time in ascending order
            SortByDate(Events);

            // Return the list of events that were returned -- all events in the db
            return Events;
        }

        // Return an Event object by its ID
        public static Event GetById(int id)
        {
            Event _Event = null;

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            using SqliteCommand cmd = new SqliteCommand($"SELECT * FROM Events WHERE Id={id}", connection);
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _Event = new Event
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
                            Price = reader.GetFloat(reader.GetOrdinal("Price")),
                            Type = reader.GetString(reader.GetOrdinal("Type")),
                            Image = reader.GetString(reader.GetOrdinal("Image"))
                        };
                    }
                }
            }

            return _Event;
        }

        // Update an event row given an Event object
        public static void Update(Event e)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            connection.Open();
            SqliteCommand update = new SqliteCommand("" +
                "UPDATE Events SET Name=@name, Description=@description, Date=@date, Time=@time, Capacity=@capacity, " +
                "Street=@street, City=@city, State=@state, Zip=@zip, Price=@price, Type=@type " +
                "WHERE Id=@id", connection);

            update.Parameters.Add(new SqliteParameter("@name", e.Name));
            update.Parameters.Add(new SqliteParameter("@description", e.Description));
            update.Parameters.Add(new SqliteParameter("@date", e.Date));
            update.Parameters.Add(new SqliteParameter("@time", e.Time));
            update.Parameters.Add(new SqliteParameter("@capacity", e.Capacity));
            update.Parameters.Add(new SqliteParameter("@street", e.Street));
            update.Parameters.Add(new SqliteParameter("@city", e.City));
            update.Parameters.Add(new SqliteParameter("@state", e.State));
            update.Parameters.Add(new SqliteParameter("@zip", e.Zip));
            update.Parameters.Add(new SqliteParameter("@price", e.Price));
            update.Parameters.Add(new SqliteParameter("@type", e.Type));
            update.Parameters.Add(new SqliteParameter("@id", e.Id));

            try
            {
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            connection.Close();
        }

        // Insert a new Event into the database
        public static void Create(Event e)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            connection.Open();
            SqliteCommand insertion = new SqliteCommand("" +
                "INSERT INTO Events (Name, Rating, Description, Date, Time, Capacity, Street, City, State, OrganizerId, Zip, Price, Type, Image) " +
                "VALUES (@name,@rating,@description,@date,@time,@capacity,@street,@city,@state,@organizerId,@zip,@price,@type, @image)",
                connection);
            insertion.Parameters.Add(new SqliteParameter("@name", e.Name));
            insertion.Parameters.Add(new SqliteParameter("@rating", e.Rating));
            insertion.Parameters.Add(new SqliteParameter("@description", e.Description));
            insertion.Parameters.Add(new SqliteParameter("@date", e.Date));
            insertion.Parameters.Add(new SqliteParameter("@time", e.Time));
            insertion.Parameters.Add(new SqliteParameter("@capacity", e.Capacity));
            insertion.Parameters.Add(new SqliteParameter("@street", e.Street));
            insertion.Parameters.Add(new SqliteParameter("@city", e.City));
            insertion.Parameters.Add(new SqliteParameter("@state", e.State));
            insertion.Parameters.Add(new SqliteParameter("@organizerId", e.OrganizerId));
            insertion.Parameters.Add(new SqliteParameter("@zip", e.Zip));
            insertion.Parameters.Add(new SqliteParameter("@price", e.Price));
            insertion.Parameters.Add(new SqliteParameter("@type", e.Type));
            insertion.Parameters.Add(new SqliteParameter("@image", e.Image));
            try
            {
                insertion.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Console.WriteLine(e);
            connection.Close();
        }

        // Return all of the different available types of events -- list of strings
        public static List<string> GetAllTypes()
        {
            List<string> Types = new List<string>();

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            using SqliteCommand cmd = new SqliteCommand($"SELECT * FROM EventTypes", connection);
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Types.Add(reader.GetString(reader.GetOrdinal("Type")));
                    }
                }
            }

            return Types;
        }

        // Return all of the different available state abbreviations -- list of strings
        public static List<string> GetAllStates()
        {
            List<string> States = new List<string>();

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            using SqliteCommand cmd = new SqliteCommand($"SELECT * FROM States", connection);
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        States.Add(reader.GetString(reader.GetOrdinal("State")));
                    }
                }
            }

            return States;
        }

        // Return all events (old and future) given a specific organizer's Id
        public static List<Event> GetAllByOrgId(string orgId)
        {
            // Declare a list of Event objects - to be returned
            List<Event> Events = new List<Event>();

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT * FROM Events WHERE OrganizerId=@orgId", connection);
            cmd.Parameters.Add(new SqliteParameter("@orgId", orgId));
            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                // Check if there are any rows to read, given the above query
                if (reader.HasRows)
                {
                    // Loop through each row in the query result
                    while (reader.Read())
                    {
                        // Create an event object and add it to the list
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
                            Price = reader.GetFloat(reader.GetOrdinal("Price")),
                            Type = reader.GetString(reader.GetOrdinal("Type")),
                            Image = reader.GetString(reader.GetOrdinal("Image"))
                        };
                        Events.Add(MyEvent);
                    }
                }
            }
            // Sort the list of events by date and time in ascending order
            SortByDate(Events);

            // Return the list of events that were returned -- all events in the db
            return Events;
        }

        // Return all future events given a specific info
        public static List<Event> EventsQuery(string city, float price, string date, string sortMethod)
        {
            // Declare a list of Event objects - to be returned
            List<Event> Events = new List<Event>();
            SqliteCommand cmd;
            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            // Get the current date and time
            DateTime now = DateTime.Now;

            //if (date == "01/01/0001")
            //{ //default if date filter is empty
            //    cmd = new SqliteCommand($"SELECT * FROM Events WHERE price <= @price AND UPPER(city) LIKE UPPER(@city) AND date >= @date", connection);
            //    cmd.Parameters.Add(new SqliteParameter("@city", city));
            //    cmd.Parameters.Add(new SqliteParameter("@price", price));
            //    cmd.Parameters.Add(new SqliteParameter("@date", now.Date.ToString("MM/dd/yyyy")));

            //}
            //else
            //{
            //    cmd = new SqliteCommand($"SELECT * FROM Events WHERE price <= @price AND UPPER(city) LIKE UPPER(@city) AND date = @date", connection);
            //    cmd.Parameters.Add(new SqliteParameter("@city", city));
            //    cmd.Parameters.Add(new SqliteParameter("@price", price));
            //    cmd.Parameters.Add(new SqliteParameter("@date", date));
            //}

            cmd = new SqliteCommand($"SELECT a.*, b.Date || ' ' || b.Time AS DateTime FROM Events a, Events b " +
                $"WHERE a.Id == b.Id AND a.price <= @price AND UPPER(a.city) LIKE UPPER(@city) AND a.date >= @date " +
                $"ORDER BY " + sortMethod, connection);
            cmd.Parameters.Add(new SqliteParameter("@city", city));
            cmd.Parameters.Add(new SqliteParameter("@price", price));
            cmd.Parameters.Add(new SqliteParameter("@date", date));

            connection.Open();
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                // Check if there are any rows to read, given the above query
                if (reader.HasRows)
                {
                    // Loop through each row in the query result
                    while (reader.Read())
                    {
                        // Create an event object and add it to the list
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
                            Price = reader.GetFloat(reader.GetOrdinal("Price")),
                            Image = reader.GetString(reader.GetOrdinal("Image"))
                        };
                        Events.Add(MyEvent);
                    }
                }
            }

            // Return the list of events that were returned -- all events in the db
            return Events;
        }
    }
}
