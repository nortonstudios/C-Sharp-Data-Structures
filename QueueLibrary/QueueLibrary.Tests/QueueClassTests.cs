using System;
using QueueLibrary;
using Xunit;


namespace QueueLibrary.Tests
{
    public class QueueClassTests
    {

        [Fact]
        public void ShouldRetrunTrue()
        {
            //Arrange
            QueueClass TestQueue = new QueueClass();

            //Act
            bool actual = TestQueue.IsEmpty();

            //Assert
            Assert.True(actual);

        }

        [Fact]
        public void ShouldRetrunFalse()
        {
            //Arrange
            QueueClass TestQueue = new QueueClass();
            TestQueue.enqueue("Hi");

            //Act
            bool actual = TestQueue.IsEmpty();

            //Assert
            Assert.False(actual);

        }
    }
}
