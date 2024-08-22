using System.Threading.Tasks;
using KostalKsemApiClient.Model.DeviceSettings;
using RestSharp;

namespace KostalKsemApiClient.Api;

public class DeviceSettingsEndpoint
{
    private readonly KostalKsemRestClient _client;

    internal DeviceSettingsEndpoint(KostalKsemRestClient client)
    {
        _client = client;
    }

    public async Task<int?> GetCreationYear()
    {
        RestRequest request = new RestRequest("device-settings/creationyear");
        CreationYearResponse response = await _client.GetAsync<CreationYearResponse>(request);
        return response?.CreationYear;
    }
    public async Task<string> GetDeviceStatus()
    {
        RestRequest request = new RestRequest("device-settings/devicestatus");
        DeviceStatusResponse response = await _client.GetAsync<DeviceStatusResponse>(request);
        return response?.DeviceStatus;
    }

    public async Task<DeviceUsageResponse> GetDeviceUsage()
    {
        RestRequest request = new RestRequest("device-settings/deviceusage");
        DeviceUsageResponse response = await _client.GetAsync<DeviceUsageResponse>(request);
        return response;
    }
}