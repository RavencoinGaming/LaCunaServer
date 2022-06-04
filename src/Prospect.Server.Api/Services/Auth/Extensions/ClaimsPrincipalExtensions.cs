using System.Security.Claims;
using LaCunaServer.Server.Api.Exceptions;

namespace LaCunaServer.Server.Api.Services.Auth.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string FindAuthUserId(this ClaimsPrincipal principal)
    {
        return Find(principal, AuthClaimTypes.UserId);
    }
        
    public static string FindAuthEntityId(this ClaimsPrincipal principal)
    {
        return Find(principal, AuthClaimTypes.EntityId);
    }
        
    public static string FindAuthType(this ClaimsPrincipal principal)
    {
        return Find(principal, AuthClaimTypes.Type);
    }

    private static string Find(ClaimsPrincipal principal, string claimType)
    {
        var claim = principal.FindFirst(claimType);
        if (claim == null)
        {
            throw new LaCunaServerException($"Failed to find claim {claimType}");
        }

        return claim.Value;
    }
}