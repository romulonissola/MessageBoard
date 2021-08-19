using System;
using System.Collections.Generic;
using MessageBoard.Domain.Contracts.Repositories;
using MessageBoard.Domain.Contracts.Services;
using MessageBoard.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _service;
        private readonly IMessageRepository _repository;

        public MessageController(IMessageService service,
            IMessageRepository repository)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return _repository.GetAll();
        }

        [HttpPost]
        public void Add(string messageDescription)
        {
            _service.Add(messageDescription);
        }
    }
}
