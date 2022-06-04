using MongoDB.Bson.Serialization.Attributes;
using LaCunaServer.Server.Api.Services.Database.Generator;

namespace LaCunaServer.Server.Api.Services.Database.Models;

/// <summary>
///     title_player_account
/// </summary>
public class PlayFabEntity
{
    [BsonId(IdGenerator = typeof(PlayFabIdGenerator))]
    public string Id { get; set; }
        
    [BsonRequired]
    [BsonElement("UserId")]
    public string UserId { get; set; }
}