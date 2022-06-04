using LaCunaServer.Unreal.Net.Actors;

namespace LaCunaServer.Unreal.Runtime;

public class UPlayer
{
    public APlayerController? PlayerController { get; set; }
    
    public int CurrentNetSpeed { get; set; }
}