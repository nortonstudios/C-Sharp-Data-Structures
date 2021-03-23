using System;
using System.Collections.Generic;
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

        [Theory]
        [InlineData("Hello", "there", "Kenobi")]
        public void Dequeue_AfterMultipleEnqueues_ShouldReturnListOfObjects(string first, string second, string third)
        {
            //Arrange
            List<string> expected = new List<string>(new string[] { first, second, third });
            QueueModel testQueue = new QueueModel();
            foreach (var str in expected)
            {
                testQueue.enqueue(str);
            }
            List<object> actual = new List<object>();

            //Act
            for (int i = 0; i < expected.Count; i++)
            {
                actual.Add(testQueue.dequeue());
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
                testQueue.enqueue(str);
            }
            List<object> actual;

            //Act
            actual = testQueue.Dump();

            //Assert
            Assert.Equal<object>(expected, actual);
        }


    }
}
