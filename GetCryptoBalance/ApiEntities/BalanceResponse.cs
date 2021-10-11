using System.Text.Json.Serialization;

namespace GetCryptoBalance.ApiEntities
{
    public class BalanceResponse
    {
        [JsonPropertyName("status")] 
        public string RequestStatus { get; set; }
        public BalanceResponseData Data { get; set; }
    }

    public class BalanceResponseData
    {
        [JsonPropertyName("total_bt")]
        public string TotalBt { get; set; }
        [JsonPropertyName("total_krw")]
        public string TotalKrw { get; set; }
        [JsonPropertyName("in_use_btc")]
        public string InUseBtc{ get; set; }
        [JsonPropertyName("in_use_krw")]
        public string InUseKrw { get; set; }
        [JsonPropertyName("available_btc")]
        public string AvailableBtc { get; set; }
        [JsonPropertyName("available_krw")]
        public string AvailableKrw { get; set; }
        [JsonPropertyName("xcoin_last_btc")]
        public string XCoinLastBtc { get; set; }
    }
}