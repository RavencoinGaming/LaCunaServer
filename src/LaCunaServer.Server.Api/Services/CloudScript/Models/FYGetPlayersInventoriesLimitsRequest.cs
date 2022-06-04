using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYGetPlayersInventoriesLimitsRequest
{
    [JsonPropertyName("userIds")]
    public List<string>? UserIds { get; set; }
}