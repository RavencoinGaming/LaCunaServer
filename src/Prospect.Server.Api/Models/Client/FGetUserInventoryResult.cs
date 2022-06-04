using System.Text.Json.Serialization;
using LaCunaServer.Server.Api.Models.Client.Data;

namespace LaCunaServer.Server.Api.Models.Client;

public class FGetUserInventoryResult
{
    /// <summary>
    ///     [optional] Array of inventory items belonging to the user.
    /// </summary>
    [JsonPropertyName("Inventory")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public List<FItemInstance>? Inventory { get; set; }
        
    /// <summary>
    ///     [optional] Array of virtual currency balance(s) belonging to the user.
    /// </summary>
    [JsonPropertyName("VirtualCurrency")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Dictionary<string, int>? VirtualCurrency { get; set; }
        
    /// <summary>
    ///     [optional] Array of virtual currency balance(s) belonging to the user.
    /// </summary>
    [JsonPropertyName("VirtualCurrencyRechargeTimes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Dictionary<string, FVirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}