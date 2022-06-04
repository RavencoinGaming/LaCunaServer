using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYRequestMaintenanceModeStateResult
{
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}