using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYUpdatePlayerPresenceStateRequest
{
    [JsonPropertyName("inMatch")]
    public bool InMatch { get; set; }
}