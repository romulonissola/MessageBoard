using System.Collections.Generic;
using MessageBoard.Domain.Entities;

namespace MessageBoard.Domain.Contracts.Services
{
    public interface IMessageService
    {
        void Add(string messageDescription);
    }
}
