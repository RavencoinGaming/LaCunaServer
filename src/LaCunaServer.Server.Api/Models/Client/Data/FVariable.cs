using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Models.Client.Data;

public class FVariable
{
    /// <summary>
    ///     Name of the variable.
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; } = null!;
        
    /// <summary>
    ///     [optional] Value of the variable.
    /// </summary>
    [JsonPropertyName("Value")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Value { get; set; }
}