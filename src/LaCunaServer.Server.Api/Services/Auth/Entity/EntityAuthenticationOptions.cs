using Microsoft.AspNetCore.Authentication;

namespace LaCunaServer.Server.Api.Services.Auth.Entity;

public class EntityAuthenticationOptions : AuthenticationSchemeOptions
{
    public const string DefaultScheme = "EntityAuth";
    public string Scheme => DefaultScheme;
    public string AuthenticationType = DefaultScheme;
}