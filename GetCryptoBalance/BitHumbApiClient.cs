using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using GetCryptoBalance.ApiEntities;

namespace GetCryptoBalance
{
    public class BitHumbApiClient : IBitHumbApiClient
    {
        private readonly BitHumbSettings _settings;
        private readonly HttpClient _client;
        
        public BitHumbApiClient(BitHumbSettings settings, HttpClient client)
        {
            _settings = settings;
            _client = client;
        }
        public async ValueTask<BalanceResponse> GetBalance(string currency)
        {
            var content = new StringContent(JsonSerializer.Serialize(new BalanceRequest
            {
                 ApiKey = _settings.ApiKey,
                 SecretKey = _settings.ApiKey,
                 Currency = currency
            }));
    
            var response = await _client.PostAsync(_settings.ApiLink + BalanceRequest.Route, content);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException(response.ReasonPhrase);
            var responseEntity = JsonSerializer.Deserialize<BalanceResponse>(
                response.Content.ToString() ?? throw new HttpRequestException(response.ReasonPhrase));
            if (responseEntity?.RequestStatus != "0000")
                throw new Exception($"Got message from bithumb with error code {responseEntity?.RequestStatus}");
            return responseEntity;
        }
    }
}