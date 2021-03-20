using System;
using QueueLibrary;
using Xunit;


namespace QueueLibrary.Tests
{
    public class QueueClassTests
    {

        [Fact]
        public void IsEmptyMethod_WhereQueueIsEmpty_ShouldRetrunTrue()
        {
            //Arrange
            QueueModel TestQueue = new QueueModel();

            //Act
            bool actual = TestQueue.IsEmpty();

            //Assert
            Assert.True(actual);

        }

        [Fact]
        public void IsEmptyMethod_WhereQueueHasOneNode_ShouldRetrunFalse()
        {
            //Arrange
            QueueModel TestQueue = new QueueModel();
            TestQueue.enqueue("Hi");

            //Act
            bool actual = TestQueue.IsEmpty();

            //Assert
            Assert.False(actual);

        }

        [Theory]
        [InlineData("Hi!")]
        public void Dequeue_WhereQueueHasOneNode_ShouldReturnEnqueuedValue(string expected)
        {
            //Arrange
            QueueModel TestQueue = new QueueModel();
            TestQueue.enqueue(expected);

            //Act
            String actual = TestQueue.dequeue().ToString();

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("Hi!")]
        public void QueueLength_AfterEnqueueAndDequeue_ShouldReturnZero(string payload)
        {
            //Arrange
            QueueModel TestQueue = new QueueModel();
            TestQueue.enqueue(payload);
            int actual = 0;

            //Act
            TestQueue.dequeue().ToString();
            actual = TestQueue.GetLength();

            //Assert
            Assert.Equal(0, actual);
        }


    }
}
