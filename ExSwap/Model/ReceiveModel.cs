using Newtonsoft.Json;

namespace ExSwap.Model;

public class ReceiveModel
{
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("user_wallet")]
    public string UserWallet { get; set; }
    [JsonProperty("exchange_data")]
    public string ExchangeData { get; set; }
}