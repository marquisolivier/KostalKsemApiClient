using System.Security.Authentication;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace KostalKsemApiClient.Api;

internal class KostalKsemRestClient(string baseUrl)
    : RestClient(baseUrl, configureSerialization: s => s.UseNewtonsoftJson())
{
    internal bool IsAuthenticated { get; set; }

    public void CheckAuthentication()
    {
        if (!IsAuthenticated)
            throw new AuthenticationException("This endpoint requires authentication.");
    }
}