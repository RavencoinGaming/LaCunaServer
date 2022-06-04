namespace LaCunaServer.Unreal.Net;

public class FNetGUIDCache
{
    public FNetGUIDCache(UNetDriver driver)
    {
        Driver = driver;
    }

    public UNetDriver Driver { get; }
}