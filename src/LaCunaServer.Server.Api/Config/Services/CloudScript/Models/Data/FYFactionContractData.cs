﻿using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models.Data;

public class FYFactionContractData
{
    [JsonPropertyName("contractId")]
    public string ContractId { get; set; } = null!;

    [JsonPropertyName("contractIsLockedDueToLowFactionReputation")]
    public bool ContractIsLockedDueToLowFactionReputation { get; set; }
}