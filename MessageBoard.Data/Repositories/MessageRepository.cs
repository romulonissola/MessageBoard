using System.Collections.Generic;
using MessageBoard.Domain.Contracts.Repositories;
using MessageBoard.Domain.Entities;

namespace MessageBoard.Data.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly List<Message> Messages;
        public MessageRepository()
        {
            Messages = new List<Message>();
        }

        public void Add(Message message)
        {
            Messages.Add(message);
        }

        public IEnumerable<Message> GetAll()
        {
            return Messages;
        }
    }
}
