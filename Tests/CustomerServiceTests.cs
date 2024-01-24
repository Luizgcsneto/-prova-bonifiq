using Moq;
using ProvaPub.Repository;
using Xunit;

namespace ProvaPub.Tests
{

    public class CustomerServiceTests
    {
        [Fact]
        public void Can_Purchase_Test()
        {
            // arrange
            const int customerID = 1;
            const decimal purchaseValue = 100;
            TestDbContext _ctx;


            var dbContextMock = new Mock<TestDbContext>();
            //act



            //Assert
          //  Assert.Equal()

         //   return Task.FromResult(false);
        }
    }
}
