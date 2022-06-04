using Microsoft.Extensions.Options;
using MongoDB.Driver;
using LaCunaServer.Server.Api.Config;
using LaCunaServer.Server.Api.Services.Database.Models;

namespace LaCunaServer.Server.Api.Services.Database;

public class DbEntityService : BaseDbService<PlayFabEntity>
{
    public DbEntityService(IOptions<DatabaseSettings> settings) : base(settings, nameof(PlayFabEntity))
    {
    }

    public async Task<PlayFabEntity> FindAsync(string userId)
    {
        return await Collection.Find(user => user.UserId == userId).SingleOrDefaultAsync();
    }

    private async Task<PlayFabEntity> CreateAsync(string userId)
    {
        var user = new PlayFabEntity
        {
            UserId = userId
        };
            
        await Collection.InsertOneAsync(user);

        return user;
    }

    public async Task<PlayFabEntity> FindOrCreateAsync(string userId)
    {
        return await FindAsync(userId) ?? 
               await CreateAsync(userId);
    }
}