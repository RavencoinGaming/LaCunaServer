﻿using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Models.Client.Data;

public class FGenericServiceId
{
    /// <summary>
    ///     Name of the service for which the player has a unique identifier.
    /// </summary>
    [JsonPropertyName("ServiceName")]
    public string ServiceName { get; set; } = null!;
        
    /// <summary>
    ///     Unique identifier of the player in that service.
    /// </summary>
    [JsonPropertyName("UserId")]
    public string UserId { get; set; } = null!;
}