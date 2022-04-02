using Microsoft.Data.Sqlite;
using System;
using YouVents.Areas.Identity.Data;

// Use a namespace for the API directory
namespace YouVents.API
{
    // Class for dealing with users in the db, aside from the default operations with Identity
    public static class UsersMethods
    {
        // Return an ApplicationUser object given a user's ID string
        public static ApplicationUser GetUserById(string id)
        {
            // User variable that will be populated and returned
            ApplicationUser user = null;

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT * FROM AspNetUsers WHERE UserName='{id}'", connection);
            connection.Open();

            using SqliteDataReader reader = cmd.ExecuteReader();
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
            return user;
        }
    }
}
