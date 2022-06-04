using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Models.Client.Data;

public class FTreatmentAssignment
{
    /// <summary>
    ///     [optional] List of the experiment variables.
    /// </summary>
    [JsonPropertyName("Variables")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public List<FVariable>? Variables { get; set; }
        
    /// <summary>
    ///     [optional] List of the experiment variants.
    /// </summary>
    [JsonPropertyName("Variants")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public List<string>? Variants { get; set; }
}