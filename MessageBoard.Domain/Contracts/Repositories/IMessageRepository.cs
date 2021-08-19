using System.Collections.Generic;
using MessageBoard.Domain.Entities;

namespace MessageBoard.Domain.Contracts.Repositories
{
    public interface IMessageRepository
    {
        void Add(Message message);
        IEnumerable<Message> GetAll();
    }
}