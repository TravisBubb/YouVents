using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using YouVents.Models;

namespace YouVents.API {
    public class MessageMethods {
        public static List<Message> GetPastMessages(string user1, string user2) {
            // Declare a list of message objects - to be returned
            List<Message> Messages = new List<Message>();

            using SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            SqliteCommand cmd = new SqliteCommand($"SELECT M.*, U.UserName FROM DirectMessages M, AspNetUsers U " +
                "WHERE SenderID = U.Id AND((SenderID = @user1 AND ReceiverID = @user2) " +
                "OR(ReceiverID = @user1 AND SenderID = @user2)) ORDER BY ID", connection);
            connection.Open();
            cmd.Parameters.Add(new SqliteParameter("@user1", user1));
            cmd.Parameters.Add(new SqliteParameter("@user2", user2));
            using (SqliteDataReader reader = cmd.ExecuteReader()) {
                // Check if there are any rows to read, given the above query
                if (reader.HasRows) {

                    // Loop through each row in the query result
                    while (reader.Read()) {
                        // Compare the Event's date and time to the current date and time
                        DateTime Timestamp = Convert.ToDateTime(reader.GetString(reader.GetOrdinal("Timestamp")));
                        // Create a message object and add it to the list
                        Message NewMessage = new Message {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            SenderID = reader.GetString(reader.GetOrdinal("SenderID")),
                            ReceiverID = reader.GetString(reader.GetOrdinal("ReceiverID")),
                            Content = reader.GetString(reader.GetOrdinal("Content")),
                            Timestamp = Convert.ToString(Timestamp),
                            Sendername = reader.GetString(reader.GetOrdinal("UserName"))

                        };
                        Messages.Add(NewMessage);
                    }
                }
            }

            // Return the list of events that were returned -- all events in the db
            return Messages;
        }

        public static void AddNewMessage(Message M) {
            SqliteConnection connection = new SqliteConnection("Data Source=YouVents.db");
            connection.Open();
            SqliteCommand insertion = new SqliteCommand("" +
                "INSERT INTO DirectMessages (SenderID, ReceiverID, Content, Timestamp) VALUES (@SenderID, @ReceiverID, @Content, CURRENT_TIMESTAMP)", connection);

            insertion.Parameters.Add(new SqliteParameter("@SenderID", M.SenderID));
            insertion.Parameters.Add(new SqliteParameter("@ReceiverID", M.ReceiverID));
            insertion.Parameters.Add(new SqliteParameter("@Content", M.Content));
            //insertion.Parameters.Add(new SqliteParameter("@Timestamp", M.Timestamp));
            try {
                insertion.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            connection.Close();
        }

    }
}
