using System.Text.Json.Serialization;
using LaCunaServer.Server.Api.Services.CloudScript.Models.Data;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYVivoxJoinData
{
    [JsonPropertyName("request")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public FYVivoxJoinTokenRequest? Request { get; set; }
    
    [JsonPropertyName("token")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Token { get; set; }
}