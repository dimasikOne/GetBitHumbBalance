using Microsoft.Extensions.Configuration;

namespace GetCryptoBalance
{
    public class BitHumbSettings
    {
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string ApiLink { get; set; }

        public BitHumbSettings()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
             
            var configuration = builder.Build();
            ApiKey = configuration["ApiKey"];
            SecretKey = configuration["SecretKey"];
            ApiLink = configuration["ApiLink"];
        }
    }
}