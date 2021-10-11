using System;
using GetCryptoBalance;
using Microsoft.Extensions.DependencyInjection;

namespace BitHumbTests
{
    public class BitHumbTestBase
    {
        protected readonly IBitHumbApiClient ApiClient;
        protected const string DefaultCurrency = "BTC";

        protected BitHumbTestBase()
        {
            var services = new ServiceCollection();
            
            services
                .AddSingleton<IBitHumbApiClient, BitHumbApiClient>()
                .AddSingleton<BitHumbSettings>()
                .AddHttpClient();
            var serviceProvider = services.BuildServiceProvider();
            ApiClient = serviceProvider.GetRequiredService<IBitHumbApiClient>();
        }
    }
}