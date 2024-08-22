﻿using Newtonsoft.Json;

namespace KostalKsemApiClient.Model;

public class LoginResponse
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }

    [JsonProperty("expires_in")]
    public long ExpiresIn { get; set; }

    [JsonProperty("token_type")]
    public string TokenType { get; set; }
}