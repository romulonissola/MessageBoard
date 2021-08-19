using System;
using System.Collections.Generic;
using MessageBoard.Domain.Contracts.Repositories;
using MessageBoard.Domain.Contracts.Services;
using MessageBoard.Domain.Entities;

namespace MessageBoard.Business.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository ?? throw new ArgumentNullException(nameof(messageRepository));
        }

        public void Add(string messageDescription)
        {
            var message = new Message(messageDescription);
            _messageRepository.Add(message);
        }
    }
}
