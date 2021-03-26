using System;
using System.Collections.Generic;
using QueueLibrary;
using Xunit;


namespace QueueLibrary.Tests
{
    public class QueueClassTests
    {

        [Fact]
        public void IsEmptyMethod_WhereQueueIsEmpty_ShouldReturnTrue()
        {
            //Arrange
            QueueModel testQueue = new QueueModel();

            //Act
            bool actual = testQueue.IsEmpty();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsEmptyMethod_WhereQueueHasOneNode_ShouldReturnFalse()
        {
            //Arrange
            QueueModel testQueue = new QueueModel();
            testQueue.Enqueue("Hi");

            //Act
            bool actual = testQueue.IsEmpty();

            //Assert
            Assert.False(actual);
        }

        [Theory]
        [InlineData("Hi!")]
        public void Dequeue_WhereQueueHasOneNode_ShouldReturnEnqueuedValue(string expected)
        {
            //Arrange
            QueueModel testQueue = new QueueModel();
            testQueue.Enqueue(expected);

            //Act
            String actual = testQueue.Dequeue().ToString();

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("Hi!")]
        public void QueueLength_AfterEnqueueAndDequeue_ShouldReturnZero(string payload)
        {
            //Arrange
            QueueModel testQueue = new QueueModel();
            testQueue.Enqueue(payload);
            int actual = 0;

            //Act
            testQueue.Dequeue().ToString();
            actual = testQueue.GetLength();

            //Assert
            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData("Hello", "there", "Kenobi")]
        public void Dequeue_AfterMultipleEnqueues_ShouldReturnListOfObjects(string first, string second, string third)
        {
            //Arrange
            List<string> expected = new List<string>(new string[] { first, second, third });
            QueueModel testQueue = new QueueModel();
            foreach (var str in expected)
            {
                testQueue.Enqueue(str);
            }
            List<object> actual = new List<object>();

            //Act
            for (int i = 0; i < expected.Count; i++)
            {
                actual.Add(testQueue.Dequeue());
            }

            //Assert
            Assert.Equal<object>(expected, actual);
        }


        [Theory]
        [InlineData("Hello", "there", "Kenobi")]
        public void DumpQueue_ShouldReturnListOfObjects(string first, string second, string third)
        {
            //Arrange
            List<string> expected = new List<string>( new string[]{ first, second, third });
            QueueModel testQueue = new QueueModel();
            foreach (var str in expected)
            { 
                testQueue.Enqueue(str);
            }
            
            //Act
            List<object> actual = testQueue.Dump();

            //Assert
            Assert.Equal<object>(expected, actual);
        }
    }
}
