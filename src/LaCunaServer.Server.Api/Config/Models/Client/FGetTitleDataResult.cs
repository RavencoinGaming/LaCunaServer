using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Models.Client;

public class FGetTitleDataResult
{
    /// <summary>
    ///     [optional] a dictionary object of key / value pairs
    /// </summary>
    [JsonPropertyName("Data")]
    public Dictionary<string, string>? Data { get; set; }
}