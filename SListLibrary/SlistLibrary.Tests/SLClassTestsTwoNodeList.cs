using System.Collections.Generic;
using Xunit;

namespace SListLibrary.Tests
{
    public class SLClassTestsTwoNodeList
    {
        public SingleLinkList testList = new SingleLinkList();
        public List<string> expected = new() {"Hi", "there"};

        //Constructor
        public SLClassTestsTwoNodeList()
        {
            foreach (var payload in expected)
            {
                testList.Insert(payload);
            }
        }

        //Tests
        [Fact]
        public void GetLocation_TwoNodeList_ShouldBeLocationOne()
        {
            //Assert
            Assert.Equal(1, testList.GetIndex());
        }


        [Fact]
        public void GetCursor_TwoNodeList_ShouldReturnExpectedString()
        {
            //Arrange

            //Act 
            string actual = testList.GetCursor().ToString();

            //Assert
            Assert.Equal(expected[1], actual);
        }

        [Fact]
        public void GoToBeginning_TwoNodeList_ShouldCompile()
        {
            //Arrange
            //Act 
            testList.GoToBeginning();
        }

        [Fact]
        public void GoToEnd_TwoNodeList_ShouldReturnCorrectValue()
        {
            //Arrange
            testList.GoToEnd();

            //Act
            string actual = testList.GetCursor().ToString();

            //Assert
            Assert.Equal(expected[1], actual);

        }

        [Fact]
        public void GoToNext_TwoNodeList_ShouldReturnFalse()
        {
            //Arrange
            //Act
            bool actual = testList.GoToNext();

            //Assert
            Assert.False(actual);
        }


        [Fact]
        public void GoToPrevious_TwoNodeList_ShouldReturnTrue()
        {
            //Arrange
            //Act
            bool actual = testList.GoToPrevious();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Replace_TowNodeList_ShouldReturnExpected()
        {
            //Arrange
            string expected = "Kenobi";

            //Act
            testList.Replace(expected);
            string actual = testList.GetCursor().ToString();

            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Remove_TwoNodeList_ShouldCompile()
        {
            //Arrange
            //Act
            testList.Remove();
        }

        [Fact]
        public void Remove_TwoNodeList_IsEmptyShouldBeTrue()
        {
            //Arrange
            //Act
            testList.Remove();
            int actual = testList.GetLength();

            //Assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Remove_AtEndOfTwoNodeList_IsReturnValueOfPrecedingNode()
        {


            //Arrange
            //Act
            testList.Remove();
            string actual = testList.GetCursor().ToString();

            //Assert
            Assert.Equal(expected[0], actual);
        }

        [Fact]
        public void Remove_AtBeginningOfTwoNodeList_IsReturnValueOfPrecedingNode()
        {
            //Arrange
            testList.GoToBeginning();
            //Act
            testList.Remove();
            string actual = testList.GetCursor().ToString();

            //Assert
            Assert.Equal(expected[1], actual);
        }


        [Fact]
        public void Insert_ShouldReturnInsertedValue_TwoNodeList()
        {
            //Arrange
            string expected = "Kenobi";

            //Act
            testList.Insert(expected);
            string actual = testList.GetCursor().ToString();

            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Insert_GetLocationShouldReturnTwo_TwoNodeList()
        {
            //Arrange
            string payload = "Kenobi";

            //Act
            testList.Insert(payload);
            int actual = testList.GetIndex();

            //Assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Clear_GetLengthShouldReturnZero_OneNodeList()
        {
            //Arrange
            //Act
            testList.Clear();
            //Assert
            Assert.Equal(0, testList.GetLength());
        }

        [Fact]
        public void GetLength_GetLengthShouldReturnTwo_TwoNodeList()
        {
            //Arrange
            //Act
            //Assert
            Assert.Equal(2, testList.GetLength());
        }

        [Fact]
        public void Clear_IsEmptyShouldReturnTrue_TwoNodeList()
        {
            //Arrange
            //Act
            testList.Clear();
            //Assert
            Assert.True(testList.IsEmpty());
        }
    }
}