namespace GetCryptoBalance.ApiEntities
{
    public class BalanceRequest
    {
        public string Currency { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public static string Route = "/info/balance";
    }
}