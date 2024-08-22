using Newtonsoft.Json;

namespace KostalKsemApiClient.Model.Mobility;

public abstract class ChargeModeBase
{
    [JsonProperty("mode")]
    public string Mode { get; set; }

    [JsonProperty("mincharginpowerquota")]
    public int? MinChargingPowerQuota { get; set; }

    [JsonProperty("minpvpowerquota")]
    public int MinPvPowerQuota { get; set; }
}