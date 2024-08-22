using System;
using System.Threading.Tasks;
using KostalKsemApiClient.Model;
using RestSharp;

namespace KostalKsemApiClient.Api;

public class Client
{      
    private const string WebLoginToken = "web-login/token";
    private readonly KostalKsemRestClient _client;

    public MobilityEndpoint Mobility { get; }
    public ProcessDataEndpoint ProcessData { get; }
    public DeviceSettingsEndpoint DeviceSettings { get; }
        

    /// <summary>
    /// Start point of the API. Create a session object, from which you can reach all the API endpoints under Auth, Events, Info, LogData, ProcessData, Modules and Settings properties. You can login or not, but keep in mind that some of endpoints requires authenfication.
    /// </summary>
    /// <param name="host"></param>
    public Client(string host)
    {
        _client = new($"http://{host}/api");
        Mobility = new (_client);
        DeviceSettings = new(_client);
        ProcessData = new(_client);
    }

    /// <summary>
    /// API Login 
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    public async Task Login(string password)
    {
        const string grantType = "password";
        const string clientId = "emos";
        const string clientSecret = "56951025";
        const string username = "admin";

        password = Uri.EscapeDataString(password);
        RestRequest request = new RestRequest(WebLoginToken);
        request.AddParameter("application/x-www-form-urlencoded", $"grant_type={grantType}&client_id={clientId}&client_secret={clientSecret}&username={username}&password={password}", ParameterType.RequestBody);
        LoginResponse response = await _client.PostAsync<LoginResponse>(request);
        if (response != null && !string.IsNullOrEmpty(response.AccessToken))
        {
            _client.IsAuthenticated = true;
            _client.AddDefaultHeader("Authorization", "Bearer " + response.AccessToken);
        }
        else
        {
            _client.IsAuthenticated = false;
        }
    }
}