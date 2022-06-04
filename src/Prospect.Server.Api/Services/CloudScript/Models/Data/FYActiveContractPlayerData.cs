using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models.Data;

public class FYActiveContractPlayerData
{
    [JsonPropertyName("contractId")] 
    public string ContractId { get; set; } = null!;

    [JsonPropertyName("progress")]
    public List<int> Progress { get; set; } = null!;
}