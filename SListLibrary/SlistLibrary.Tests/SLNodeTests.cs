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
    }
}