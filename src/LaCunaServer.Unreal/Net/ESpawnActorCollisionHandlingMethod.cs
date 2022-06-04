namespace LaCunaServer.Unreal.Net;

public enum ESpawnActorCollisionHandlingMethod
{
    Undefined,
    AlwaysSpawn,
    AdjustIfPossibleButAlwaysSpawn,
    AdjustIfPossibleButDontSpawnIfColliding,
    DontSpawnIfColliding
}