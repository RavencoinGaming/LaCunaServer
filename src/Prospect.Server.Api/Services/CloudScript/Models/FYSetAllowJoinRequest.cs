using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYSetAllowJoinRequest
{
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }
    
    [JsonPropertyName("allowJoin")]
    public bool AllowJoin { get; set; }
}