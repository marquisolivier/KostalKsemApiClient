using Newtonsoft.Json;

namespace KostalKsemApiClient.Model.DeviceSettings;

public class CreationYearResponse
{
    [JsonProperty("creation_year")]
    public int? CreationYear { get; set; }
}