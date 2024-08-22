using System.Threading.Tasks;
using KostalKsemApiClient.Model.Mobility;
using Newtonsoft.Json;
using RestSharp;

namespace KostalKsemApiClient.Api;

public class MobilityEndpoint
{
    private readonly KostalKsemRestClient _client;

    internal MobilityEndpoint(KostalKsemRestClient client)
    {
        _client = client;
    }

    public async Task SetChargeMode(ChargeModeBase chargeMode)
    {
        RestRequest request = new RestRequest("e-mobility/config/chargemode");
        string json = JsonConvert.SerializeObject(chargeMode);
        request.AddParameter("application/json", json, ParameterType.RequestBody);
        RestResponse response = await _client.PutAsync(request);
    }
}