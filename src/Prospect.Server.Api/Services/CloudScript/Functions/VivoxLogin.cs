﻿using LaCunaServer.Server.Api.Services.CloudScript.Models;

namespace LaCunaServer.Server.Api.Services.CloudScript.Functions;

[CloudScriptFunction("VivoxLogin")]
public class VivoxLogin : ICloudScriptFunction<FYVivoxLoginTokenRequest, FYVivoxJoinData>
{
    public Task<FYVivoxJoinData> ExecuteAsync(FYVivoxLoginTokenRequest request)
    {
        return Task.FromResult(new FYVivoxJoinData
        {
            
        });
    }
}