using System;
using SListLibrary;
using Xunit;
using Xunit.Sdk;

namespace SListLibrary.Tests
{
    public class SLClassTestsEmptyList
    {
        public SingleLinkList testList = new SingleLinkList();
        public string expected = "Hi";

        [Fact]
        public void ShouldCreateNewListObject()
        {
            //Arrange
            //Act
            //Assert
            Assert.NotNull(testList);
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrue_NewEmptyList()
        {
            //Assert
            Assert.True(testList.IsEmpty());
        }

        [Fact]
        public void GetCursor_ShouldThrow_NewEmptyList()
        {
            //Arrange 
            //Act
            //Assert
            Assert.ThrowsAny<Exception>(() => testList.GetCursor());
        }

        [Fact]
        public void GoToEnd_ShouldThrow_NewEmptyList()
        {
            //Arrange 
            //Act
            //Assert
            Assert.ThrowsAny<Exception>(() => testList.GetCursor());
        }

        [Fact]
        public void GetLocation_NewEmptyList_ShouldThrowError()
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsAny<Exception>(() => testList.GetIndex());
        }

        [Fact]
        public void ShouldInsertNewNode_OnAnEmptyList_ShouldCompile()
        {
            //Arrange
            testList.Insert(expected);

        }

        [Fact]
        public void GoToPrevious_EmptyList_ShouldReturnFalse()
        {
            //Arrange
            //Act
            bool actual = testList.GoToPrevious();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Replace_EmptyList_ShouldThrow()
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsAny<Exception>(() => testList.Replace(expected));

        }

        [Fact]
        public void Remove_EmptyList_ShouldThrow()
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsAny<Exception>(() => testList.Remove());

        }

        [Fact]
        public void Clear_EmptyList_ShouldCompile()
        {
            //Arrange
            //Act
            testList.Clear();
        }

        [Fact]
        public void Clear_IsEmptyShouldReturnTrue_NewEmptyList()
        {
            //Arrange
            //Act
            testList.Clear();
            //Assert
            Assert.True(testList.IsEmpty());
        }
        
        [Fact]
        public void Clear_GetLengthShouldReturnZero_OneNodeList()
        {
            //Arrange
            //Act
            //Assert
            Assert.Equal(0, testList.GetLength());
        }
        
        [Fact]
        public void GetLength_ShouldReturnZero_NewEmptyList()
        {
            //Arrange 
            //Act
            //Assert
            Assert.Equal(0, testList.GetLength());
        }

    }

}