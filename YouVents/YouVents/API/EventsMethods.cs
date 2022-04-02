﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using YouVents.Models;

namespace YouVents.API
{
    // Static class that holds all backend methods dealing with Event objects
    public static class EventsMethods
    {
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
                            Price = reader.GetFloat(reader.GetOrdinal("Price"))
                        };
                        Events.Add(MyEvent);
                    }
                }
            }
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
                            Price = reader.GetFloat(reader.GetOrdinal("Price"))
                        };
                    }
                }
            }

            return _Event;
        }

        // Insert a new Event into the database
        public static void Create(Event e)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            connection.Open();
            SqliteCommand insertion = new SqliteCommand("" +
                "INSERT INTO Events (Name, Rating, Description, Date, Time, Capacity, Street, City, State, OrganizerId, Zip, Price) " +
                "VALUES (@name,@rating,@description,@date,@time,@capacity,@street,@city,@state,@organizerId,@zip,@price)",
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
            try
            {
                insertion.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            connection.Close();
        }
    }
}
