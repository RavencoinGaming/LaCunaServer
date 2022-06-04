using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYBaseSocialRequest
{
    [JsonPropertyName("targetPlayFabId")]
    public string? TargetPlayFabId { get; set; }
}