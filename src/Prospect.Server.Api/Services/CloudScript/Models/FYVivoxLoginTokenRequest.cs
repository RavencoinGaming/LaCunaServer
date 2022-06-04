using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYVivoxLoginTokenRequest
{
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}