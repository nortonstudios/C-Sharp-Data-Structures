using System;
using SListLibrary;
using Xunit;
using Xunit.Sdk;


namespace SListLibrary.Tests
{

    public class SLClassTestsOneNodeList
    {
        public SingleLinkList testList = new SingleLinkList();
        public string expected = "Hi";

        //Constructor
        public SLClassTestsOneNodeList()
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
            Assert.Equal(0, testList.GetIndex());
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

        [Fact]
        public void GoToNext_OneNodeList_ShouldReturnFalse()
        {
            //Arrange
            //Act
            bool actual = testList.GoToNext();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void GoToPrevious_OneNodeList_ShouldCompile()
        {
            //Arrange
            //Act
            testList.GoToPrevious();
        }

        [Fact]
        public void GoToPrevious_OneNodeList_ShouldReturnTrue()
        {
            //Arrange
            //Act
            bool actual = testList.GoToPrevious();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Replace_OneNodeList_ShouldCompile()
        {
            //Arrange
            //Act
            testList.Replace(expected);
        }

        [Fact]
        public void Remove_OneNodeList_ShouldCompile()
        {
            //Arrange
            //Act
            testList.Remove();
        }

        [Fact]
        public void Remove_OneNodeList_IsEmptyShouldBeTrue()
        {
            //Arrange
            //Act
            testList.Remove();

            //Assert
            Assert.True(testList.IsEmpty());
        }

        [Fact]
        public void Insert_ShouldCompile_OneNodeList()
        {
            //Arrange
            string secondExpected = "there";
            
            //Act
            testList.Insert(secondExpected);

        }
        
        [Fact]
        public void Insert_GetLocationShouldReturnOne_OneNodeList()
        {
            //Arrange
            string payload = "there";
            
            //Act
            testList.Insert(payload);
            int actual = testList.GetIndex();
            
            //Assert
            Assert.Equal(1,actual);
        }

        [Fact]
        public void Clear_GetLengthShouldReturnZero_OneNodeList()
        {
            //Arrange
            //Act
            testList.Clear();
            //Assert
            Assert.Equal(0,testList.GetLength());
        }

        [Fact]
        public void Clear_GetIndexShouldThrow_OneNodeList()
        {
            //Arrange
            //Act
            testList.Clear();
            //Assert
            Assert.ThrowsAny<Exception>(() =>testList.GetIndex());
        }
        
        [Fact]
        public void Clear_IsEmptyShouldReturnTrue_OneNodeList()
        {
            //Arrange
            //Act
            testList.Clear();
            //Assert
            Assert.True(testList.IsEmpty());
        }
        
        [Fact]
        public void Clear_GetCursorShouldThrow_OneNodeList()
        {
            //Arrange
            //Act
            testList.Clear();
            //Assert
            Assert.ThrowsAny<Exception>(() =>testList.GetCursor());
        }
        
        [Fact]
        public void GetLength_GetLengthShouldReturnOne_OneNodeList()
        {
            //Arrange
            //Act
            //Assert
            Assert.Equal(1,testList.GetLength());
        }
       
    }
}