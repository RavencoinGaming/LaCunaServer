using Microsoft.AspNetCore.Authentication;

namespace LaCunaServer.Server.Api.Services.Auth.User;

public class UserAuthenticationOptions : AuthenticationSchemeOptions
{
    public const string DefaultScheme = "UserAuth";
    public string Scheme => DefaultScheme;
    public string AuthenticationType = DefaultScheme;
}