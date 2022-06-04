using System.Text.Json.Serialization;
using LaCunaServer.Server.Api.Models.Client.Data;

namespace LaCunaServer.Server.Api.Models.Client;

public class FAddGenericIDRequest
{
    /// <summary>
    ///     Generic service identifier to add to the player account.
    /// </summary>
    [JsonPropertyName("GenericId")]
    public FGenericServiceId GenericId { get; set; } = null!;
}