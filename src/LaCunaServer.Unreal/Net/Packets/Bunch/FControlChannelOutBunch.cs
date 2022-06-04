using LaCunaServer.Unreal.Net.Channels;

namespace LaCunaServer.Unreal.Net.Packets.Bunch;

public class FControlChannelOutBunch : FOutBunch
{
    public FControlChannelOutBunch(UChannel inChannel, bool bClose) : base(inChannel, bClose)
    {
        bReliable = true;
    }
}