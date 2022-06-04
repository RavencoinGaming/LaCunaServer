using LaCunaServer.Unreal.Core;
using LaCunaServer.Unreal.Core.Objects;
using LaCunaServer.Unreal.Net;
using LaCunaServer.Unreal.Net.Actors;

namespace LaCunaServer.Unreal.Runtime;

public class UGameInstance
{
    public AGameModeBase? CreateGameModeForURL(FUrl inUrl, UWorld inWorld)
    {
        // TODO: World.SpawnActor
        
        var spawnInfo = new FActorSpawnParameters
        {
            SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn,
            ObjectFlags = EObjectFlags.RF_Transient
        };
        
        return inWorld.SpawnActor<AGameModeBase>(GUClassArray.StaticClass<AGameModeBase>(), spawnInfo);
    }
}