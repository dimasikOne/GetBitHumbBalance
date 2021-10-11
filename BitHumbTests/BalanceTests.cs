using System.Threading.Tasks;
using Xunit;

namespace BitHumbTests
{
    public class BalanceTests : BitHumbTestBase
    {
        [Fact]
        public async Task GetBalanceTest_SuccessCase()
        {
            //Act
            var response = await ApiClient.GetBalance(DefaultCurrency);
            
            //Assert
            Assert.NotNull(response);
        }
    }
}