using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models.Data;

public class FYTimestamp
{
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}