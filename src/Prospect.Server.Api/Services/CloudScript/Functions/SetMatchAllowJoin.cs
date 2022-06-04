using LaCunaServer.Server.Api.Services.CloudScript.Models;

namespace LaCunaServer.Server.Api.Services.CloudScript.Functions;

[CloudScriptFunction("SetMatchAllowJoin")]
public class SetMatchAllowJoin : ICloudScriptFunction<FYSetAllowJoinRequest, object?>
{
    public Task<object?> ExecuteAsync(FYSetAllowJoinRequest request)
    {
        return Task.FromResult<object?>(new
        {
            sessionId = (object?)null,
            success = false
        });
    }
}