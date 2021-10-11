using System.Threading.Tasks;
using GetCryptoBalance.ApiEntities;

namespace GetCryptoBalance
{
    public interface IBitHumbApiClient
    {
        ValueTask<BalanceResponse> GetBalance(string currency);
    }
}