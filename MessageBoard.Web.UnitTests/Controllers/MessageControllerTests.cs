using System.Linq;
using FluentAssertions;
using MessageBoard.Domain.Contracts.Repositories;
using MessageBoard.Domain.Contracts.Services;
using MessageBoard.Domain.Entities;
using MessageBoard.Web.Controllers;
using Moq;
using NUnit.Framework;

namespace MessageBoard.Web.UnitTests
{
    public class MessageControllerTests
    {
        private MessageController _controller;
        private Mock<IMessageService> _service;
        private Mock<IMessageRepository> _repository;

        [OneTimeSetUp]
        public void Setup()
        {
            _repository = new Mock<IMessageRepository>(MockBehavior.Strict);
            _service = new Mock<IMessageService>(MockBehavior.Strict);
            _controller = new MessageController(_service.Object, _repository.Object);
        }

        [Test]
        public void WhenAddMessageShouldCallServiceToAdd()
        {
            var messageDescription = "TestMessage";
            _service.Setup(r => r.Add(messageDescription));

            _controller.Add(messageDescription);

            _service.Verify(r => r.Add(messageDescription), Times.Once);
            Assert.Pass();
        }

        [Test]
        public void WhenGetAllMessagesShouldCallRepositoryAndReturnMessages()
        {
            var messages = new[]
            {
                new Message("test"),
                new Message("test2")
            };

            _repository.Setup(r => r.GetAll())
                .Returns(messages);

            var result = _controller.Get();

            result.Count().Should().Be(2);
            _repository.Verify(r => r.GetAll(), Times.Once);
        }
    }
}
