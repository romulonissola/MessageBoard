using FluentAssertions;
using MessageBoard.Domain.Contracts.Repositories;
using MessageBoard.Domain.Contracts.Services;
using MessageBoard.Domain.Entities;
using Moq;
using NUnit.Framework;

namespace MessageBoard.Business.Services.UnitTests
{
    [TestFixture]
    public class MessageServiceTests
    {
        private IMessageService _service;
        private Mock<IMessageRepository> _repository;

        [OneTimeSetUp]
        public void Setup()
        {
            _repository = new Mock<IMessageRepository>(MockBehavior.Strict);
            _service = new MessageService(_repository.Object);
        }

        [Test]
        public void WhenAddMessageShouldCallRepository()
        {
            var messageDescription = "TestMessage";
            _repository.Setup(r => r.Add(It.IsAny<Message>()))
                .Callback<Message>(m => m.Description.Should().Be(messageDescription));

            _service.Add(messageDescription);

            _repository.Verify(r => r.Add(It.IsAny<Message>()), Times.Once);

            Assert.Pass();
        }
    }
}
