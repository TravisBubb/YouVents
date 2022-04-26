using Microsoft.Data.Sqlite;
using System;
using System.Text.RegularExpressions;
using YouVents.Areas.Identity.Data;

// Use a namespace for the API directory
namespace YouVents.API
{
    // Class for dealing with users in the db, aside from the default operations with Identity
    public static class UsersMethods
    {
        // Return an ApplicationUser object given a user's ID string
        public static ApplicationUser GetById(string id)
        {
            // User variable that will be populated and returned
            ApplicationUser user = null;

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT * FROM AspNetUsers WHERE Id='{id}'", connection);
            connection.Open();

            using SqliteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string phone = "";
                    if (reader[reader.GetOrdinal("PhoneNumber")].GetType() != typeof(DBNull))
                        phone = reader.GetString(reader.GetOrdinal("PhoneNumber"));

                    user = new ApplicationUser
                    {
                        Id = reader.GetString(reader.GetOrdinal("Id")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        DOB = Convert.ToDateTime(reader.GetString(reader.GetOrdinal("DOB"))),
                        AccountType = reader.GetString(reader.GetOrdinal("AccountType")),
                        PhoneNumber = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{4})", "+1 ($1) $2-$3"),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        UserName = reader.GetString(reader.GetOrdinal("UserName"))
                    };
                }
            }
            return user;
        }

        // Return a user's UserName given their ID
        public static string GetUserNameById(string id)
        {
            string userName="";

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT UserName FROM AspNetUsers WHERE Id=@id", connection);
            cmd.Parameters.Add(new SqliteParameter("@id", id));
            connection.Open();

            using SqliteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userName = reader.GetString(reader.GetOrdinal("UserName"));
                }
            }
            return userName;
        }

        public static ApplicationUser GetByUsername(string username) {
            // User variable that will be populated and returned
            ApplicationUser user = null;

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT * FROM AspNetUsers WHERE UserName=@username", connection);
            cmd.Parameters.Add(new SqliteParameter("@username", username));
            connection.Open();
            using SqliteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    string phone = "";
                    if (reader[reader.GetOrdinal("PhoneNumber")].GetType() != typeof(DBNull))
                        phone = reader.GetString(reader.GetOrdinal("PhoneNumber"));

                    user = new ApplicationUser {
                        Id = reader.GetString(reader.GetOrdinal("Id")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        DOB = Convert.ToDateTime(reader.GetString(reader.GetOrdinal("DOB"))),
                        AccountType = reader.GetString(reader.GetOrdinal("AccountType")),
                        PhoneNumber = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{4})", "+1 ($1) $2-$3"),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        UserName = reader.GetString(reader.GetOrdinal("UserName"))
                    };
                }
            }
            return user;
        }

        private static Type Type(DBNull dBNull)
        {
            throw new NotImplementedException();
        }
    }
}
