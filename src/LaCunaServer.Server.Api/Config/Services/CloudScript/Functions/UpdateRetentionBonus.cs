using LaCunaServer.Server.Api.Services.Auth.Extensions;
using LaCunaServer.Server.Api.Services.CloudScript.Models;

namespace LaCunaServer.Server.Api.Services.CloudScript.Functions;

[CloudScriptFunction("UpdateRetentionBonus")]
public class UpdateRetentionBonus : ICloudScriptFunction<FYRetentionBonusRequest, object?>
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UpdateRetentionBonus(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Task<object?> ExecuteAsync(FYRetentionBonusRequest request)
    {
        var context = _httpContextAccessor.HttpContext;
        if (context == null)
        {
            return Task.FromResult<object?>(null);
        }

        return Task.FromResult<object?>(new
        {
            playerData = new
            {
                daysClaimed = 0,
                lastClaimTime = new
                {
                    seconds = 1635033600
                }
            },
            userId = context.User.FindAuthUserId(),
            error = (object?)null
        });
    }
}