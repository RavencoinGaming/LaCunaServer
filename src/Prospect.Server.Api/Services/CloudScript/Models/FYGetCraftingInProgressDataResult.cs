﻿using System.Text.Json.Serialization;
using LaCunaServer.Server.Api.Services.CloudScript.Models.Data;

namespace LaCunaServer.Server.Api.Services.CloudScript.Models;

public class FYGetCraftingInProgressDataResult
{
    [JsonPropertyName("userId")]
    public string UserId { get; set; } = null!;

    [JsonPropertyName("error")] 
    public string Error { get; set; } = null!;
        
    [JsonPropertyName("itemCurrentlyBeingCrafted")]
    public FYItemCurrentlyBeingCrafted ItemCurrentlyBeingCrafted { get; set; } = null!;
}