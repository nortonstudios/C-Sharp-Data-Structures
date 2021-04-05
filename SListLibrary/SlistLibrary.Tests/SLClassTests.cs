using SListLibrary;
using Xunit;


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
        public void ShouldHaveLocationOfZero_NewEmptyList()
        {
            //Arrange
            //Act
            //Assert
            Assert.Equal(0,testList.GetLocation());
        }

        //Act
        //use testLIst, why doesnt it work?
        
        
        
        [Fact]
        public void ShouldInsertNewNode_OnAnEmptyList()
        {
            
            //Act
            testList.Insert(actual);

            //Assert
            


        }
        
    }
}