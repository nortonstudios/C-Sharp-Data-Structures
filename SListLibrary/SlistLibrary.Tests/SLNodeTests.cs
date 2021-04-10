using SListLibrary;
using Xunit;

namespace SListLibrary.Tests
{
    public class SLNodeTests
    {
        [Fact]
        public void PayloadStoresAndReturns_NewNode_ShouldBeTrue()
        {
            //Arrange
            var expected = "hi";
            var testNode = new SLNode(expected);
            
            //Act
            var actual = testNode.GetPayload();

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SetNext_GetNextShouldReturnSetNode()
        {
            //Arrange
            var testNode = new SLNode("hi");
            var expected = new SLNode("there");
            
            //Act
            testNode.SetNext(expected);
            var actual = testNode.GetNext();

            //Assert
            Assert.Same(expected, actual);
        }
    }
}