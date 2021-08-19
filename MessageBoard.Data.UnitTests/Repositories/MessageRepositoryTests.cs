using FluentAssertions;
using MessageBoard.Domain.Contracts.Repositories;
using MessageBoard.Domain.Entities;
using NUnit.Framework;
using System.Linq;

namespace MessageBoard.Data.Repositories.UnitTests
{
    public class MessageRepositoryTests
    {
        private IMessageRepository _repository;

        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenAddMessageShouldAddToTheList()
        {
            var messageDescription = "test";
            _repository = new MessageRepository();
            _repository.Add(new Message(messageDescription));

            var messages = _repository.GetAll();
            messages.Count().Should().Be(1);
            messages.First().Description.Should().Be(messageDescription);
        }

        [TestCase(1)]
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(100)]
        public void WhenAddMessageSeveralTimesShouldReturnAllInsertedRecordsInGetAll(int times)
        {
            _repository = new MessageRepository();
            for (int i = 0; i < times; i++)
            {
                var messageDescription = $"test {i}";
                _repository.Add(new Message(messageDescription));
            }
            var messages = _repository.GetAll();
            messages.Count().Should().Be(times);
        }
    }
}
