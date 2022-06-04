﻿using MongoDB.Bson.Serialization.Attributes;

namespace LaCunaServer.Server.Api.Services.Database.Models;

public class PlayFabUserAuth
{
    [BsonElement("Type")]
    public PlayFabUserAuthType Type { get; set; }
        
    [BsonElement("Key")]
    public string Key { get; set; }
}