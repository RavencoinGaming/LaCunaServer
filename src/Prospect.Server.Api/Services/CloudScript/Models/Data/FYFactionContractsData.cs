﻿using System.Text.Json.Serialization;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models.Data;

public class FYFactionContractsData
{
    [JsonPropertyName("factionId")]
    public string FactionId { get; set; } = null!;

    [JsonPropertyName("contracts")]
    public List<FYFactionContractData> Contracts { get; set; } = null!;
}