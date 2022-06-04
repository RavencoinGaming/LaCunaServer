using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYGetSignalRConnection
{
    [JsonPropertyName("userId")]
    public string UserId { get; set; }
}