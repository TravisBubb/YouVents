using System;

namespace YouVents.Models {
    public class Message {

        public int ID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string Content { get; set; }
        public string Timestamp { get; set; }
        public string Sendername { get; set; }

    }
}
