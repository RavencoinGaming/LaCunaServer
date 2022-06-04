﻿using LaCunaServer.Server.Api.Services.CloudScript.Models;

namespace LaCunaServer.Server.Api.Services.CloudScript.Functions;

[CloudScriptFunction("GetFriendList")]
public class GetFriendList : ICloudScriptFunction<FYBaseSocialRequest, object?>
{
    public Task<object?> ExecuteAsync(FYBaseSocialRequest request)
    {
        return Task.FromResult<object?>(new
        {
            
        });
    }
}