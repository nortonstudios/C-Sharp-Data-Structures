using System;
using QueueLibrary;
using Xunit;

namespace QueueLibrary.Tests
{
    public class QueueNodeTests
    {

        [Fact]
        public void TestingSamePayload_WhereNodeIsCopied_ShouldReturnTrue()
        {
            //Arrange
            QueueNode _firstTestNode = new QueueNode("Hi", null);

            //Act
            QueueNode _secondTestNode = _firstTestNode;

            //Assert
            Assert.Equal(_firstTestNode.Payload, _secondTestNode.Payload);
        }

        [Fact]
        //Confirm ref assignment working correctly.
        public void PayloadsShouldBeTheSame_WherePayloadIsChangedInOneNode_ShouldReturnTrue()
        {
            //Arrange
            QueueNode _firstTestNode = new QueueNode("Hi", null);

            //Act
            QueueNode _secondTestNode = _firstTestNode;
            _secondTestNode.Payload = "Bye";

            //Assert
            Assert.Equal(_firstTestNode.Payload, _secondTestNode.Payload);
        }
        

    }
}
