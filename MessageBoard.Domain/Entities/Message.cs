using System;

namespace MessageBoard.Domain.Entities
{
    public class Message
    {
        public Message() {}

        public Message(string description)
        {
            Description = description;
            MessageTimeStamp = DateTime.UtcNow;
        }

        public string Description { get; set; }
        public DateTime MessageTimeStamp { get; set; }
    }
}
