using Moq;
using SampleMessage.Controllers;
using SampleMessage.Models;
using System;
using Xunit;

namespace MessageTests
{
    public class MessageControllerTests
    {
        private readonly MessageController _messageController;
        private readonly Mock<IMessenger> _messengerMock = new Mock<IMessenger>();

        public MessageControllerTests()
        {
            _messageController = new MessageController(_messengerMock.Object);
        }

        [Fact]
        public void Get_ReturnMessage_HelloWorld()
        {
            var expectedMessage = new Message("Hello World");
            _messengerMock.Setup(x => x.GetMessage()).Returns(expectedMessage);

            Message actualMessage = _messageController.Get();
            Assert.Equal(expectedMessage, actualMessage);
        }
    }
}
