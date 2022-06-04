﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using LaCunaServer.Server.Api.Services.Database.Models;

namespace LaCunaServer.Server.Api.Services.Auth;

public class AuthTokenService
{
    private const string DefaultIssuer = "LaCunaServerApi";
    private const string DefaultAudience = "LaCunaServer";
        
    private readonly SymmetricSecurityKey _securityKey;
    private readonly JwtSecurityTokenHandler _tokenHandler;
        
    public AuthTokenService(IOptions<AuthTokenSettings> options)
    {
        _securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(options.Value.Secret));
        _tokenHandler = new JwtSecurityTokenHandler();
    }

    private string CreateToken(IEnumerable<Claim> claims)
    {
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(7),
            Issuer = DefaultIssuer,
            Audience = DefaultAudience,
            SigningCredentials = new SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha256Signature)
        };

        var token = _tokenHandler.CreateToken(tokenDescriptor);
        return _tokenHandler.WriteToken(token);
    }

    public string GenerateUser(PlayFabEntity entity)
    {
        return CreateToken(new[]
        {
            new Claim(AuthClaimTypes.UserId, entity.UserId),
            new Claim(AuthClaimTypes.EntityId, entity.Id),
            new Claim(AuthClaimTypes.Type, AuthType.User),
        });
    }

    public string GenerateEntity(PlayFabEntity entity)
    {
        return CreateToken(new[]
        {
            new Claim(AuthClaimTypes.UserId, entity.UserId),
            new Claim(AuthClaimTypes.EntityId, entity.Id),
            new Claim(AuthClaimTypes.Type, AuthType.Entity),
        });
    }

    public ClaimsPrincipal Validate(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
            
        try
        {
            return tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidIssuer = DefaultIssuer,
                ValidAudience = DefaultAudience,
                IssuerSigningKey = _securityKey
            }, out _);
        }
        catch
        {
            return null;
        }
    }
}