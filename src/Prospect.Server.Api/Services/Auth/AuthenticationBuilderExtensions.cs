using Microsoft.AspNetCore.Authentication;
using LaCunaServer.Server.Api.Services.Auth.Entity;
using LaCunaServer.Server.Api.Services.Auth.User;

namespace LaCunaServer.Server.Api.Services.Auth;

public static class AuthenticationBuilderExtensions
{
    public static AuthenticationBuilder AddUserAuthentication(this AuthenticationBuilder authenticationBuilder, Action<UserAuthenticationOptions> options)
    {
        return authenticationBuilder.AddScheme<UserAuthenticationOptions, UserAuthenticationHandler>(UserAuthenticationOptions.DefaultScheme, options);
    }
        
    public static AuthenticationBuilder AddEntityAuthentication(this AuthenticationBuilder authenticationBuilder, Action<EntityAuthenticationOptions> options)
    {
        return authenticationBuilder.AddScheme<EntityAuthenticationOptions, EntityAuthenticationHandler>(EntityAuthenticationOptions.DefaultScheme, options);
    }
}