using System;
using SListLibrary;
using Xunit;
using Xunit.Sdk;


namespace SListLibrary.Tests
{
    public class SLClassTests
    {
        public SLClass testList = new SLClass();
        public string actual = "Hi";

        [Fact]
        public void ShouldCreateNewListObject()
        {
            //Arrange
            //Act
            //Assert
            Assert.NotNull(testList);
        }

        [Fact]
        public void IsEmptyShouldReturnTrue_NewEmptyList()
        {
            //Assert
            Assert.True(testList.IsEmpty());
        }

        [Fact]
        public void GetLocation_NewEmptyList_ShouldThrowError()
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsAny<Exception>(() => testList.GetLocation());
        }
        
        [Fact]
        public void ShouldInsertNewNode_OnAnEmptyList_ShouldCompile()
        {
            //Arrange
            testList.Insert(actual);
            
        }
    }

    public class OneNodeSLClassTests
    {
        public SLClass testList = new SLClass();
        public string expected = "Hi";

        //Constructor
        public OneNodeSLClassTests()
        {
            testList.Insert(expected);
        }

        //Tests
        [Fact]
        public void IsEmpty_OneNodeList_ShouldReturnFalse()
        {
            //Assert
            Assert.False(testList.IsEmpty());
        }

        [Fact]
        public void GetLocation_OneNodeList_ShouldBeLocationZero()
        {
            //Assert
            Assert.Equal(0, testList.GetLocation());
        }

        [Fact]
        public void GetCursor_OneNodeList_ShouldReturnExpectedString()
        {
            //Arrange

            //Act 
            string actual = testList.GetCursor().ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GoToBeginning_OneNodeList_ShouldCompile()
        {
            //Arrange
            //Act 
            testList.GoToBeginning();
        }

        [Fact]
        public void GoToEnd_OneNodeList_ShouldCompile()
        {
            //Arrange
            //Act
            testList.GoToEnd();
        }

        [Fact]
        public void GoToNext_OneNodeList_ShouldCompile()
        {
            //Arrange
            //Act
            testList.GoToNext();
        }
}
}