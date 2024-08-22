using Newtonsoft.Json;

namespace KostalKsemApiClient.Model.DeviceSettings;

public class DeviceUsageResponse
{
    [JsonProperty("CpuLoad")]
    public long CpuLoad { get; set; }

    [JsonProperty("CpuTemp")]
    public long CpuTemp { get; set; }

    [JsonProperty("RamFree")]
    public long RamFree { get; set; }

    [JsonProperty("RamTotal")]
    public long RamTotal { get; set; }

    [JsonProperty("FlashAppFree")]
    public long FlashAppFree { get; set; }

    [JsonProperty("FlashAppTotal")]
    public long FlashAppTotal { get; set; }

    [JsonProperty("FlashDataFree")]
    public long FlashDataFree { get; set; }

    [JsonProperty("FlashDataTotal")]
    public long FlashDataTotal { get; set; }
}