using Newtonsoft.Json;

namespace KostalKsemApiClient.Model.DeviceSettings;

public class DeviceStatusResponse
{
    [JsonProperty("status")]
    public string DeviceStatus { get; set; }
}